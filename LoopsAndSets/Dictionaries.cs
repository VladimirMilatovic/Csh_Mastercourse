using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsAndSets
{
    internal class Dictionaries
    {
        public Dictionaries()
        {
            Dictionary<string, string> lookup = new Dictionary<string, string>();
            lookup["animal"] = "Not a human";
            lookup["fish"] = "Not a human that swims";
            lookup["human"] = "Us";

            Console.WriteLine(lookup["fish"]);

            Dictionary<int,string> employees=new Dictionary<int,string>();
            employees[91] = "Tim Corey";
            employees[21] = "Sue Storm";

            Console.WriteLine(employees[22]);
        }

    }
}
