using Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;
using DocumentFormat.OpenXml.Vml;

namespace Forms.Forms
{
    public partial class Display_Save_Image : Form
    {
        public static SqlConnection con = new SqlConnection();
        string imageName = "";
        public Display_Save_Image()
        {
            InitializeComponent();
        }


        //Uploade Image
        private void button_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                imageName = ofd.FileName;
                pictureBox.Image = Image.FromFile(ofd.FileName);
            }
        }


        //Save Image
        public int imageId = 0 ;
        private void image()
        {
            byte[] imageData = File.ReadAllBytes(imageName);
            con.ConnectionString = ConfigurationManager.ConnectionStrings["Supermarket"].ConnectionString;
            string connectionString = con.ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO TestImage (Image) VALUES (@ImageData)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add("@ImageData", SqlDbType.VarBinary, -1).Value = imageData;
                command.ExecuteNonQuery();
            }
        }



        private void buttonSave_Click(object sender, EventArgs e)
        {
            image();
        }


        //Display Image
        private void buttonDisplayDB_Click(object sender, EventArgs e)
        {
            con.ConnectionString = ConfigurationManager.ConnectionStrings["Supermarket"].ConnectionString;
            string connectionString = con.ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                
                imageId = 1;
                string query = "SELECT Image FROM TestImage WHERE Id = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", imageId);
                byte[] imageData2 = (byte[])command.ExecuteScalar();
                using (MemoryStream stream = new MemoryStream(imageData2))
                {
                    pictureBox2.Image = Image.FromStream(stream);
                }
                command.ExecuteNonQuery();
            }



        }
    }
}
