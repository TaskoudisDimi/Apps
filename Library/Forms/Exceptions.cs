using com.itextpdf.text.pdf;
using Library;
using OfficeOpenXml.LoadFunctions.Params;
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
    public partial class Exceptions : Form
    {
        public Exceptions()
        {
            InitializeComponent();
            Loaddata();
        }

        private void Loaddata()
        {
            try
            {

                dataGridView1.Rows[1].ToString();
                //SqlConnect loaddata = new SqlConnect();
                //loaddata.retrieveData("Select * From Exceptions");
                //dataGridView1.DataSource = loaddata.table;
            }
            catch (Exception ex)
            {
                SqlConnect exc = new SqlConnect();
                string exception = $"Insert Into Exceptions Values('{ex.Message.Replace("'","")}', '{ex.StackTrace}', '{DateTime.Now}')";
                exc.commandExc(exception);
            }
        }

    }
}
