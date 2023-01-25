using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Library
{
    public partial class BackgroundWorkerTest : Form
    {
        public BackgroundWorkerTest()
        {
            InitializeComponent();
        }

        //The BackgroundWorker class allows you to run an operation on a separate, dedicated thread
        //add an event handler for the DoWork event. Call your time-consuming operation in this event handler.
        //To start the operation, call RunWorkerAsync. To receive notifications of progress updates, handle the ProgressChanged event.
        //To receive a notification when the operation is completed, handle the RunWorkerCompleted event.


        //CancellationPending - Indicates if an application has requested cancellation of a BackgroundWorker.
        //IsBusy - Indicates if a BackgroundWorker is running an asynchronous operation.
        //WorkerReportsProgress - Indicates of a BackgroundWorker can report progress updates.
        //WorkerSupportsCancellation - Indicates if a BackgroundWorker supports asynchronous cancellation.


        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            int sum = 0;
            for (int i = 1; i <= 100; i++)
            {
                Thread.Sleep(100);
                sum = sum + i;
                // Calling ReportProgress() method raises ProgressChanged event
                // To this method pass the percentage of processing that is complete
                backgroundWorker1.ReportProgress(i);

                // Check if the cancellation is requested
                if (backgroundWorker1.CancellationPending)
                {
                    // Set Cancel property of DoWorkEventArgs object to true
                    e.Cancel = true;
                    // Reset progress percentage to ZERO and return
                    backgroundWorker1.ReportProgress(0);
                    return;
                }
            }

            // Store the result in Result property of DoWorkEventArgs object
            e.Result = sum;

        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            backgroundLabel.Text = e.ProgressPercentage.ToString() + "%";
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled){
                backgroundLabel.Text = "Processing Cancelled";

            }
            else if ( e.Error != null)
            {
                backgroundLabel.Text = e.Error.Message;

            }
            else
            {
                backgroundLabel.Text = e.Result.ToString();
            }
        }

        private void processButton_Click(object sender, EventArgs e)
        {
            if (!backgroundWorker1.IsBusy)
            {
                backgroundWorker1.RunWorkerAsync();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy)
            {
                backgroundWorker1.CancelAsync();
            }
        }
    }
}
