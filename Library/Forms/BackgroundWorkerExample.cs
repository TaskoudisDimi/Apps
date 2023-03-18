using DocumentFormat.OpenXml.Office.Word;
using Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Forms
{
    public partial class BackgroundWorkerExample : Form
    {
        private BackgroundWorker backgroundWorker = new BackgroundWorker();
        private readonly string connectionString = "Data Source=serverName;Initial Catalog=dbName;Integrated Security=True;";
        public Progress progressForm = new Progress();
        public BackgroundWorkerExample()
        {
            InitializeComponent();
            // Set up the background worker
            backgroundWorker.DoWork += BackgroundWorker_DoWork;
            backgroundWorker.ProgressChanged += BackgroundWorker_ProgressChanged;
            backgroundWorker.RunWorkerCompleted += BackgroundWorker_RunWorkerCompleted;
            backgroundWorker.WorkerReportsProgress = true;
            backgroundWorker.WorkerSupportsCancellation = true;
        }

        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            // Simulate a database query
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Supermarket"].ConnectionString))
            {
                SqlCommand command = new SqlCommand("SELECT * FROM ProductTbl", connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                int count = 0;
                while (reader.Read())
                {
                    // Report progress
                    backgroundWorker.ReportProgress(count, reader["ProdId"]);

                    // Check if the operation was cancelled
                    if (backgroundWorker.CancellationPending)
                    {
                        e.Cancel = true;
                        return;
                    }
                    count++;
                }
            }
        }
        private void BackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //// Update the UI with the current progress
            //progressBar1.Value = e.ProgressPercentage;
            listBoxResults.Items.Add($"Row {e.ProgressPercentage}: {e.UserState}");
        }

        private void BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // Update the UI when the background worker is complete
            if (e.Cancelled)
            {
                progress.Text = "Cancelled";
            }
            else if (e.Error != null)
            {
                progress.Text = $"Error: {e.Error.Message}";
            }
            else
            {
                progressForm.Close();
                progress.Text = "Completed";
            }
        }
        private void connectButton_Click(object sender, EventArgs e)
        {
            
            progressForm.Show();

            // Set progress bar style to Marquee
            progressForm.progressBar.Style = ProgressBarStyle.Marquee;

            if (!backgroundWorker.IsBusy)
            {
                // Start the background worker
                backgroundWorker.RunWorkerAsync();
            }

        }
    }
}









