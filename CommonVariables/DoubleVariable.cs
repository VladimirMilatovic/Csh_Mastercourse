using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonVariables
{
    internal class DoubleVariable
    {
        //doubles can have a decimal point - 1.23, 43
        //not used for money
        //used for math calculations
        double averageAge;

        public DoubleVariable()
        {
            averageAge = (23 + 43 + 62) / 3.0 ; //One number must be in double format 3.0 so compiler treat all numbers as double

            Console.WriteLine(averageAge);
        }
    }
}
