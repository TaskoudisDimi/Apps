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
            //mapWebBrowser.Navigate("https://idp-ua.mtmlink.net/Account/Login?ReturnUrl=%2Fconnect%2Fauthorize%2Fcallback%3Fresponse_mode%3Dform_post%26response_type%3Did_token%26redirect_uri%3Dhttps%253A%252F%252Ftp.mtmlink.net%252Fservice%252Fsso%252Fvalidate%26client_id%3DMTM-onlineaccess%26nonce%3D95b5a7ccdde930e37406f7ecec5df1b8%26state%3Df976b6dc1f6a0f838c0b30b483c1cac2%26scope%3Dopenid%2520profile%2520email%2520openid");
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
