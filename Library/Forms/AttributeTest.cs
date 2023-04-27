using ClassLibrary;
using Forms.Models;
using Lesson1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms.Forms
{
    public partial class AttributeTest : Form
    {
        public AttributeTest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Category> categories = ReadFromSqlTable<Category>();
            foreach (Category categorie in categories)
            {
                Console.WriteLine(categorie.CatId);
            }
        }
        public static List<T> ReadFromSqlTable<T>() where T : new()
        {
            List<T> result = new List<T>();

            Type type = typeof(T);
            SqlTableAttribute tableAttribute = (SqlTableAttribute)type.GetCustomAttributes(typeof(SqlTableAttribute), false).FirstOrDefault();
            if (tableAttribute == null)
            {
                throw new Exception("SqlTableAttribute not found on class " + type.Name);
            }

            string tableName = tableAttribute.TableName;
            string connectionString = ConfigurationManager.ConnectionStrings["Supermarket"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = "SELECT * FROM " + tableName;
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        T item = new T();
                        foreach (PropertyInfo property in type.GetProperties())
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal(property.Name)))
                            {
                                property.SetValue(item, reader.GetValue(reader.GetOrdinal(property.Name)));
                            }
                        }
                        result.Add(item);
                    }
                    reader.Close();
                }
            }

            return result;
        }

    }
}
