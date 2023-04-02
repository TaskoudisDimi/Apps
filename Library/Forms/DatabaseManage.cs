using Forms.Models;
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
    public partial class DatabaseManage : Form
    {
        public DatabaseManage()
        {
            InitializeComponent();
        }

        private void DatabaseManage_Load(object sender, EventArgs e)
        {
            DatabaseManager dbManager = new DatabaseManager("server=DIMITRISTASKOUD\\DIMITRIS_TASKOUD;database=smarketdb;Integrated Security=SSPI;");


            var customerType = typeof(Category);
            var customerProperties = customerType.GetProperties();
            var customerColumns = customerProperties.Select(p => new SchemaColumn(p.Name, GetSqlType(p.PropertyType))).ToList();
            var customerTable = new SchemaTable("CategoryTbl", customerColumns);
            List<SchemaTable> tables = new List<SchemaTable>();
            tables.Add(customerTable);
            dbManager.CheckSchema(tables);
        }
        private SqlDbType GetSqlType(Type type)
        {
            if (type == typeof(int))
            {
                return SqlDbType.Int;
            }
            else if (type == typeof(string))
            {
                return SqlDbType.NVarChar;
            }
            else if (type == typeof(DateTime))
            {
                return SqlDbType.DateTime;
            }
            else if (type == typeof(decimal))
            {
                return SqlDbType.Decimal;
            }
            else
            {
                // Handle other data types as needed
                throw new NotSupportedException($"Data type {type.Name} is not supported.");
            }
        }

    }
}
