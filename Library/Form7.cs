using CefSharp;
using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSettings = CefSharp.CefSettings;

namespace Library
{
    public partial class Form7 : Form
    {
        ChromiumWebBrowser chrome;

        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            CefSettings settings = new CefSettings();
            //Initialize settings
            Cef.Initialize(settings);
            textBox1.Text = "https://google.com";
            chrome = new ChromiumWebBrowser(textBox1.Text);
            this.panel1.Controls.Add(chrome);  
            chrome.Dock = DockStyle.Fill;
            chrome.AddressChanged += Chrome_AddressChanged;
        }

        private void Chrome_AddressChanged(object sender, AddressChangedEventArgs e)
        {
            this.Invoke(new MethodInvoker(() =>
            {
                textBox1.Text = e.Address;
            }));
            
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            chrome.Load(textBox1.Text);
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            chrome.Refresh();
        }
    }
}
