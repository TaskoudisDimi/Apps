using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Forms.Forms
{
    public partial class ProgressWait : Form
    {

        public ProgressWait()
        {
            InitializeComponent();
            
           
        }
        // Define a method to update the progress bar
        public void UpdateProgressBar(int progress)
        {
            // Ensure that the progress value is within the valid range (0-100)
            if (progress >= 0 && progress <= 100)
            {
                progressBar.Value = progress;
            }
        }


    }
}
