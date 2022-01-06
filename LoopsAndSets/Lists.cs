using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsAndSets
{
    internal class Lists
    {
        public Lists()
        {
            List<string> firstNames = new List<string>();
            firstNames.Add("Tim");
            firstNames.Add("Bob");
            firstNames.Add("Sue");
            firstNames.Add("Jane");

            Console.WriteLine(firstNames[3]);
            firstNames.Sort();
            Console.WriteLine(firstNames[3]);
            Console.WriteLine($"Sorted names list{ string.Join(",", firstNames)}");

            List<int> Ages = new List<int>();
            Ages.Add(1);
            Ages.Add(2);    
            Ages.Add(3);    
            Ages.Add(4);
            Ages.Add(5);

            //List<T> - generic
            string data = "Corey,Smith,Jones";
            List<string> list = data.Split(',').ToList();
            list.Add("Franklin");

            List<int> ages = new List<int>() { 1, 2, 3, 4, 5, 6 };

            //Remove by index
            ages.RemoveAt(3);
            
            //Remove by value
            ages.Remove(3);
            firstNames.Remove("Bob");
        }
    }
}
