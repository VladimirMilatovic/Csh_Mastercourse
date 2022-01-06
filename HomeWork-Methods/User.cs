using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_Methods
{
    public static class User
    {
        public static void Welcom()
        {
            Console.WriteLine("Welcom to the user portal.");
        }

        public static string GetName()
        {
            Console.Write("Please enter your name: ");
            return Console.ReadLine() ?? "";
        }

        public static void GreatingMEssage(string name)
        {
            Console.WriteLine($"Hello {name}");
        }
    }
}
