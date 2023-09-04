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
        private ProgressWait progressForm;


        public AttributeTest()
        {
            InitializeComponent();

            backgroundWorker = new BackgroundWorker();
            backgroundWorker.WorkerReportsProgress = true;
            backgroundWorker.DoWork += BackgroundWorker_DoWork;
            backgroundWorker.ProgressChanged += BackgroundWorker_ProgressChanged;
            backgroundWorker.RunWorkerCompleted += BackgroundWorker_RunWorkerCompleted;

            progressForm = new ProgressWait();

        }


        private void button1_Click(object sender, EventArgs e)
        {
            labelTest.Text = "Processing...";
            //progressBar1.Style = ProgressBarStyle.Marquee;

            // Start the background worker
            backgroundWorker.RunWorkerAsync();

            // Show the progress form
            progressForm.Show();
        }

        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            // Simulate a time-consuming operation (5 seconds)
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(50); // Simulate work
                backgroundWorker.ReportProgress(i); // Report progress
            }
        }

        private void BackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // Update the progress bar in the progress form
            progressForm.UpdateProgressBar(e.ProgressPercentage);
        }

        private void BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            labelTest.Text = "End of downloading";

            // Close the progress form when the background work is done
            progressForm.Close();
        }

        private void AttributeTest_Load(object sender, EventArgs e)
        {
            backgroundWorker.RunWorkerAsync();
            progressForm.Show();
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
