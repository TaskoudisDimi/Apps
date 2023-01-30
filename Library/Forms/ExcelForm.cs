using OfficeOpenXml.Style;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library;
using ClassLibrary;
using Forms.Forms;

namespace Forms
{
    public partial class ExcelForm : Form
    {
        public ExcelForm()
        {
            InitializeComponent();
        }
        SqlConnect loaddata = new SqlConnect();
        List<Products> productsOut = new List<Products>();
        private void ExcelForm_Load(object sender, EventArgs e)
        {
            

        }


        //xlsx
        private async void getButton_Click(object sender, EventArgs e)
        {
            string path = null;
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            OpenFileDialog dialog = new OpenFileDialog()
            {
                Filter = "xlsx (*.xlsx)|*.xlsx",
                Title = "xlsx Files",
                RestoreDirectory = true
            };
            if(dialog.ShowDialog() == DialogResult.OK)
            {

                path = dialog.FileName;

            }
            var file = new FileInfo(path);
            List<Products> productsFromExcel = await LoadExcelFile(file);
            dataGridView.DataSource = productsFromExcel;
        }
        private async void saveExcelButton_Click(object sender, EventArgs e)
        {
            string path = null;
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            SaveFileDialog dialog = new SaveFileDialog()
            {
                Filter = "xlsx (*.xlsx)|*.xlsx",
                Title = "xlsx Files",
                RestoreDirectory = true
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                path = dialog.FileName;
                
            }
            var file = new FileInfo(path);
            var products = GetSetupDataProd();
            await SaveExcelFile(products, file);
        }

        private List<Products> GetSetupDataProd()
        {
            
            for (int i = 0; i < loaddata.table.Rows.Count; i++)
            {
                Products prod = new Products();
                prod.ProdId = Convert.ToInt32(loaddata.table.Rows[i]["ProdId"]);
                prod.ProdCat = loaddata.table.Rows[i]["ProdCat"].ToString();
                prod.ProdName = loaddata.table.Rows[i]["ProdName"].ToString();
                prod.ProdPrice = Convert.ToInt32(loaddata.table.Rows[i]["ProdPrice"]);
                prod.ProdQty = Convert.ToInt32(loaddata.table.Rows[i]["ProdQty"]);
                prod.ProdCatID = Convert.ToInt32(loaddata.table.Rows[i]["ProdCatID"]);
                prod.ProdDate = (loaddata.table.Rows[i]["Date"]).ToString();
                productsOut.Add(prod);
            }
            return productsOut;
        }

        private static async Task<List<Products>> LoadExcelFile(FileInfo file)
        {
            List<Products> outputProd = new();
            using var package = new ExcelPackage(file);

            await package.LoadAsync(file);

            var ws = package.Workbook.Worksheets[0];

            int row = 5;
            int col = 1;

            while (string.IsNullOrWhiteSpace(ws.Cells[row, col].Value?.ToString()) == false)
            {
                //PersonModel p = new();
                Products p = new();
                p.ProdId = int.Parse(ws.Cells[row, col].Value.ToString());
                p.ProdName = ws.Cells[row, col + 1].Value.ToString();
                p.ProdQty = int.Parse(ws.Cells[row, col + 2].Value.ToString());
                p.ProdPrice = int.Parse(ws.Cells[row, col + 3].Value.ToString());
                p.ProdCatID = int.Parse(ws.Cells[row, col + 4].Value.ToString());
                p.ProdCat = ws.Cells[row, col + 5].Value.ToString();
                p.ProdDate = ws.Cells[row, col + 6].Value.ToString();

                outputProd.Add(p);
                row += 1;
            }

            return outputProd;
        }

        private static async Task SaveExcelFile(List<Products> products, FileInfo file)
        {
            DeleteIfExists(file);
            using var package = new ExcelPackage(file);

            var ws = package.Workbook.Worksheets.Add("MainReport");

            var range = ws.Cells["A4"].LoadFromCollection(products, true);
            range.AutoFitColumns();

            // Formats the header
            ws.Cells["A1"].Value = "Report Products";
            ws.Cells["A1:C1"].Merge = true;
            ws.Column(1).Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
            ws.Row(1).Style.Font.Size = 24;
            ws.Row(1).Style.Border.BorderAround(ExcelBorderStyle.Dashed);
            ws.Row(1).Style.Font.Color.SetColor(Color.Black);
            ws.Row(1).Style.Font.Bold = true;

            ws.Row(2).Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
            ws.Row(2).Style.Font.Bold = true;
            ws.Column(3).Width = 20;

            await package.SaveAsync();
        }

