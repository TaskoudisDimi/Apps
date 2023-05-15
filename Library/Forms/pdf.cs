using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms.Forms
{
    public partial class pdf : Form
    {
        Document document = new Document();
        private Thread thread;
        private event Action completed;

        public pdf()
        {
            InitializeComponent();
            completed += ManageThreads_QueryCompleted;

        }

        private void ManageThreads_QueryCompleted()
        {
            MessageBox.Show("Query completed successfully!");
        }

        private void pdf_Load(object sender, EventArgs e)
        {
            //SqlConnect loaddata = new SqlConnect();
            //loaddata.retrieveData("Select * From ProductTbl");
            //dataGridView.DataSource = loaddata.table;

        }

        private void importButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog()
            {
                Filter = "pdf (*.pdf)|*.pdf",
                Title = "pdf Files",
                RestoreDirectory = true
            };
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                PdfReader reader = new PdfReader(dialog.FileName);
                string text = string.Empty;

                for(int i = 1; i <= reader.NumberOfPages; i++)
                {
                    text += PdfTextExtractor.GetTextFromPage(reader, i);
                }
                reader.Close();

                string[] lines = text.Split('\n');
                string[] headers = lines[0].Split(' ');

                // create a new DataTable with the column headers
                DataTable dataTable = new DataTable();
                foreach (string header in headers)
                {
                    dataTable.Columns.Add(header);
                }

                // add the data to the DataTable
                for (int i = 1; i < lines.Length; i++)
                {
                    string[] values = lines[i].Split(' ');
                    if (values.Length == headers.Length)
                    {
                        DataRow row = dataTable.NewRow();
                        for (int j = 0; j < values.Length; j++)
                        {
                            row[j] = values[j];
                        }
                        dataTable.Rows.Add(row);
                    }
                }

                // bind the DataTable to the DataGridView
                dataGridView.DataSource = dataTable;

            }

            if (thread != null && thread.IsAlive)
            {
                MessageBox.Show("Another query is already running. Please wait for it to finish.");
                return;
            }

            thread = new Thread(() =>
            {
                OnQueryCompleted();
            });

            thread.Start();
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog
            {
                Filter = "pdf (*.pdf)|*.pdf",
                Title = "pdf Files",
                RestoreDirectory = true
            };
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                PdfWriter.GetInstance(document, new FileStream(dialog.FileName, FileMode.Create));
                document.Open();
                PdfPTable table = new PdfPTable(dataGridView.Columns.Count);
                foreach(DataGridViewColumn column in dataGridView.Columns)
                {
                    table.AddCell(new Phrase(column.HeaderText));
                }

                foreach(DataGridViewRow row in dataGridView.Rows)
                {
                    foreach(DataGridViewCell cell in row.Cells)
                    {
                        table.AddCell(new Phrase(cell.Value?.ToString()));
                    }
                }
                document.Add(table);
                document.Close();

            }


        }

        private void OnQueryCompleted()
        {
            completed?.Invoke();
        }


    }
}
