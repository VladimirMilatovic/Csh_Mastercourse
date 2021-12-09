using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonVariables
{
    internal class StringVariable
    {   //Definition of Empty string
        string emptyString = string.Empty;

        //String with no content
        string noContent = "";


        //camel Case for local variable; 
        string localVariable = string.Empty;
        //local Read only variable
        private readonly string _variableName;
        //Pascal case for properties;
        public string ThisIsPropertie { get; set; }

        //Large variable name dont have impact on performance
        string vlariableWithVeryLongNameThatHaveNoImpactToAppPerformance;

        //Name variables clear and understandable. 
        string fName; //What this mean??? FullName or FirstName or ...

        string firstName = "Initial value";
        string lastName = string.Empty;
        string filePath = string.Empty;

       

        public StringVariable()
        {
            firstName = "Vlado";
            //firstName = "123";
            lastName = "Mmilatovic";
            filePath = "C:\\Temp\\Demo"; // \ special carracter must be escaped; must us \\, first \ is escape caracter, next \ is special caracter
            filePath = @"C:\Temp\Demo"; // @ symbol create literal string with no special caracters. 

            string mixLiteralAndInterpolation = $@"The file for {firstName} {lastName} is C:\Temp\{firstName}.txt";

            Console.WriteLine(firstName + lastName); //connect two strings OUTPUT: VladoMilatovic
            Console.WriteLine(firstName + " " + lastName); //connect two strings with space OUTPUT: Vlado Milatovic
            Console.WriteLine($"Hello {firstName} {lastName}"); //Connect strings - String interpolation OUTPUT: Hello Vlado Milatovic
            Console.WriteLine(filePath);
            Console.WriteLine(mixLiteralAndInterpolation);
        }
    }
}
