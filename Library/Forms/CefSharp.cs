
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
//using CefSettings = CefSharp.CefSettings;

namespace Library
{
    public partial class CefSharp : Form
    {
        public CefSharp()
        {
            InitializeComponent();
            
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            //InitBrowser();
            
        }

        public void InitBrowser()
        {
            // TODO: Import CefSharp library
            //Cef.Initialize(new CefSettings());
            //browser = new ChromiumWebBrowser("www.youtube.com");
            //browserPanel.Controls.Add(browser);
        }

        private void timerButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Timer MyTimer = new System.Windows.Forms.Timer();
            MyTimer.Interval = 5000;
            MyTimer.Tick += new EventHandler(MyTimer_Tick);
            MyTimer.Start();
        }
        private void MyTimer_Tick(object sender, EventArgs e)
        {
            MessageBox.Show("Test Timer", "Time Elapsed");
        }
    }
}
