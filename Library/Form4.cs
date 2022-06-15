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
using System.Data.OleDb;

namespace Library
{
    public partial class Form4 : Form
    {
        //public static string constring = ConfigurationManager.ConnectionStrings["Tutorial"].ConnectionString;
        //SqlConnection con = new SqlConnection(constring);
        SqlConnector loaddata = new SqlConnector();
        
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




        private void exportButton_Click(object sender, EventArgs e)
        {
            //// creating Excel Application  
            //Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            //// creating new WorkBook within Excel application  
            //Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            //// creating new Excelsheet in workbook  
            //Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            //// see the excel sheet behind the program  
            //app.Visible = true;
            //// get the reference of first sheet. By default its name is Sheet1.  
            //// store its reference to worksheet  
            //worksheet = workbook.Sheets["Sheet1"];
            //worksheet = workbook.ActiveSheet;
            //// changing the name of active sheet  
            //worksheet.Name = "Exported from gridview";
            //// storing header part in Excel  
            //for (int i = 1; i < excelDataGridView.Columns.Count + 1; i++)
            //{
            //    worksheet.Cells[1, i] = excelDataGridView.Columns[i - 1].HeaderText;
            //}
            //// storing Each row and column value to excel sheet  
            //for (int i = 0; i < excelDataGridView.Rows.Count - 1; i++)
            //{
            //    for (int j = 0; j < excelDataGridView.Columns.Count; j++)
            //    {
            //        worksheet.Cells[i + 2, j + 1] = excelDataGridView.Rows[i].Cells[j].Value.ToString();
            //    }
            //}
            //// save the application  
            //workbook.SaveAs("c:\\output.xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            //// Exit from the application  
            //app.Quit();
        }

        private void exportButton_Click_1(object sender, EventArgs e)
        {
            //// creating Excel Application  
            //Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            //// creating new WorkBook within Excel application  
            //Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            //// creating new Excelsheet in workbook  
            //Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            //// see the excel sheet behind the program  
            //app.Visible = true;
            //// get the reference of first sheet. By default its name is Sheet1.  
            //// store its reference to worksheet  
            //worksheet = workbook.Sheets["Sheet1"];
            //worksheet = workbook.ActiveSheet;
            //// changing the name of active sheet  
            //worksheet.Name = "Exported from gridview";
            //// storing header part in Excel  
            //for (int i = 1; i < excelDataGridView.Columns.Count + 1; i++)
            //{
            //    worksheet.Cells[1, i] = excelDataGridView.Columns[i - 1].HeaderText;
            //}
            //// storing Each row and column value to excel sheet  
            //for (int i = 0; i < excelDataGridView.Rows.Count - 1; i++)
            //{
            //    for (int j = 0; j < excelDataGridView.Columns.Count; j++)
            //    {
            //        worksheet.Cells[i + 2, j + 1] = excelDataGridView.Rows[i].Cells[j].Value.ToString();
            //    }
            //}
            //// save the application  
            //workbook.SaveAs("c:\\output_new.xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            //// Exit from the application  
            //app.Quit();
        }



        //Failed to import excel
        //private void excelButton_Click(object sender, EventArgs e)
        //{
        //    OpenFileDialog excel = new OpenFileDialog();
        //    excel.Title = "Excel Files";
        //    excel.FileName = excelTextBox.Text;
        //    excel.Filter = "Excel Sheet (*.xls)|*.xls|All Files(*.*)|*.*";
        //    excel.FilterIndex = 1;
        //    excel.RestoreDirectory = true;
        //    if (excel.ShowDialog() == DialogResult.OK)
        //    {
        //        excelTextBox.Text = excel.FileName;
        //    }
        //}

        //private void importButton_Click(object sender, EventArgs e)
        //{
        //    string pathCon = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source = '" + excelTextBox.Text + "';Extended Properites=\"Excel 8.0;HDR = NO;IMEX=1\";";
        //    OleDbConnection con = new OleDbConnection(pathCon);

        //    //OleDbDataAdapter adapter = new OleDbDataAdapter("Select * From [" + excelTextBox.Text + "$]", con);
        //    OleDbDataAdapter adapter = new OleDbDataAdapter("Select * From[Sheet1$]", con);
        //    DataTable table = new DataTable();

        //    adapter.Fill(table);

        //    excelDataGridView.DataSource = table;

        //}
    }
}
