using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace Lesson1.DataAccess
{
    public class SqlConnector
    {
        public static string constring = ConfigurationManager.ConnectionStrings["Tutorial"].ConnectionString;
        SqlConnection con = new SqlConnection(constring);


    }
}
