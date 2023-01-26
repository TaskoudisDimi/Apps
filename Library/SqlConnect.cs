using Forms;
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
        public SqlDataAdapter adapterPage = new SqlDataAdapter();
        public SqlConnect()
        {
            con.ConnectionString = ConfigurationManager.ConnectionStrings["Supermarket"].ConnectionString;
        }
        public int ExecuteSqlTransaction(string cmd)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Supermarket"].ConnectionString))
            {
                connection.Open();

                SqlCommand command = connection.CreateCommand();
                SqlTransaction transaction;

                // Start a local transaction.
                transaction = connection.BeginTransaction();

                // Must assign both transaction object and connection
                // to Command object for a pending local transaction
                //command.Connection = connection;
                command.Transaction = transaction;

                try
                {
                    command.CommandType = CommandType.Text;
                    command.CommandText = cmd;

                    int res = command.ExecuteNonQuery();

                    // Attempt to commit the transaction.
                    transaction.Commit();
                    Console.WriteLine("Both records are written to database.");
                    return res;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Commit Exception Type: {0}", ex.GetType());
                    Console.WriteLine("  Message: {0}", ex.Message);
                    return -1;
                    // Attempt to roll back the transaction.
                    try
                    {
                        transaction.Rollback();
                    }
                    catch (Exception ex2)
                    {
                        // This catch block will handle any errors that may have occurred
                        // on the server that would cause the rollback to fail, such as
                        // a closed connection.
                        Console.WriteLine("Rollback Exception Type: {0}", ex2.GetType());
                        Console.WriteLine("  Message: {0}", ex2.Message);
                    }
                }
            }
        }

        public void retrieveData(string command)
        {
            try
            {
                table.Clear();
                SqlDataAdapter adapter = new SqlDataAdapter(command, con);
                adapter.Fill(table);
                Logs log = new Logs(command);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        //public int Fill(int startRecord, int maxRecords, params DataTable[] dataTables);
        public void pagingData(string command, int test1, int test2)
        {
            try
            {
                table.Clear();
                SqlDataAdapter adapter = new SqlDataAdapter(command, con);
                adapter.Fill(test1, test2, table);
                Logs log = new Logs(command);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
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

    }
    


    //public void GetDatabases()
    //{
    //    try
    //    {
    //        con.Open();
    //        string command = "SELECT name FROM sys.databases";
    //        SqlDataAdapter adapter = new SqlDataAdapter(command, con);
    //        adapter.Fill(table);

    //    }
    //    catch (Exception ex)
    //    {

    //        Console.WriteLine(ex.Message);
    //    }
    //    finally
    //    {
    //        con.Close();
    //    }
    //}

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
