using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonVariables
{
    internal class NullValue
    {
        public NullValue()
        {
            // null - lack of value

            //We didn't ask for the age yet
            //int age = 0; // is this OK if we don't know right value?

            //Haven't asked for the age yet
            int? age = null;

            // We have asked for the age now.
            age = 0;

            bool? isAlive = null;
            double? value = null;

            string name = null;
            string? nullableName = null;

            Console.WriteLine($"age: {age}");
            Console.WriteLine($"name: {name}");
            Console.WriteLine($"nullableName: {nullableName}");
            Console.WriteLine($"bool: {isAlive}");
            Console.WriteLine($"double: {value??10}");
        }
    }
}
