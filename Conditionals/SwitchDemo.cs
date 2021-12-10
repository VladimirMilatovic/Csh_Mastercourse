using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    internal class SwitchDemo
    {
        public SwitchDemo()
        {
            string firstName = "sue";
            int age = -75;

            switch (firstName.ToLower())
            {
                case "sue":
                case "tim":
                    Console.WriteLine("Hello Tim.");
                    break;
                case "tom":
                    Console.WriteLine("Hello Tom.");
                    break;
                default:
                    Console.WriteLine("I don't know you.");
                    break;
            }

            switch (age)
            {
                case >= 0 and < 18:
                    Console.WriteLine("You are child.");
                    break;
                case >= 18 and < 66:
                    Console.WriteLine("You shuld have a job.");
                    break;
                case > 66:
                    Console.WriteLine("You are retired.");
                    break;
                default:
                    Console.WriteLine("Age is not in expected range.");
                    break;
            }
        }
    }
}
