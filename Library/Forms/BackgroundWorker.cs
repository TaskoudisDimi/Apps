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
            try
            {
                List<int> records = new List<int>();
                records.Add(1);
                records.Add(2);
                

                for (int i = 0; i < records.Count; i++)
                {
                    loaddata.retrieveData($"Select * From ProductTbl where ProdId = {records[i]}");

                }
                dataGridView.DataSource = loaddata.table;
            }
            catch (Exception ex)
            {
                progress.Text = "Error";
            }
        }

        private void backgroundWorker__RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            
            try
            {
                dataGridView.DataSource = loaddata.table;
                if (dataGridView.Rows.Count == 1)
                {
                    progress.Text = "Completed";
                }

            }
            catch (Exception ex)
            {
                progressBar1.Visible = true;
                progress.Text = "Error";
            }
        }

        private void backgroundWorker__ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

            progressBar1.Value = e.ProgressPercentage;

        }
    }
}









