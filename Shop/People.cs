using ShopLibrary;
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
    public partial class People : Form
    {
        Connection loaddata = new Connection();
        public People()
        {
            InitializeComponent();

            List<string> items = new List<string>();


            display();
            fill_peopleListBox();
        }

        private void display()
        {



            Connection loaddata2 = new Connection();
            loaddata2.retrieveData("Select * From People");
            PeopleDataGridView.DataSource = loaddata2.table;


        }

        private void addButton_Click(object sender, EventArgs e)
        {
            addPeople form = new addPeople();
            form.ShowDialog();
            
        }

        private void PeopleDataGridView_MouseDown_1(object sender, MouseEventArgs e)
        {
            ContextMenuStrip mnu = new ContextMenuStrip();
            ToolStripMenuItem mnuEdit = new ToolStripMenuItem("Edit");
            ToolStripMenuItem mnuDelete = new ToolStripMenuItem("Delete");
            //Assign event handlers
            mnuEdit.Click += new EventHandler(mnuEditPeople_Click);
            mnuDelete.Click += new EventHandler(mnuDeletePeople_Click);
            //Add to main context menu
            mnu.Items.AddRange(new ToolStripItem[] { mnuEdit, mnuDelete });
            //Assign to datagridview
            PeopleDataGridView.ContextMenuStrip = mnu;
        }

        private void mnuEditPeople_Click(object sender, EventArgs e)
        {
            EditVendor frm = new EditVendor();
            frm.FirstNameTextBox.Text = PeopleDataGridView.CurrentRow.Cells[0].Value.ToString();
            frm.LastNameTextBox.Text = PeopleDataGridView.CurrentRow.Cells[1].Value.ToString();
            frm.PhoneTextBox.Text = PeopleDataGridView.CurrentRow.Cells[2].Value.ToString();
            frm.ShowDialog();
        }

        private void mnuDeletePeople_Click(object sender, EventArgs e)
        {

            loaddata.commandExc("Delete From Items Where Phone=" + PeopleDataGridView.CurrentRow.Cells[2].Value.ToString() + "");

            foreach (DataGridViewRow row in PeopleDataGridView.Rows)
            {
                PeopleDataGridView.Rows.RemoveAt(row.Index);
            }
        }


        private void People_Items_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Confirm To Close Edit", "Exit", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }




        private void fill_peopleListBox()
        {
            Connection loaddata = new Connection();
            loaddata.retrieveData("Select * From People");
            PeopleListBox.DataSource = loaddata.table;
            PeopleListBox.DisplayMember = "FirstName";


        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            loaddata.commandExc("Delete From Items Where Phone=" + PeopleDataGridView.CurrentRow.Cells[2].Value.ToString() + "");

            foreach (DataGridViewRow row in PeopleDataGridView.Rows)
            {
                PeopleDataGridView.Rows.RemoveAt(row.Index);
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            EditVendor frm = new EditVendor();
            frm.FirstNameTextBox.Text = PeopleDataGridView.CurrentRow.Cells[0].Value.ToString();
            frm.LastNameTextBox.Text = PeopleDataGridView.CurrentRow.Cells[1].Value.ToString();
            frm.PhoneTextBox.Text = PeopleDataGridView.CurrentRow.Cells[2].Value.ToString();
            frm.ShowDialog();
        }
    }
}

