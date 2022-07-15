using ClosedXML.Excel;
using Lesson1.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;
using System.Text.RegularExpressions;
using Excel = Microsoft.Office.Interop.Excel;


//using Excel = Microsoft.Office.Interop.Excel;

namespace Library
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();

            SqlConnector loaddata = new SqlConnector();
            loaddata.retrieveData("Select * From [smarketdb].[dbo].[CategoryTbl]");

            DataGridView.DataSource = loaddata.table;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            SqlConnector loaddata2 = new SqlConnector();
            loaddata2.retrieveData("Select * From CategoryTbl Where Date='" + dateTimePicker1.Text + "'" );
            DataGridView.DataSource = loaddata2.table;
        }



    }

}
