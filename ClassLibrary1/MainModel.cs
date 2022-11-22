using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class MainModel
    {
        [DatabaseColumn(IsPrimaryKey = true, Insert = false, Update = false, IgnoreHistory = true), Grid(Title = "ID")]
        public long ID { get; set; }

        [DatabaseColumn(Insert = true, Update = false, IgnoreHistory = true), Grid(Title = "Created", Format = Globals.DateTimeFormat)]
        public DateTime? DateCreated { get; set; }

        [DatabaseColumn(Insert = true, Update = true, IgnoreHistory = true), Grid(Title = "Last modified", Format = Globals.DateTimeFormat)]
        public DateTime? DateModified { get; set; }

        [DatabaseColumn(Insert = true, Update = false, IgnoreHistory = true), Grid(Title = "User created ID")]
        public int? UserCreated { get; set; }

        [DatabaseColumn(Insert = true, Update = true, IgnoreHistory = true), Grid(Title = "User modified ID")]
        public int? UserModified { get; set; }

        [DatabaseVirtualColumn(Query = "(select ISNULL([IQ_User].[usr_name], '') + ' ' + ISNULL([IQ_User].[usr_surname], '') from [IQ_User] where [IQ_User].[usr_id] = [{1}].[UserCreated])"), Grid(Title = "User created")]
        public string UserCreated_Lookup_Descr { get; set; }

        [DatabaseVirtualColumn(Query = "(select ISNULL([IQ_User].[usr_name], '') + ' ' + ISNULL([IQ_User].[usr_surname], '') from [IQ_User] where [IQ_User].[usr_id] = [{1}].[UserModified])"), Grid(Title = "User modified")]
        public string UserModified_Lookup_Descr { get; set; }

    }
}
