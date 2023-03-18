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
            progressBar.Minimum = 0;
            LabelProgress.Text = string.Empty;
        }


        //public void SetStyle(ProgressBarStyle style)
        //{
        //    progressBar.Style = style;
        //}

        //public Progress(int max) : this()
        //{
        //    SetMax(max);
        //}

        //public void SetMax(int max)
        //{
        //    progressBar.Maximum = max;
        //}

        //public void SetProgress(int value, string Message = null)
        //{
        //    if (value <= progressBar.Maximum)
        //        progressBar.Value = value;
        //    LabelProgress.Text = string.IsNullOrWhiteSpace(Message) ? string.Empty : Message;
        //}


    }
}
