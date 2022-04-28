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
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (int i in dataGridView1.Rows)
            {
                string query = "";

                
            }
            
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            con.Open();
            MessageBox.Show("Success!");
            con.Close();
        }
    }
}
