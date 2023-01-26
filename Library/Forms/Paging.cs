using Library;
using PagedList;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        int pageNumber = 1;
        SqlConnect loaddata = new SqlConnect();
        public Paging()
        {
            InitializeComponent();
        }

        private void Paging_Load(object sender, EventArgs e)
        {
            loaddata.retrieveData($"Select * From ProductTbl");
            dataGridView.DataSource = loaddata.table;
        }

        private void prevButton_Click(object sender, EventArgs e)
        {

        }

        private void nextButton_Click(object sender, EventArgs e)
        {

        }
    }
   
}
