using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
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

        public string GetKendoModelField(List<PropertyInfo> properties)
        {
            return $"{Name}: {{ field: '{Name}', type: '{ GetFieldType(properties)}', encoded: false, editable: true }}";
        }

        public string GetKendoColumnField()
        {
            return $"{{field: '{Name}', encoded: false, title: '{Name}', width: '200px', filterable: true, sortable: true {GetColumnEditor()}}}";
        }

        private string GetColumnEditor()
        {
            if (IsHtml)
                return ", editor: HtmlEditor";

            return string.Empty;
        }

        private string GetFieldType(List<PropertyInfo> properties)
        {
            PropertyInfo prop = properties.SingleOrDefault(x => x.Name.Equals(Name));
            if (prop != null)
            {
                Type t = prop.PropertyType;
                if (t == typeof(DateTime) || t == typeof(DateTime?))
                    return "date";
                else if (t == typeof(int) || t == typeof(int?) || t == typeof(long) || t == typeof(long?) || t == typeof(float) || t == typeof(float?) || t == typeof(double) || t == typeof(double?) || t == typeof(decimal) || t == typeof(decimal?))
                    return "number";
                else if (t == typeof(bool) || t == typeof(bool?))
                    return "boolean";
            }
            return "string";
        }



    }
}
