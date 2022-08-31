using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class Progress : Form
    {
        public Progress()
        {
            InitializeComponent();
        }


        public void SetProgress(int value, string Message = null)
        {
            if (value <= progressBar.Maximum)
                progressBar.Value = value;
            LabelProgress.Text = string.IsNullOrWhiteSpace(Message) ? string.Empty : Message;
        }


    }
}
