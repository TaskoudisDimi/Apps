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
        int scr_val;
        SqlConnect loaddata = new SqlConnect();
        public Paging()
        {
            InitializeComponent();
            scr_val = 0;
        }

        private void Paging_Load(object sender, EventArgs e)
        {

        }

        private void prevButton_Click(object sender, EventArgs e)
        {
            scr_val = scr_val - 5;
            if (scr_val <= 0)
            {
                scr_val = 0;
            }
            loaddata.pagingData("Select * From ProductTbl", scr_val, 5);
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
                scr_val = scr_val + 5;
                if (scr_val <= 0)
                {
                    scr_val = 10;
                }
                loaddata.pagingData("Select * From ProductTbl", scr_val, 5);
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
        }
    }

}
