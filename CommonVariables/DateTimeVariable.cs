using System.Globalization;

namespace CommonVariables
{
    internal class DateTimeVariable
    {

        public DateTimeVariable()
        {
            DateTime today= DateTime.Now;

            Console.WriteLine(today); // Standard format
            Console.WriteLine(today.ToString("d")); //Short date
            Console.WriteLine(today.ToString("f")); //Full short date/time
            Console.WriteLine(today.ToString("t")); //Short time

            Console.WriteLine(today.ToString("u"));

            DateTime birthDay = DateTime.Parse("1980.01.18");
            Console.WriteLine(birthDay.ToString());

            birthDay = DateTime.ParseExact("01.18.1980", "MM.dd.yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine($"Birthday: {birthDay.ToString()}");


            
        }
    }
}
