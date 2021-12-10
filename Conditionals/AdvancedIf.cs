using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    internal class AdvancedIf
    {
        public AdvancedIf()
        {
            Console.WriteLine("What is your name?");
            string? firstName = Console.ReadLine();

            Console.WriteLine("What is your last name?");
            string? lastName = Console.ReadLine();

            if (firstName.ToLower() == "tim" &&
                lastName.ToLower() == "corey")
            {
                Console.WriteLine("Hello Mr. Tim Corey");
            }
            else if (lastName.ToLower() == "corey")
            {
                Console.WriteLine("You have cool last name.");
            }
            else if (firstName.ToLower() == "tim")
            {
                Console.WriteLine("You have cool first name.");
            }
            else
            {
                Console.WriteLine("You don't have cool name.");
            }

            if (firstName.ToLower() == "tim")
            {
                Console.WriteLine("You have cool first name.");
            }
            if (lastName.ToLower() == "corey") //not connected with upper IF
            {
                Console.WriteLine("You have cool last name.");
            }
            else
            {
                Console.WriteLine("You don't have cool name.");
            }

            Console.WriteLine("This is " +
                "Multi line" +
                "text.");

            int age = 100;

            if (age > 100)
            {
                Console.WriteLine("You are older than me.");
            }
            else if (age <= 100)
            {
                Console.WriteLine("You are younger tahn me.");
            }
            else if (age >= 40 && age < 50) //range between 40 and 50 not including 50
            {
                Console.WriteLine("You are in your 40's.");
            }
            else if (age != 21) //not equal
            {
                Console.WriteLine("You aren't a great age.");
            }
            // ==, <, <=, >, >=, !=, && AND, || OR
        }
    }
}
