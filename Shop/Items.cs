using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop
{
    public partial class Items : Form
    {

        public Items()
        {
            InitializeComponent();

            DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            dataGridViewCheckBoxColumn.Name = "Select";
            dataGridViewCheckBoxColumn.HeaderText = "Select";
            dataGridViewCheckBoxColumn.ReadOnly = false;
            ItemsDataGridView.Columns.Add(dataGridViewCheckBoxColumn);

            Connection loaddata2 = new Connection();
            loaddata2.retrieveData("Select * From Items");
            ItemsListBox.DataSource = loaddata2.table;
            ItemsListBox.DisplayMember = "Title";

            display();

        }

        private void display()
        {
            Connection loaddata = new Connection();
            loaddata.retrieveData("Select * From Items");
            ItemsDataGridView.DataSource = loaddata.table;


        }

        private void ItemsDataGridView_MouseDown_1(object sender, MouseEventArgs e)
        {
            ContextMenuStrip mnu = new ContextMenuStrip();
            ToolStripMenuItem mnuEdit = new ToolStripMenuItem("Edit");
            ToolStripMenuItem mnuDelete = new ToolStripMenuItem("Delete");
            mnuEdit.Click += new EventHandler(mnuEditItems_Click);
            mnuDelete.Click += new EventHandler(mnuDeleteItems_Click);
            mnu.Items.AddRange(new ToolStripItem[] { mnuEdit, mnuDelete });
            ItemsDataGridView.ContextMenuStrip = mnu;
            ItemsDataGridView.AllowUserToAddRows = false;
        }

        private void mnuDeleteItems_Click(object sender, EventArgs e)
        {
            Connection loaddata1 = new Connection();

            loaddata1.commandExc("Delete From Items Where Price=" + ItemsDataGridView.CurrentRow.Cells[2].Value.ToString() + "");

            foreach (DataGridViewRow row in ItemsDataGridView.Rows)
            {
                ItemsDataGridView.Rows.RemoveAt(row.Index);
            }
        }


        public void mnuEditItems_Click(object sender, EventArgs e)
        {
            EditItems frm = new EditItems();
            frm.PriceTextBox.Text = ItemsDataGridView.CurrentRow.Cells[3].Value.ToString();
            frm.TitleTextBox.Text = ItemsDataGridView.CurrentRow.Cells[1].Value.ToString();
            frm.DescriptionTextBox.Text = ItemsDataGridView.CurrentRow.Cells[2].Value.ToString();

            frm.ShowDialog();
        }

        private void CalcSum()
        {
            double sum = 0;
            for (int i = 0; i < ItemsDataGridView.Rows.Count; i++)
            {
                if (Convert.ToBoolean(ItemsDataGridView.Rows[i].Cells[0].Value) == true)
                {
                    sum += double.Parse(ItemsDataGridView.Rows[i].Cells[3].Value.ToString());

                }
            }

            sumTextBox.Text = sum.ToString();
        }

        private void itemsButton_Click(object sender, EventArgs e)
        {
            addItems form = new addItems();
            form.ShowDialog();
        }

        private void sumButton_Click_1(object sender, EventArgs e)
        {
            CalcSum();

        }

        private void Items_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Confirm To Close Edit", "Exit", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            EditItems frm = new EditItems();
            frm.PriceTextBox.Text = ItemsDataGridView.CurrentRow.Cells[3].Value.ToString();
            frm.TitleTextBox.Text = ItemsDataGridView.CurrentRow.Cells[1].Value.ToString();
            frm.DescriptionTextBox.Text = ItemsDataGridView.CurrentRow.Cells[2].Value.ToString();

            frm.ShowDialog();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            Connection loaddata2 = new Connection();

            loaddata2.commandExc("Delete From Items Where Price=" + ItemsDataGridView.CurrentRow.Cells[2].Value.ToString() + "");

            foreach (DataGridViewRow row in ItemsDataGridView.Rows)
            {
                ItemsDataGridView.Rows.RemoveAt(row.Index);
            }
        }
    }
}
