using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPSMap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            mapWebBrowser.ScriptErrorsSuppressed = true;

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string street = streetTextBox.Text;
            string city = cityTextBox.Text;
            string state = stateTextBox.Text;
            string zip = zipTextBox.Text;

            StringBuilder queryaddress = new StringBuilder();
            queryaddress.Append("http://google.com/maps?q=");
            if (street != string.Empty)
            {
                queryaddress.Append(street + "," + "+");
            }
            if(city != string.Empty)
            {
                queryaddress.Append(city + "," + "+");
            }
            if(state != string.Empty)
            {
                queryaddress.Append(state + "," + "+");
            }
            if(zip != string.Empty)
            {
                queryaddress.Append(zip + "," + "+");
            }

            mapWebBrowser.Navigate(queryaddress.ToString());


        }
    }
}
