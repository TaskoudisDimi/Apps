using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using OfficeOpenXml;
using System.Data.OleDb;

namespace Library
{
    public partial class Form4 : Form
    {
        //public static string constring = ConfigurationManager.ConnectionStrings["Tutorial"].ConnectionString;
        //SqlConnection con = new SqlConnection(constring);
        SqlConnect loaddata = new SqlConnect();
        
        public Form4()
        {
            InitializeComponent();


            //using (SqlConnection connection = new SqlConnection(constring))
            //{
            //    connection.Open();
            //    SqlDataAdapter adapter = new SqlDataAdapter("Select * From [smarketdb].[dbo].[CategoryTbl]", con);
            //    DataTable tbl = new DataTable();
            //    adapter.Fill(tbl);
            //    copyDataGridView.DataSource = tbl;
            //    connection.Close();

            //    //foreach (DataRow item in tbl.Rows)
            //    //{
            //    //    int n = copyDataGridView.Rows.Add();
            //    //    copyDataGridView.Rows[n].Cells[1].Value = item["CatId"].ToString();
            //    //    copyDataGridView.Rows[n].Cells[2].Value = item["CatName"].ToString();
            //    //    copyDataGridView.Rows[n].Cells[3].Value = item["CatDesc"].ToString();

            //    //}
            //}


            //SqlDataAdapter adapter = new SqlDataAdapter("Select * From CategoryTbl", con);
            //DataTable tbl = new DataTable();
            //adapter.Fill(tbl);
            //copyDataGridView.Rows.Clear();

            loaddata.retrieveData("Select * From Categorytbl");
            excelDataGridView.DataSource = loaddata.table;

            //foreach (DataRow item in loaddata.table.Rows)
            //{
            //    int n = copyDataGridView.Rows.Add();
            //    copyDataGridView.Rows[n].Cells[1].Value = item["Catid"].ToString();
            //    copyDataGridView.Rows[n].Cells[2].Value = item["CatName"].ToString();
            //    copyDataGridView.Rows[n].Cells[3].Value = item["CatDesc"].ToString();

            //}

            ////Insert CheckBox
            //DataGridViewCheckBoxColumn checkColumn = new DataGridViewCheckBoxColumn();
            //checkColumn.Name = "Test checkBox";
            //checkColumn.HeaderText = "Test checkBox";
            //checkColumn.ReadOnly = false;
            //copyDataGridView.Columns.Add(checkColumn);
            //copyDataGridView.Columns["Test checkBox"].DisplayIndex = 0;


        }


        private void browseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog()
            {
                Title = "Browse Text File",
                CheckFileExists = true,
                CheckPathExists = true,
                Filter = "txt files (*.txt)|*.txt",
                FilterIndex = 2,
                RestoreDirectory = true,
                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                importFiletextBox.Text = openFileDialog1.FileName;
                Helper.file = importFiletextBox.Text;

                importFileDataGridView.DataSource = Helper.DataTableFromTextFile(importFiletextBox.Text);

            }
        }

        private void selectAllButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < copyDataGridView.Rows.Count; i++)
            {
                copyDataGridView.Rows[i].Cells[0].Value = true;
            }
        }

        private void DiselectAllButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < copyDataGridView.Rows.Count; i++)
            {
                copyDataGridView.Rows[i].Cells[0].Value = false;
            }
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            copyData();
        }

        public void copyData()
        {
            pasteDataGridView.Rows.Clear();
            for (int i = 0; i < copyDataGridView.Rows.Count; i++)
            {
                if (Convert.ToBoolean(copyDataGridView.Rows[i].Cells[0].Value) == true)
                {
                    int n = pasteDataGridView.Rows.Add();
                    pasteDataGridView.Rows[n].Cells[0].Value = copyDataGridView.Rows[n].Cells[1].Value.ToString();
                    pasteDataGridView.Rows[n].Cells[1].Value = copyDataGridView.Rows[n].Cells[2].Value.ToString();
                    pasteDataGridView.Rows[n].Cells[2].Value = copyDataGridView.Rows[n].Cells[3].Value.ToString();

                }
            }
        }

        private void copyAllButton_Click(object sender, EventArgs e)
        {
            pasteDataGridView.Rows.Clear();
            for (int i = 0; i < copyDataGridView.Rows.Count; i++)
            {
                copyDataGridView.Rows[i].Cells[0].Value = true;

            }
            copyData();

        
        }


        private int rowIndex = 0;

        private void copyDataGridView_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.copyDataGridView.Rows[e.RowIndex].Selected = true;
                this.rowIndex = e.RowIndex;
                this.copyDataGridView.CurrentCell = this.copyDataGridView.Rows[e.RowIndex].Cells[1];
                this.contextMenuStrip1.Show(this.copyDataGridView, e.Location);
                contextMenuStrip1.Show(Cursor.Position);
            }
        }

        private void contextMenuStrip1_Click(object sender, EventArgs e)
        {
            if (!this.copyDataGridView.Rows[this.rowIndex].IsNewRow)
            {
                this.copyDataGridView.Rows.RemoveAt(this.rowIndex);
            }
        }

        private void deleteRowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!this.copyDataGridView.Rows[this.rowIndex].IsNewRow)
            {
                this.copyDataGridView.Rows.RemoveAt(this.rowIndex);
            }
        }


        private void copyAlltoClipboard()
        {
            excelDataGridView.SelectAll();
            DataObject dataObj = excelDataGridView.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }

        private void exportButton_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog path = new OpenFileDialog()
            {
                Title = "Browse Excel File",
                CheckFileExists = true,
                CheckPathExists = true,
                Filter = "txt files (*.xlsx)|*.xlsx",
                FilterIndex = 2,
                RestoreDirectory = true,
                ReadOnlyChecked = true,
                ShowReadOnly = true

            };

            if (path.ShowDialog() == DialogResult.OK)
            {
                excelTextBox.Text = path.FileName;
            }

        }


    }
}
