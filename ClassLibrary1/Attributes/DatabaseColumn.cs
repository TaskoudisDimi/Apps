using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class DatabaseColumn : Attribute
    {
        public string Table { get; set; }
        public string SortQuery { get; set; }
        public bool IgnoreHistory { get; set; }
        public bool Encrypted { get; set; }

        /// <summary>
        /// Default value 1.000.000 charachters
        /// </summary>
        public int StringLength { get; set; }


        public DatabaseColumn([CallerMemberName] string name = null, string table = null, bool read = true, bool insert = true, bool update = true, bool isPrimaryKey = false, string sortQuery = null, bool ignoreHistory = false, int stringLength = 1000000, bool encrypted = false)
        {
            //Name = name;
            //Table = table;
            //Read = read;
            //Insert = insert;
            //Update = update;
            //IsPrimaryKey = isPrimaryKey;
            //SortQuery = sortQuery;
            //IgnoreHistory = ignoreHistory;
            //Encrypted = encrypted;
            //StringLength = stringLength;
        }
    }
}
