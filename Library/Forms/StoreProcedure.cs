using Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms.Forms
{
    public partial class StoreProcedure : Form
    {
        public StoreProcedure()
        {
            InitializeComponent();
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            ////1st way to insert data with storeProcedure
            //SqlConnect data = new SqlConnect();
            //data.Open();
            //SqlCommand cmd = new SqlCommand("Insert Into CategoryTbl Values (@CatName, @CatDesc, @Date)", data.con);
            //cmd.Parameters.AddWithValue("@CatName", textBox2.Text);
            //cmd.Parameters.AddWithValue("@CatDesc", textBox3.Text);
            //cmd.Parameters.AddWithValue("@Date", dateTimePicker1.Value.ToString());
            //cmd.ExecuteNonQuery();


            ////2nd way to insert data with storeProcedure
            //SqlConnect data = new SqlConnect();
            //data.Open();
            //SqlCommand cmd = new SqlCommand("exec SP_CategoryTbl_Insert '" + textBox2.Text + "','" + textBox3.Text + "','" + dateTimePicker1.Value.ToString() + "'", data.con);
            //cmd.Parameters.AddWithValue("@CatName", textBox2.Text);
            //cmd.Parameters.AddWithValue("@CatDesc", textBox3.Text);
            //cmd.Parameters.AddWithValue("@Date", dateTimePicker1.Value.ToString());
            //cmd.ExecuteNonQuery();

        }

    }
}
