using System.Data.SqlClient;
using System.Configuration;
using System.Data.Common;
using System.Data;

namespace ClassLibrary
{
    public class DbContext : IDisposable
    {
        public SqlConnectionStringBuilder SqlConnection = new SqlConnectionStringBuilder(ConfigurationManager.ConnectionStrings["Supermarket"].ConnectionString);
        private string DataProviderName = ConfigurationManager.ConnectionStrings["Supermarket"].ProviderName;
        private string ConnectionString = ConfigurationManager.ConnectionStrings["Supermarket"].ConnectionString;

        private System.Data.Common.DbConnection DatabaseConnection = null;
        private System.Data.Common.DbTransaction DatabaseTransaction = null;

        public void OpenConnection()
         {
            if (DatabaseConnection == null)
            {
                DbProviderFactories.RegisterFactory("System.Data.SqlClient", System.Data.SqlClient.SqlClientFactory.Instance);
                System.Data.Common.DbProviderFactory factory = System.Data.Common.DbProviderFactories.GetFactory("System.Data.SqlClient");
                DatabaseConnection = factory.CreateConnection();
                DatabaseConnection.ConnectionString = ConnectionString;
            }

            if (DatabaseConnection != null && DatabaseConnection.State != System.Data.ConnectionState.Open)
            {
                DatabaseConnection.Open();
            }
        }
        public DbContext()
        {
            OpenConnection();
        }
        public void CloseConnection()
        {
            if (DatabaseConnection != null && DatabaseConnection.State != System.Data.ConnectionState.Closed)
            {
                DatabaseConnection.Close();
            }
        }
        public void Dispose()
        {
            CloseConnection();
        }

        public void BeginTransaction(IsolationLevel isolationLevel = IsolationLevel.ReadUncommitted)
        {
            OpenConnection();
            if (DatabaseTransaction == null)
            {
                DatabaseTransaction = DatabaseConnection.BeginTransaction(isolationLevel);
            }
        }

        public void CommitTransaction()
        {
            DatabaseTransaction.Commit();
            DatabaseTransaction = null;
        }

        public void RollbackTransaction()
        {
            DatabaseTransaction.Rollback();
            DatabaseTransaction = null;
        }


        public object ExecScalar(string cmd)
        {

            using (DbCommand command = DatabaseConnection.CreateCommand())
            {
                try
                {
                    if (DatabaseTransaction != null)
                        command.Transaction = DatabaseTransaction;
                    command.CommandType = CommandType.Text;
                    command.CommandText = cmd;
                    return command.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    throw ex;
                }

            }
        }


        public int ExecNQ(string cmd)
        {

            if (string.IsNullOrWhiteSpace(cmd) == false)
            {
                using (DbCommand command = DatabaseConnection.CreateCommand())
                {
                    try
                    {
                        if (DatabaseTransaction != null)
                            command.Transaction = DatabaseTransaction;
                        command.CommandType = CommandType.Text;
                        command.CommandText = cmd;
                        return command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
            }

            return -1;
        }


        public DbDataAdapter GetAdapter()
        {
            DbProviderFactory dbProviderFactory = DbProviderFactories.GetFactory(DataProviderName);
            return dbProviderFactory.CreateDataAdapter();
        }

        public DataTable ExecTable(string cmd)
        {

            DbDataAdapter adapter = GetAdapter();
            DataTable datatable = new DataTable();
            using (DbCommand command = DatabaseConnection.CreateCommand())
            {
                try
                {
                    if (DatabaseTransaction != null)
                        command.Transaction = DatabaseTransaction;
                    command.CommandType = CommandType.Text;
                    command.CommandText = cmd;
                    adapter.SelectCommand = command;
                    adapter.Fill(datatable);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return datatable;
        }

        public DbDataReader ExecReader(string cmd)
        {

            using (DbCommand command = DatabaseConnection.CreateCommand())
            {
                if (DatabaseTransaction != null)
                    command.Transaction = DatabaseTransaction;
                command.CommandType = CommandType.Text;
                command.CommandText = cmd;
                return command.ExecuteReader();
            }
        }


        public DataSet ExecDataSet(string cmd)
        {

            using (DbCommand command = DatabaseConnection.CreateCommand())
            {
                try
                {
                    DbDataAdapter adapter = GetAdapter();
                    if (DatabaseTransaction != null)
                        command.Transaction = DatabaseTransaction;
                    command.CommandText = cmd;
                    adapter.SelectCommand = command;
                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet);
                    return dataSet;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                return null;
            }
        }

       










    }
}