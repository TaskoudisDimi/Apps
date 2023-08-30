using ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms.Forms
{
    public partial class CustomForm : Form
    {

        private CustomObjects customObjects;

        public CustomForm()
        {
            InitializeComponent();

        }

        private void CustomForm_Load(object sender, EventArgs e)
        {
            customObjects = new CustomObjects(); // Create an instance of CustomObjects class
            CreateObjects();
        }

        private void CreateObjects()
        {
            Button button = CustomObjects.CreateButton("Test1", 20, 20, 20, 20);
            Controls.Add(button);
        }
    }
}
