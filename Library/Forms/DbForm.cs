using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class DbForm : Form
    {
        public DbForm()
        {
            InitializeComponent();
        }

        private void DbForm_Load(object sender, EventArgs e)
        {
            //SqlConnect loaddata = new SqlConnect();
            //loaddata.retrieveData("Select * From ProductTbl");
            //dataGridView1.DataSource = loaddata.table;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //string connectionString = string.Format("server={0};database={1};Persist Security Info = True; User ID = {2}; Password = {3};", textBox3.Text);
            //SqlConnect loaddata2 = new SqlConnect(connectionString);
            //loaddata2.GetDatabases();
            //comboBox1.DisplayMember = "name";
            //comboBox1.DataSource = loaddata2.table;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            //string connectionString = string.Format("server={0};database=Ambulate;Integrated Security=SSPI;", textBox3.Text);
            //SqlConnect loaddata2 = new SqlConnect(connectionString);
            //loaddata2.GetDatabases();
            //comboBox1.DisplayMember = "name";
            //comboBox1.DataSource = loaddata2.table;
        }
    }
}
