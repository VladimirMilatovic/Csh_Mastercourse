using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonVariables
{
    internal class BoolVariable
    {
        //Bool True or False; 0 or 1


        public BoolVariable()
        {
            bool start = true;
            bool isComplete = false;
            Console.WriteLine(isComplete);

            isComplete = !isComplete;// ! not, invert value; !true = false
            Console.WriteLine(isComplete); //OUTPUT true

            isComplete = !true; // equal false
            Console.WriteLine(isComplete); // OUTPUT false

            Console.WriteLine(!isComplete); //invert value but not change valu of isComplete variable; OUTPUT True

            // arithmetic with bool
            Console.WriteLine(start && isComplete); // AND 1 and 1 = 1, all other cases is 0
            Console.WriteLine(start||isComplete); // OR 0 or 0 = 0, all other cases is 1
        }
    }
}
