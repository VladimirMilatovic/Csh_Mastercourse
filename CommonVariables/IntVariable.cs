using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonVariables
{
    internal class IntVariable
    {
        //Int whole number; -1, 0, 1, 12334... No 1.2, -1,4 
        //int max +- Two billion
        // int represent signed Int32 
        // unsigned UInt32; 4 billion
        int age = 0; //initial value 0
        public IntVariable()
        {
            age = 43; //asign Number value, no quotes, "43" is string value
            int ageInTenYears = age + 10;
            age = age + 10; //Asign new value to variable age
            age += 10; //Increment age for 10
            age -= 10; //Decrement age for 10


            Console.WriteLine(age); //Implicit conversion to string
            Console.WriteLine(age.ToString()); //Explicit conversion using ToString() method
            Console.WriteLine(age/2); // Don't devide ints Output: 21 wrong
        }
    }
}
