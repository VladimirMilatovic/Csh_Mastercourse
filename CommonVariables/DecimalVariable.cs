using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonVariables
{
    internal class DecimalVariable
    {
        //decimal from ±1.0 x 10-28 to ±7.9228 x 10pow28
        //42.1, 23, -1.2234
        decimal bankAccountBalance;


        public DecimalVariable()
        {
            bankAccountBalance = 2.34M; //M is suffix to make it decimal type
            bankAccountBalance = 1 / 3.0M; //Output 0,3333333333333333333333333333; 28 decimals

            Console.WriteLine(bankAccountBalance);
        }
    }
}
