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



namespace Library
{
    public partial class Form2 : Form
    {
        SqlConnector sql = new SqlConnector();
        public Form2()
        {
            InitializeComponent();
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void connectButton_Click(object sender, EventArgs e)
        {
           
        }

        private void addButton_Click(object sender, EventArgs e)
        {

        }
    }
}
