using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms.Models
{
    [SqlTable("CategoryTbl")]
    public class Category
    {

        public int CatId { get; set; }
        public string CatName { get; set; }
        public string CatDesc { get; set; }
        public DateTime Date { get; set; }

    }


}