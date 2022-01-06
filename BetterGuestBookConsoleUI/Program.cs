using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuestBookLibrary.Models;

namespace BetterGuestBookConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Loop until no more guests
            //Get data from console
            //  Get FirstName, LastName, NumberOfAdoults, NumberOfChildrens
            //Check is there more guests (y/n)
            //  y = true; n or any key is false

            //Print data to console
            //  Print guest list: FirstName LastName NumberInGroup
            //  Print totals: Total guest number, Total adoults, Total childrens

            List<GuestModel> guests = new List<GuestModel>();
           GuestData guestData = new GuestData();

            GetGuestList(guests);
            PrintGuestList(guests);
            PrintTotals(guests);
            Console.ReadLine();
        }

        public static void GetGuestList(List<GuestModel> guests)
        {
            GuestData guestData = new GuestData();
            bool nextGuest;
            do
            {
                guests.Add(guestData.GetGuestData());
                nextGuest = ConsoleData.GetBool("Is there more guests? (y/n): ", "y");
                Console.Clear();
            } while (nextGuest);
        }

        public static void PrintGuestList(List<GuestModel> guests)
        {
            Console.WriteLine("Guest list:");
            foreach (GuestModel guest in guests)
            {
                Console.WriteLine(guest.GuestInfo);
            }
            Console.WriteLine();
        }

        public static void PrintTotals(List<GuestModel> guests)
        {
            Console.WriteLine();
            Console.WriteLine("TOTALS:");
            Console.WriteLine($"Total adults: {guests.Sum(x => x.NumberOfAdults)}");
            Console.WriteLine($"Total childrens: {guests.Sum(x => x.NumberOfChildrens)}");
            Console.WriteLine("______________________");
            Console.WriteLine($"Total guests: {guests.Sum(x => x.NumberOfChildrens + x.NumberOfAdults)}");
        }
    }
}
