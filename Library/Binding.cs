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
    public partial class Binding : Form
    {
        public Binding()
        {
            InitializeComponent();
        }

        private void Binding_Load_1(object sender, EventArgs e)
        {
            //SqlConnect connect = new SqlConnect();
            //connect.retrieveData("Select * From ProductTbl");
            //dataGridView.DataSource = connect.table;
            DateTime test = DateTime.Now;

            productsBindingSource.Add(new Category() { CatId = 1, CatName = "Test1", CatDesc = "Test2", Date =  test});

        }
    }
}
