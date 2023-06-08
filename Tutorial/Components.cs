using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    public class Components
    {
        public int CompId { get; set; }
        public string CompName { get; set; }

        // Instance-specific, cannot be changed after initialization
        public readonly int readOnlyTest = 10;
        
        public Components(int compId, string compName)
        {
            CompId = compId;
            CompName = compName;
        }
    }
}
