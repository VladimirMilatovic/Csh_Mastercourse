using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals;

internal class BasicIf
{
    public BasicIf()
    {
        bool isComplete = false;

        if (isComplete)
        {
            Console.WriteLine("It is complete.");
        }
        else
        {
            Console.WriteLine("It is NOT complete.");
        }

        Console.Write("Enter your name: ");
        string? name = Console.ReadLine();

        //if (name == "Vlado") 
        //if (name.ToLower() == "vlado") name can be in mixed case
        if (name?.ToLower() == "vlado") //name can be NULL
        {
            Console.WriteLine("Hell Vlado");
        }
        else
        {
            Console.WriteLine($"Hello {name}");
        }

        Console.Write("Enter your age: ");
        string? ageText = Console.ReadLine();

        if (int.TryParse(ageText, out int age))
        {
            Console.WriteLine($"Your age will be {age + 15} after 15 years.");
        }
        else
        {
            Console.WriteLine("Wrong number format.");
        }
    }
}
