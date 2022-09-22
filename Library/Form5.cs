using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using Lesson1.DataAccess;
using PageList;
using Lesson1.Data;
using Newtonsoft.Json;

namespace Library
{
    public partial class Form5 : Form
    {


        public Form5()
        {
            InitializeComponent();


            
        }

        public void nextButton_Click(object sender, EventArgs e)
        {



        }

        private void Form5_Load(object sender, EventArgs e)
        {
            //using (var client = new HttpClient())
            //{
            //    var endpoint = new Uri("http://localhost:52465/api/products");
            //    var result1 = client.GetAsync(endpoint).Result;
            //    var json = result1.Content.ReadAsStringAsync().Result;
            //    var result = JsonConvert.DeserializeObject<List<Products>>(json);
            //    pagingDataGridView.DataSource = result;
            //}
               
            

        }



    }


}
