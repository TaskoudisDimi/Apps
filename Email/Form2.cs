using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;


namespace Email
{
    public partial class Form2 : Form
    {

        public ChromiumWebBrowser browser;

        public Form2()
        {
            InitializeComponent();
            InitBrowser();
        }


        public void InitBrowser()
        {
            Cef.Initialize(new CefSettings());
            browser = new ChromiumWebBrowser("www.youtube.com");
            browserPanel.Controls.Add(browser); 
        }


    }
}
