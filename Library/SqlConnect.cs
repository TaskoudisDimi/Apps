using Microsoft.Data.Sql;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class SqlConnect
    {

        SqlConnection con = new SqlConnection();
        public DataTable table = new DataTable();
        

        public SqlConnect(string connectionString)
        {
            con.ConnectionString = connectionString;
        }
        
        public void retrieveData(string command)
        {
            try
            {
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(command, con);
                adapter.Fill(table);

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        public void commandExc(string command)
        {
            try
            {
                con.Open();
                SqlCommand sqlcomm = new SqlCommand(command, con);

                int rowInfected = sqlcomm.ExecuteNonQuery();
                if (rowInfected > 0)
                {
                    Console.WriteLine("Success to connect with db!");
                }
                else
                {
                    Console.WriteLine("Fail to connect with db!");
                }
            }
            catch (Exception ex)
            {

            }
        }

        public void GetDatabases()
        {
            try
            {
                con.Open();
                string command = "SELECT name FROM sys.databases";
                SqlDataAdapter adapter = new SqlDataAdapter(command, con);
                adapter.Fill(table);

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }



        //public void test()
        //{

        //    SqlConnectionStringBuilder connection = new SqlConnectionStringBuilder();

        //    connection.DataSource = SelectedServer;
        //    // enter credentials if you want
        //    //connection.UserID = //get username;
        //    // connection.Password = //get password;
        //    connection.IntegratedSecurity = true;

        //    String strConn = connection.ToString();

        //    //create connection
        //    SqlConnection sqlConn = new SqlConnection(strConn);

        //    //open connection
        //    sqlConn.Open();

        //    //get databases
        //    DataTable tblDatabases = sqlConn.GetSchema("Databases");

        //    //close connection
        //    sqlConn.Close();

        //    //add to list
        //    foreach (DataRow row in tblDatabases.Rows)
        //    {
        //        String strDatabaseName = row["database_name"].ToString();

        //        databases.Add(strDatabaseName);


        //    }
        //}


    }
}
