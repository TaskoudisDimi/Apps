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
using Lesson1.DataAccess;


namespace Library
{
    public partial class Form4 : Form
    {
        public static string constring = ConfigurationManager.ConnectionStrings["Tutorial"].ConnectionString;
        SqlConnection con = new SqlConnection(constring);
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


            SqlDataAdapter adapter = new SqlDataAdapter("Select * From [smarketdb].[dbo].[CategoryTbl]", con);
            DataTable tbl = new DataTable();
            adapter.Fill(tbl);
            copyDataGridView.Rows.Clear();


            foreach (DataRow item in tbl.Rows)
            {
                int n = copyDataGridView.Rows.Add();
                copyDataGridView.Rows[n].Cells[1].Value = item["Catid"].ToString();
                copyDataGridView.Rows[n].Cells[2].Value = item["CatName"].ToString();
                copyDataGridView.Rows[n].Cells[3].Value = item["CatDesc"].ToString();

            }







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
                Filter = "txt files (*.xlsx)|*.xlsx",
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

    }
}
