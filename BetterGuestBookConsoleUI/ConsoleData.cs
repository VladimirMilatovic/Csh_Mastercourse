using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetterGuestBookConsoleUI
{
    public static class ConsoleData
    {
        public static string GetString(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }
        public static bool GetBool(string message, string TrueAnswer)
        {
            bool output = false;
            if (GetString(message).ToLower() == TrueAnswer)
            {
                output = true;
            }
            return output;
        }
        public static int GetInt(string message)
        {
            int output;
            if (int.TryParse(GetString(message), out output))
            {
                return output;
            }
            else
            {
                return 0;
            }
        }


    }
}
