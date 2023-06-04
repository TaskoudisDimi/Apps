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
    public partial class addPeople : Form
    {
        public addPeople()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                Connection loaddata = new Connection();
                loaddata.commandExc("Insert Into People Values(" + PhoneTextBox.Text + ",'" + FirstNameTextBox.Text + "','" + LastNameTextBox.Text + "')");
                MessageBox.Show("Succes Insert");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
