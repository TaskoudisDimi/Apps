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
    public partial class Connect : Form
    {
        BackgroundWorker backgroundWorker = new BackgroundWorker();
        public Connect()
        {
            InitializeComponent();
            
        }

        private void backButton_Click(object sender, EventArgs e)
        {

        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            List<int> records = new List<int>();
            records.Add(1);
            records.Add(2);
            SqlConnect loaddata = new SqlConnect();

            for (int i = 0; i < records.Count; i++)
            {
                loaddata.retrieveData($"Select * From ProductTbl where ProdId = {records[i]}");
                
            }
            dataGridView.DataSource = loaddata.table;
        }
    }
}









