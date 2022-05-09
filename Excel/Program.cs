using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using OfficeOpenXml;



namespace Excel
{
    partial class Program
    {
        static async Task Main(string[] args)
        {
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            var file = new FileInfo(@"C:\Users\User\Desktop\troll\Test.xlsx");

            var people = GetSetupData();

            await SaveExcelFile(people, file);
        } 





        private static async Task SaveExcelFile(List<PersonModel> people, FileInfo file)
        {
            using var package = new ExcelPackage(file);
            
            DeleteIfExists(file);

            var ws = package.Workbook.Worksheets.Add("MainReport");

            var range = ws.Cells["A1"].LoadFromCollection(people, true);

            range.AutoFitColumns();

            await package.SaveAsync();
        }

        private static void DeleteIfExists(FileInfo file)
        {
            if (file.Exists)
            {
                file.Delete();
            }

        }

        static List<PersonModel> GetSetupData()
        {
            List<PersonModel> output = new()
            {
                new() { Id = 1, FirstName = "Dimitris", LastName = "Taskoudis" },
                new() { Id = 2, FirstName = "Teo", LastName = "Savvidis" },
                new() { Id = 3, FirstName = "Katerina", LastName = "Lioliou" }
            };
            return output;
        }
    }
}