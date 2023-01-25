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

namespace Forms
{
    public partial class ExcelForm : Form
    {
        public ExcelForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = null;
            SaveFileDialog dialog = new SaveFileDialog()
            {
                Filter = "CSV (*.csv)|*.csv",
                Title = "Csv Files",
                RestoreDirectory = true
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                path = dialog.FileName;
                excel(path);
            }
        }

        private async void excel(string path)
        {
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            
            var file = new FileInfo(path);
            var people = GetSetupData();

            await SaveExcelFile(people, file);

            List<PersonModel> peopleFromExcel = await LoadExcelFile(file);

            foreach (var p in peopleFromExcel)
            {
                Console.WriteLine($"{p.Id} {p.FirstName} {p.LastName}");
            }
        }

        private static async Task<List<PersonModel>> LoadExcelFile(FileInfo file)
        {
            List<PersonModel> output = new();

            using var package = new ExcelPackage(file);

            await package.LoadAsync(file);

            var ws = package.Workbook.Worksheets[0];

            int row = 3;
            int col = 1;

            while (string.IsNullOrWhiteSpace(ws.Cells[row, col].Value?.ToString()) == false)
            {
                PersonModel p = new();
                p.Id = int.Parse(ws.Cells[row, col].Value.ToString());
                p.FirstName = ws.Cells[row, col + 1].Value.ToString();
                p.LastName = ws.Cells[row, col + 2].Value.ToString();
                output.Add(p);
                row += 1;
            }

            return output;
        }

        private static async Task SaveExcelFile(List<PersonModel> people, FileInfo file)
        {
            DeleteIfExists(file);

            using var package = new ExcelPackage(file);

            var ws = package.Workbook.Worksheets.Add("MainReport");

            var range = ws.Cells["A2"].LoadFromCollection(people, true);
            range.AutoFitColumns();

            // Formats the header
            ws.Cells["A1"].Value = "Our Cool Report";
            ws.Cells["A1:C1"].Merge = true;
            ws.Column(1).Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
            ws.Row(1).Style.Font.Size = 24;
            ws.Row(1).Style.Font.Color.SetColor(Color.Blue);
            ws.Cells["A20:C20"].Merge = true;
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

        private static List<PersonModel> GetSetupData()
        {
            List<PersonModel> output = new()
            {
                new() { Id = 1, FirstName = "Dimitris", LastName = "Taskoudis" },
                new() { Id = 2, FirstName = "Teo", LastName = "Savvidis" },
                new() { Id = 3, FirstName = "Despoina", LastName = "Taskoudi" }
            };

            return output;
        }

        private void getButton_Click(object sender, EventArgs e)
        {

        }
    }

    public class PersonModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
