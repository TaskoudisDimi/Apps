using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using Lesson1.DataAccess;
using PageList;
using Lesson1.Data;

namespace Library
{
    public partial class Form5 : Form
    {


        public Form5()
        {
            InitializeComponent();


            
        }

        public void nextButton_Click(object sender, EventArgs e)
        {



        }

        private void Form5_Load(object sender, EventArgs e)
        {
            //SqlDataAdapter adapter = new SqlDataAdapter("Select * From [smarketdb].[dbo].[CategoryTbl]", con);
            //DataTable tbl = new DataTable();
            //adapter.Fill(tbl);
            //pagingDataGridView.DataSource = tbl;
        }



    }


}
