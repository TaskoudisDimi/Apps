using ClosedXML.Excel;
using Lesson1.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;
using System.Text.RegularExpressions;
using Excel = Microsoft.Office.Interop.Excel;


//using Excel = Microsoft.Office.Interop.Excel;

namespace Library
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();

            SqlConnector loaddata = new SqlConnector();
            loaddata.retrieveData("Select * From [smarketdb].[dbo].[CategoryTbl]");

            exportDataGridView.DataSource = loaddata.table;



        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            //saveFileDialog.InitialDirectory = "C:";
            //saveFileDialog.Filter = "Excel File|*xlsx";
            //if (saveFileDialog.ShowDialog() == DialogResult.OK)
            //{
            //    Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            //    ExcelApp.Application.Workbooks.Add(Type.Missing);
            //    ExcelApp.Columns.ColumnWidth = 20;

            //    for (int i = 1; i < exportDataGridView.Columns.Count; i++)
            //    {
            //        ExcelApp.Cells[1, i] = exportDataGridView.Columns[i - 1].HeaderText;

            //    }

            //    for (int i = 0; i < exportDataGridView.Columns.Count; i++)
            //    {
            //        for(int j = 0; j < exportDataGridView.Columns.Count; j++)
            //        {
            //            ExcelApp.Cells[i + 2, j + 1] = exportDataGridView.Rows[i].Cells[j].Value.ToString();
            //        }
            //    }

            //    ExcelApp.ActiveWorkbook.SaveCopyAs(saveFileDialog.FileName.ToString());
            //    ExcelApp.ActiveWorkbook.Saved = true;
            //    ExcelApp.Quit();



            //}
        }


    }

}
