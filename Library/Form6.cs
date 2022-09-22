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
//using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.VisualBasic.FileIO;


//using Excel = Microsoft.Office.Interop.Excel;

namespace Library
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();

            //SqlConnector loaddata = new SqlConnector();
            //loaddata.retrieveData("Select * From [smarketdb].[dbo].[CategoryTbl]");

            //DataGridView.DataSource = loaddata.table;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //SqlConnector loaddata2 = new SqlConnector();
            //loaddata2.retrieveData("Select * From CategoryTbl Where Date='" + dateTimePicker1.Text + "'" );
            //DataGridView.DataSource = loaddata2.table;
        }

        private void csvButton_Click(object sender, EventArgs e)
        {
            try
            {
                int ImportedRecord = 0, inValidItem = 0;
                string SourceURl = "";
                OpenFileDialog dialog = new OpenFileDialog()
                {
                    Title = "Browse Text File",
                    CheckFileExists = true,
                    CheckPathExists = true,
                    Filter = "txt files (*.csv)|*.csv",
                    FilterIndex = 2,
                    RestoreDirectory = true,
                    ReadOnlyChecked = true,
                    ShowReadOnly = true

                };
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    if (dialog.FileName.EndsWith(".csv"))
                    {
                        DataTable table = new DataTable();
                        table = GetData(dialog.FileName);
                        csvTextBox.Text = dialog.FileName;
                        SourceURl = dialog.FileName;
                        if (table.Rows != null && table.Rows.ToString() != String.Empty)
                        {
                            csvDataGridView.DataSource = table;

                        }

                    }
                }
            }


            catch (Exception ex)
            {
                MessageBox.Show("Exception" + ex);
            }


        }


        private DataTable GetData(string path)
        {
            DataTable table = new DataTable();
            try
            {
                if (path.EndsWith(".csv"))
                {
                    TextFieldParser csvReader = new TextFieldParser(path);
                    csvReader.SetDelimiters(new string[] { "," });
                    csvReader.HasFieldsEnclosedInQuotes = true;
                    string[] colFields = csvReader.ReadFields();
                    foreach (string column in colFields)
                    {
                        DataColumn datecolumn = new DataColumn(column);
                        datecolumn.AllowDBNull = true;
                        table.Columns.Add(datecolumn);
                    }
                    while (!csvReader.EndOfData)
                    {
                        string[] fieldData = csvReader.ReadFields();
                        for (int i = 0; i < fieldData.Length; i++)
                        {
                            if (fieldData[i] == "")
                            {
                                fieldData[i] = null;
                            }
                        }
                        table.Rows.Add(fieldData);
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception " + ex);
            }
            return table;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable item = (DataTable)(csvDataGridView.DataSource);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception" + ex);
            }
        }
    }


}


