using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms.Forms
{
    public partial class RecordVoice : Form
    {
        [DllImport("winmm.dll")]

        private static extern int mciSendString(string lpstrCommand, string lpstrReturnString, int uReturnLength, int hwndCallback);

        public RecordVoice()
        {
            InitializeComponent();
            mciSendString("open new Type waveaudio alias recsound", null, 0, 0);
            recordButton.Click += new EventHandler(this.recordButton_Click);
        }


        private void recordButton_Click(object sender, EventArgs e)
        {
            mciSendString("record recsound", null, 0, 0);
            stopButton.Click += new EventHandler(this.stopButton_Click);
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            mciSendString("save recsound C:\\Users\\ASUS\\Desktop\\Programming\\C#\\test.wav", null, 0, 0);
            mciSendString("close recsound", null, 0, 0);

        }

    }
}
