using System.Data.SqlClient;
using System.Configuration;

namespace ClassLibrary
{
    public class Connect : IDisposable
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
                System.Data.Common.DbProviderFactory factory = System.Data.Common.DbProviderFactories.GetFactory("System.Data.SqlClient");
                DatabaseConnection = factory.CreateConnection();
                DatabaseConnection.ConnectionString = ConnectionString;
            }

            if (DatabaseConnection != null && DatabaseConnection.State != System.Data.ConnectionState.Open)
            {
                DatabaseConnection.Open();
            }
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


    }
}