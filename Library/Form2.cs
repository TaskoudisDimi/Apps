using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lesson1.DataAccess;
using Lesson1;
using System.Data.SqlClient;
using System.Configuration;



namespace Library
{
    public partial class Form2 : Form
    {

        public static string constring = ConfigurationManager.ConnectionStrings["Tutorial"].ConnectionString;
        SqlConnection con = new SqlConnection(constring);
        public Form2()
        {
            InitializeComponent();


            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("Select * From [smarketdb].[dbo].[CategoryTbl]", con);
            DataTable tbl = new DataTable();
            adapter.Fill(tbl);
            bindDataGridView.DataSource = tbl;

            con.Close();



        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (int i in method1DataGridView.Rows)
            {
                string query = "";
                con.Open();
                
                
                con.Close();


                
            }
            
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            con.Open();
            MessageBox.Show("Success!");
            con.Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            using(SqlConnection con = new SqlConnection(constring))
            {
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("Select * From [smarketdb].[dbo].[CategoryTbl]", con);
                DataTable tbl = new DataTable();
                adapter.Fill(tbl);

                method1DataGridView.DataSource = tbl;

                method2DataGridView.DataSource = tbl;



            }

        }
    }
}
