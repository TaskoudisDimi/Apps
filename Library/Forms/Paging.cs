using Library;
using Microsoft.Data.SqlClient;
using PagedList;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Forms.Forms
{
    public partial class Paging : Form
    {
        int startRecord;
        int allRecords;
        SqlConnect loaddata = new SqlConnect();
        public Paging()
        {
            InitializeComponent();
            startRecord = 0;
            
        }

        private void Paging_Load(object sender, EventArgs e)
        {
            List<string> comboPaging = new List<string>();
            comboPaging.Add("5");
            comboPaging.Add("10");
            comboPaging.Add("20");
            comboPaging.Add("All");
            comboBox.DataSource = comboPaging;
            pageLabel.Text = $"{dataGridView.Rows.Count / Convert.ToInt32(comboBox.SelectedItem)}";
        }

        private void prevButton_Click(object sender, EventArgs e)
        {
            startRecord = startRecord - 5;
            if (startRecord <= 0)
            {
                startRecord = 0;
            }
            loaddata.pagingData("Select * From ProductTbl", startRecord, Convert.ToInt32(comboBox.SelectedItem));
            dataGridView.DataSource = loaddata.table;
            if (dataGridView.Rows.Count > 1)
            {
                nextButton.Enabled = true;
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (dataGridView.Rows.Count > 1)
            {
                startRecord = startRecord + 5;
                if (startRecord <= 0)
                {
                    startRecord = 10;
                }
                loaddata.pagingData("Select * From ProductTbl", startRecord, Convert.ToInt32(comboBox.SelectedItem));
                dataGridView.DataSource = loaddata.table;
            }
            else
            {
                nextButton.Enabled = false;
            }
        }

        private void allButton_Click(object sender, EventArgs e)
        {

            loaddata.retrieveData("Select * From ProductTbl");
            dataGridView.DataSource = loaddata.table;
            allRecords = loaddata.table.Rows.Count;
            pageLabel.Text = "1 / " + $"{dataGridView.Rows.Count / Convert.ToInt32(comboBox.SelectedItem) + 1}" + " ";

        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox.SelectedItem == "5")
            {
                loaddata.pagingData("Select * From ProductTbl", 0, 5);
            }
            else if(comboBox.SelectedItem == "10")
            {
                loaddata.pagingData("Select * From ProductTbl", 0, 10);
            }
            else if (comboBox.SelectedItem == "20")
            {
                loaddata.pagingData("Select * From ProductTbl", 0, 20);
            }
            else if (comboBox.SelectedItem == "All")
            {
                loaddata.pagingData("Select * From ProductTbl", 0, allRecords);
            }
        }
    }

}
