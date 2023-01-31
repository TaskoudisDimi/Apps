using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace Forms.Forms
{
    public partial class PopupNotify : Form
    {
        public PopupNotify()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            PopupNotifier pop = new PopupNotifier();
            pop.TitleText = "Test Title";
            pop.ContentText = "Popup Test";
            pop.Popup();
        }


        private void PopupNotify_Move(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                notifyIcon1.ShowBalloonTip(100000, "Notice", "Click this", ToolTipIcon.Info);
            }
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
        }
    }
}
