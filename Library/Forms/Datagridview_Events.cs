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
    public partial class Datagridview_Events : Form
    {
        
        public static string constring = ConfigurationManager.ConnectionStrings["Tutorial"].ConnectionString;
        //SqlConnect con = new SqlConnection(constring);
        public Datagridview_Events()
        {
            InitializeComponent();

            //Insert CheckBox
            DataGridViewCheckBoxColumn checkColumn = new DataGridViewCheckBoxColumn();
            checkColumn.Name = "Test checkBox";
            checkColumn.HeaderText = "Test checkBox";
            checkColumn.ReadOnly = false;
            method2DataGridView.Columns.Add(checkColumn);


            //Insert new Column
            DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
            column.Name = "Test";
            column.DataPropertyName = "Test";
            method2DataGridView.Columns.Add(column);

            method1DataGridView.Columns[0].Visible = false;

        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
   
        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            Progress frm = new Progress();

            BackgroundWorker bgw = new BackgroundWorker()
            {
                WorkerReportsProgress = true
            };

            bgw.DoWork += (s, e) =>
            {
                for (int i = 0; i < 10000; i++)
                {
                    ((BackgroundWorker)s).ReportProgress(i, "Test:" + i);
                    
                }
                
            };

            bgw.ProgressChanged += (s, e) =>
            {
                frm.SetProgress(e.ProgressPercentage, e.UserState.ToString());
            };

            bgw.RunWorkerCompleted += (s, e) =>
            {
                frm.Close();

                if (e.Error != null)
                    throw e.Error;
            };
            bgw.RunWorkerAsync();

            frm.ShowDialog();
        }
        


        private void addButton_Click(object sender, EventArgs e)
        {
            if (sender == addButton)
            {
                MessageBox.Show("Its not ready yet!");
            }


        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            //Method 1 to remove
            //int rowIndex = method1DataGridView.CurrentCell.RowIndex;
            //method1DataGridView.Rows.RemoveAt(rowIndex);


            //Method 2 to remove
            foreach (DataGridViewRow row in method1DataGridView.SelectedRows)
            {
                if (!row.IsNewRow)
                {
                    method1DataGridView.Rows.Remove(row);
                }
            }

        }

        private void method1DataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //int rowindex = method1DataGridView.CurrentRow.Index;
            //MessageBox.Show("Double click!");
            Datagridview_Event form3 = new Datagridview_Event();
            form3.catIdTextBox.Text = this.method1DataGridView.CurrentRow.Cells[0].Value.ToString();
            form3.catNameTextBox.Text = this.method1DataGridView.CurrentRow.Cells[1].Value.ToString();
            form3.catDescTextBox.Text = this.method1DataGridView.CurrentRow.Cells[2].Value.ToString();
            form3.ShowDialog();

        }

        private void autoCompleteComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            

        }

        private void addRowButton_Click(object sender, EventArgs e)
        {


        }

        private void bindDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow Myrow in bindDataGridView.Rows)
            {
                if (Convert.ToInt32(Myrow.Cells[0].Value) > 4)
                {
                    Myrow.DefaultCellStyle.BackColor = Color.Green;

                }
            }
        }
    }
}
