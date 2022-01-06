using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsAndSets
{
    internal class Arrays
    {
        public Arrays()
        {
            // 0-based counting - 0,1,2,3,4
            // 1-based counting - 1,2,3,4,5
            string[] firstNames = new string[5];
            firstNames[0] = "Tim";
            firstNames[1] = "Sue";
            firstNames[2] = "Bob";
            firstNames[4] = "Jane";
            
            Console.WriteLine($"The firstNames are {firstNames[0]}, {firstNames[1]}, {firstNames[2]}, {firstNames[3]}, {firstNames[4]}");
            Array.Sort(firstNames);
            Console.WriteLine($"The sorted firstNames are {firstNames[0]}, {firstNames[1]}, {firstNames[2]}, {firstNames[3]}, {firstNames[4]}");

            string data = "Bob,Tim,Sue,Jane,Frank";
            string[] secondNames = data.Split(',');
            Console.WriteLine(secondNames[3]);

            //Lenght - 1 based counting
            Console.WriteLine(firstNames.Length);

            string[] thirdNames = new string[] { "asdˇ", "qwe", "asds", "asewq", "trewew" };
            int[] ages = new int[] { 1, 2, 3, 4, 5, 6, 7 };

            //matrix - 2D array
            int[][] matrix = new int[][] { new int[] { 1, 2, 3, 4, 5, 6, 7 }, new int[] { 6, 5, 4, 3, 2, 1 } };
        }
    }
}
