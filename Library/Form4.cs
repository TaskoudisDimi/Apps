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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog()
            {
                Title = "Browse Text File",
                CheckFileExists = true,
                CheckPathExists = true,
                Filter = "txt files (*.txt)|*.txt",
                FilterIndex = 2,
                RestoreDirectory = true,
                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                importFiletextBox.Text = openFileDialog1.FileName;
                Helper.file = importFiletextBox.Text;

                importFileDataGridView.DataSource = Helper.DataTableFromTextFile(importFiletextBox.Text);

            }
        }
    }
}
