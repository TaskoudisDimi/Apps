using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopLibrary
{
    public class Store
    {


        public string Name { get; set; }
        public List<Vendor> Vendors { get; set; }
        public List<Item> Items { get; set; }

        //Constructor για τις Lists Vendor, Items
        public Store()
        {
            Vendors = new List<Vendor>();
            Items = new List<Item>();

        }


    }
}
