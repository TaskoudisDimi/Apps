﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms.Forms
{
    public partial class UploadFIles : Form
    {
        public UploadFIles()
        {
            InitializeComponent();
        
        
        }

        private void upload()
        {
            using (var client = new WebClient())
            {
                client.Credentials = new NetworkCredential("dlpuser", "rNrKYTX9g7z3RgJRmxWuGHbeu");
                client.UploadFile("ftp.dlptest.com", WebRequestMethods.Ftp.UploadFile, @"C:\Users\ASUS\Desktop\Programming\C#\Modify.txt");
            }
        }



    }
}
