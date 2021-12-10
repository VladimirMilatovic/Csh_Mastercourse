using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonVariables
{
    internal class TimeOnlyVariable
    {
        public TimeOnlyVariable()
        {
            TimeOnly timeOnly;

            timeOnly = TimeOnly.Parse(DateTime.Now.TimeOfDay.ToString());
            Console.WriteLine(timeOnly);

            TimeOnly time = TimeOnly.FromDateTime(DateTime.Now);
            Console.WriteLine(time.ToString("HH:mm:ss"));

        }
    }
}
