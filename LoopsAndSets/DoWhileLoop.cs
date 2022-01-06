using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsAndSets
{
    internal class DoWhileLoop
    {
        public DoWhileLoop()
        {
            int age;
            bool isValid;

            // run code at least once
            do
            {
                Console.WriteLine("Enter your age:");
                string ageText = Console.ReadLine();

                isValid = int.TryParse(ageText, out age);
                if (isValid == false)
                {
                    Console.WriteLine("That was invalid age.");
                }

            } while (isValid == false);
            Console.WriteLine($"You age is {age}");

            while (isValid == false)
            {
                // run code 0 or more

            }
        }
    }
}
