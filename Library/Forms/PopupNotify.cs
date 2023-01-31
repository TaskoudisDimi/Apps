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
            test();
        }

        private void test()
        {
            Thread.Sleep(1000);
            PopupNotifier pop = new PopupNotifier();
            pop.TitleText = "Test Title";
            pop.ContentText = "Popup Test";




        }


    }
}
