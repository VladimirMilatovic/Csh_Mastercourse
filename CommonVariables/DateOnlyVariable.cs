using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonVariables
{
    internal class DateOnlyVariable
    {
        public DateOnlyVariable()
        {
            DateOnly birthDate = DateOnly.Parse("08.01.1980");
            Console.WriteLine($"Birthdate: {birthDate}");
            
            DateOnly date = DateOnly.FromDateTime(DateTime.Now);
            Console.WriteLine(date);


            DateOnly today = DateOnly.Parse(DateTime.Now.Date.ToString("d"));
            Console.WriteLine($"Today: {today}");



        }
    }
}
