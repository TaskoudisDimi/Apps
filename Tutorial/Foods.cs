using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    public class Foods
    {
        public int FoodId { get; set; }
        public string FoodName { get; set; }
        public List<Components> Components { get; set; }

        public Foods(int foodId, string foddName, List<Components> components)
        {
            FoodId = foodId;
            FoodName = foddName;
            Components = components;
        }

    }


}


