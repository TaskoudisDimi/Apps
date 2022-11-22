using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    [AttributeUsage(AttributeTargets.Class)]
    public class DatabaseTable : Attribute
    {
        public string Table { get; set; }
        public string Description { get; set; }
        public string JoinTables { get; set; }

        public DatabaseTable(string table, string joinTables = null, string description = null)
        {
            Table = table;
            JoinTables = joinTables;
            Description = string.IsNullOrWhiteSpace(description) ? table : description;
        }
    }
}
