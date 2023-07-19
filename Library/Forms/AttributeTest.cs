using ClassLibrary;
using Forms.Models;
using Lesson1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Timer = System.Windows.Forms.Timer;

namespace Forms.Forms
{
    public partial class AttributeTest : Form
    {

        private BackgroundWorker backgroundWorker;

        public AttributeTest()
        {
            InitializeComponent();

            backgroundWorker = new BackgroundWorker();
            backgroundWorker.WorkerReportsProgress = true;
            backgroundWorker.DoWork += BackgroundWorker_DoWork;
            backgroundWorker.ProgressChanged += BackgroundWorker_ProgressChanged;
            backgroundWorker.RunWorkerCompleted += BackgroundWorker_RunWorkerCompleted;

        }
        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            // Simulate a time-consuming operation (5 seconds)
            Thread.Sleep(5000);
        }

        private void BackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // This event is not used in this example, but it's required for the BackgroundWorker to report progress.
        }

        private void BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            labelTest.Text = "End of downloading";
            progressBar1.Style = ProgressBarStyle.Blocks;
            
        }
        public void testTask()
        {
            Thread.Sleep(1000);
            

        }
        private void AttributeTest_Load(object sender, EventArgs e)
        {

        }
        private async void button1_Click(object sender, EventArgs e)
        {

            //await Task.Run(() =>
            //{
            //    testTask();
            //});

            
            labelTest.Text = "Processing...";
            progressBar1.Style = ProgressBarStyle.Marquee;

            // Start the background worker
            backgroundWorker.RunWorkerAsync();


            //List<Category> categories = ReadFromSqlTable<Category>();
            //foreach (Category categorie in categories)
            //{
            //    Console.WriteLine(categorie.CatId);
            //}

        }
        public static List<T> ReadFromSqlTable<T>() where T : new()
        {
            List<T> result = new List<T>();

            Type type = typeof(T);
            SqlTableAttribute tableAttribute = (SqlTableAttribute)type.GetCustomAttributes(typeof(SqlTableAttribute), false).FirstOrDefault();
            if (tableAttribute == null)
            {
                throw new Exception("SqlTableAttribute not found on class " + type.Name);
            }

            string tableName = tableAttribute.TableName;
            string connectionString = ConfigurationManager.ConnectionStrings["Supermarket"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = "SELECT * FROM " + tableName;
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        T item = new T();
                        foreach (PropertyInfo property in type.GetProperties())
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal(property.Name)))
                            {
                                property.SetValue(item, reader.GetValue(reader.GetOrdinal(property.Name)));
                            }
                        }
                        result.Add(item);
                    }
                    reader.Close();
                }
            }

            return result;
        }

    }
}
