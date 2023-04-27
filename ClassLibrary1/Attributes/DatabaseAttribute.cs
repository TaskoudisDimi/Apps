using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class DatabaseAttribute : Attribute
    {
        public string Name { get; set; }
        public bool Read { get; set; }
        public bool Insert { get; set; }
        public bool Update { get; set; }
        public bool IsPrimaryKey { get; set; }
        public bool IsForeignKey { get; set; }
        public bool IsHtml { get; set; }



        public DatabaseAttribute()
        {
            Name = string.Empty;
        }

        public DatabaseAttribute(string name, bool insert, bool update, bool isPrimaryKey, bool isForeignKey, bool read)
        {
            Name = name;
            Insert = insert;
            Update = update;
            IsPrimaryKey = isPrimaryKey;
            IsForeignKey = isForeignKey;
            Read = read;
        }

       

    }
}
