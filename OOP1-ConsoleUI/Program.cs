﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1_ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your first name");

            PersonModel person = new PersonModel("Corey");

            person.FirstName = "Tim";
            //person.LastName = "Corey";
            person.Age = 40;
            person.SSN = "123-45-6789";

            Console.WriteLine(person.FullName);
            Console.WriteLine(person.SSN);

            Console.ReadLine();
        }
    }
}
