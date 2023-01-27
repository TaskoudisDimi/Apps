using DocumentFormat.OpenXml.Office.Word;
using Library;
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
    public partial class BackgroundWorker : Form
    {
        SqlConnect loaddata = new SqlConnect();
        public BackgroundWorker()
        {
            InitializeComponent();

        }


        private void connectButton_Click(object sender, EventArgs e)
        {
            //List<int> records = new List<int>();
            //records.Add(1);
            //records.Add(2);
            //SqlConnect loaddata = new SqlConnect();

            //for (int i = 0; i < records.Count; i++)
            //{
            //    loaddata.retrieveData($"Select * From ProductTbl where ProdId = {records[i]}");

            //}
            //dataGridView.DataSource = loaddata.table;

            if (!backgroundWorker_.IsBusy)
            {
                progressBar1.Visible = true;
                progress.Text = "Please wait...";
                //SnackBarTimer();
                backgroundWorker_.RunWorkerAsync();
            }

        }


        private void backgroundWorker__DoWork(object sender, DoWorkEventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            backgroundWorker_.WorkerReportsProgress = true;
            //List<int> records = new List<int>();
            //for (int j = 0; j < 100; j++)
            //{
            //    records.Add(j);
            //}
            
            loaddata.retrieveData($"Select * From ProductTbl");
            //backgroundWorker_.ReportProgress(100);
            dataGridView.DataSource = loaddata.table;
            //int sum = 0;
            //for (int i = 1; i <= 100; i++)
            //{
            //    sum = sum + i;
            //    //loaddata.retrieveData($"Select * From ProductTbl where ProdId = {records[i]}");
            //    backgroundWorker_.ReportProgress(i);
            //    // Check if the cancellation is requested
            //    if (backgroundWorker_.CancellationPending)
            //    {
            //        // Set Cancel property of DoWorkEventArgs object to true
            //        e.Cancel = true;
            //        // Reset progress percentage to ZERO and return
            //        backgroundWorker_.ReportProgress(0);
            //        return;
            //    }
            //}
            //e.Result = sum;

        }

        private void backgroundWorker__RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                progress.Text = "Processing Cancelled";

            }
            else if (e.Error != null)
            {
                progress.Text = e.Error.Message;

            }
            else
            {
                //progress.Text = e.Result.ToString();
                progress.Text = "Completed!";
            

            }
            
        }

        private void backgroundWorker__ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

            progressBar1.Value = e.ProgressPercentage;

        }
    }
}