        private static void DeleteIfExists(FileInfo file)
        {
            if (file.Exists)
            {
                file.Delete();
            }
        }

       



        //Csv
        private void csvButton_Click(object sender, EventArgs e)
        {
            if (dataGridView.Rows.Count > 0)
            {
                SaveFileDialog dialog = new SaveFileDialog()
                {
                    Filter = "CSV (*.csv)|*.csv",
                    Title = "Csv Files",
                    RestoreDirectory = true
                };
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(dialog.FileName))
                    {
                        try
                        {
                            File.Delete(dialog.FileName);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        }
                    }
                    else
                    {
                        try
                        {
                            int colCount = dataGridView.Columns.Count;
                            string colNames = string.Empty;
                            string[] outputCSV = new string[dataGridView.Rows.Count + 1];
                            for (int i = 0; i < colCount; i++)
                            {
                                if (i == colCount - 1)
                                {
                                    colNames += dataGridView.Columns[i].HeaderText.ToString();
                                }
                                else
                                {
                                    colNames += dataGridView.Columns[i].HeaderText.ToString() + ",";
                                }
                            }
                            outputCSV[0] += colNames;

                            for (int i = 1; (i - 1) < dataGridView.Rows.Count; i++)
                            {
                                for (int j = 0; j < colCount; j++)
                                {
                                    outputCSV[i] += dataGridView.Rows[i - 1].Cells[j].Value.ToString() + ",";
                                }
                            }
                            File.WriteAllLines(dialog.FileName, outputCSV, Encoding.UTF8);
                            MessageBox.Show("Success");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
        }

        private void getCsvButton_Click(object sender, EventArgs e)
        {
            try
            {
                int ImportedRecord = 0, inValidItem = 0;
                string SourceURl = "";
                OpenFileDialog dialog = new OpenFileDialog()
                {
                    Title = "Browse csv File",
                    CheckFileExists = true,
                    CheckPathExists = true,
                    Filter = "xlsx files (*.xlsx)|*.xlsx",
                    FilterIndex = 2,
                    RestoreDirectory = true,
                    ReadOnlyChecked = true,
                    ShowReadOnly = true

                };
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    if (dialog.FileName.EndsWith(".xlsx"))
                    {
                        DataTable table = new DataTable();
                        table = GetData(dialog.FileName);
                        SourceURl = dialog.FileName;
                        if (table.Rows != null && table.Rows.ToString() != String.Empty)
                        {
                            dataGridView.DataSource = table;
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
            DataTable dt = new DataTable();
            try
            {
                if (path.EndsWith(".csv"))
                {
                    //TextFieldParser csvReader = new TextFieldParser(path);
                    //csvReader.SetDelimiters(new string[] { "," });
                    //csvReader.HasFieldsEnclosedInQuotes = true;
                    //string[] colFields = csvReader.ReadFields();

                    string[] lines = System.IO.File.ReadAllLines(path);
                    if (lines.Length > 0)
                    {
                        //first line to create header
                        string firstLine = lines[0];
                        //Devide each data of column
                        string[] headerLabels = firstLine.Split(',');
                        foreach (string headerWord in headerLabels)
                        {
                            //add data column
                            dt.Columns.Add(new DataColumn(headerWord));
                        }
                        //For Data
                        for (int i = 1; i < lines.Length; i++)
                        {
                            //devide each data of rows
                            string[] dataWords = lines[i].Split(',');
                            //create new row of DataTable
                            DataRow dr = dt.NewRow();
                            int columnIndex = 0;
                            foreach (string headerWord in headerLabels)
                            {
                                //Corresponde each Column name with coresponding Row
                                dr[headerWord] = dataWords[columnIndex++];
                            }
                            //Add all rows to DataTable
                            dt.Rows.Add(dr);
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception " + ex);
            }
            return dt;
        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            loaddata.retrieveData("Select * From ProductTbl");
            dataGridView.DataSource = loaddata.table;
        }

        private void test()
        {
            for(int i = 0; i < 100; i++)
            {
                Thread.Sleep(100);
            }
        }


        private void testButton_Click(object sender, EventArgs e)
        {
            using (ProgressWait wait = new ProgressWait(test))
            {
                wait.ShowDialog(this);
            }
        }
    }


    public class Products
    {
        public int ProdId { get; set; }
        public string ProdName { get; set; }
        public int ProdQty { get; set; }

        public int ProdPrice { get; set; }
        public int ProdCatID { get; set; }
        public string ProdCat { get; set; }
        public string ProdDate { get; set; }


    }



}
