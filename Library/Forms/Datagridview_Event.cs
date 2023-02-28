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
    public partial class Datagridview_Event : Form
    {

        private int rowintex = 0;
        SqlConnect loadData = new SqlConnect();

        public Datagridview_Event()
        {
            InitializeComponent();
            loadData.retrieveData("Select * From [smarketdb].[dbo].[CategoryTbl]");
            readOnlyDataGridView.DataSource = loadData.table;


        }

        private void sqlButton_Click(object sender, EventArgs e)
        {
            
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



        private void readOnlyDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            sumButton.PerformClick();

        }
    }
}
