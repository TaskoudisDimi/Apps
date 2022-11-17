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

namespace Library
{
    public partial class Form3 : Form
    {

        private int rowintex = 0;

        public static string constring = ConfigurationManager.ConnectionStrings["Tutorial"].ConnectionString;
        //SqlConnect con = new SqlConnection(constring);

        public Form3()
        {
            InitializeComponent();


            SqlConnector loadData = new SqlConnector();
            loadData.retrieveData("Select * From [smarketdb].[dbo].[CategoryTbl]");
            readOnlyDataGridView.DataSource = loadData.table;




            //foreach (DataGridViewRow row in readOnlyDataGridView.Rows)
            //{
            //    row.ReadOnly = true;
            //}


            //Chasnge column header
            //readOnlyDataGridView.Columns["CatId"].DisplayIndex = 2;



        }

        private void sqlButton_Click(object sender, EventArgs e)
        {
            //string query = sqlTextBox.Text;
            //SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            //DataSet ds = new DataSet();
            //adapter.Fill(ds);
            //if (ds.Tables[0].Rows.Count != 0)
            //{
            //    sqlDataGridView.DataSource = ds.Tables[0];

            //}
        }

        //Prevent from dublicate values on datagridview
        private void readOnlyDataGridView_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && readOnlyDataGridView.CurrentCell.Value != null)
            {
                foreach (DataGridViewRow row in readOnlyDataGridView.Rows)
                {
                    if (row.Index == this.readOnlyDataGridView.CurrentCell.RowIndex)
                    {
                        continue;

                    }
                    if (this.readOnlyDataGridView.CurrentCell.Value == null)
                    {
                        continue;
                    }
                    if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == readOnlyDataGridView.CurrentCell.Value.ToString())
                    {
                        MessageBox.Show("Exists!");
                        readOnlyDataGridView.CurrentCell.Value = null;

                    }
                }
            }
        }


        //private void SelectedRow()
        //{
        //    double sum = 0;
        //    for (int i = 0; i < this.readOnlyDataGridView.Rows.Count; i++)
        //    {
        //        if (Convert.ToBoolean(readOnlyDataGridView.Rows[i].Cells[0].Value) == true)
        //        {
        //            sum += double.Parse(readOnlyDataGridView.Rows[i].Cells[2].Value.ToString());
        //        }
        //    }

        //    sumTextBox.Text = sum.ToString();

        //}

        //private void sumButton_Click(object sender, EventArgs e)
        //{
        //    SelectedRow();
        //}

        private void readOnlyDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            sumButton.PerformClick();

        }
    }
}
