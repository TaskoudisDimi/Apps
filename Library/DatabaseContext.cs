using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms
{
    public class DatabaseContext : DbContext
    {
       
        public DbSet<CategoryTbl> CategoryTbl { get; set; }
    }

    // Define a model class that corresponds to your database table
    public class CategoryTbl
    {
        public int CatId { get; set; }
        public string CatName { get; set; }
        public string CatDesc { get; set; }
        public DateTime Date { get; set; }

    }

}

