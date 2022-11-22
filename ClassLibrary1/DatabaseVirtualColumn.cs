using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class DatabaseVirtualColumn : DatabaseAttribute
    {
        public string Query { get; set; }

        public DatabaseVirtualColumn([CallerMemberName] string name = null, string query = null) : base(name, false, false, false, false, true)
        {
            Name = name;
            Query = query;
        }
    }
}
