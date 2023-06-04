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
    public partial class EditVendor : Form
    {
        Connection loaddata = new Connection();

        public EditVendor()
        {
            InitializeComponent();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            loaddata.commandExc("Update Vendor set FirstName = '" + FirstNameTextBox.Text + "', LastName = '" + LastNameTextBox.Text + "', Phone = " + PhoneTextBox.Text +  ", Sum = " + sumTextBox.Text +" Where id = '" + idTextBox.Text + "'");
            MessageBox.Show("Vendor Edit successfuly");
            this.Close();
        }
    }
}
