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


namespace Library
{
    public partial class Form3 : Form
    {


        public static string constring = ConfigurationManager.ConnectionStrings["Tutorial"].ConnectionString;
        SqlConnection con = new SqlConnection(constring);

        public Form3()
        {
            InitializeComponent();
            using (SqlConnection connection = new SqlConnection(constring))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("Select * From [smarketdb].[dbo].[CategoryTbl]", con);
                DataTable tbl = new DataTable();
                adapter.Fill(tbl);
                readOnlyDataGridView.DataSource = tbl;
                connection.Close();
            }

            //foreach (DataGridViewRow row in readOnlyDataGridView.Rows)
            //{
            //    row.ReadOnly = true;
            //}


            //Chasnge column header
            //readOnlyDataGridView.Columns["CatId"].DisplayIndex = 2;






        }

        private void sqlButton_Click(object sender, EventArgs e)
        {
            string query = sqlTextBox.Text;
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            if (ds.Tables[0].Rows.Count != 0)
            {
                sqlDataGridView.DataSource = ds.Tables[0];

            }
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
    }
}
