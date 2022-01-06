using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject_GuestBook
{
    public static class GuestBook
    {
        public static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to the Geust Book app.");
        }

        public static void PrintMainMenu()
        {
            Console.WriteLine("1. Enter new gues");
            Console.WriteLine("2. Print guest list");
            Console.WriteLine("3. EXIT");
        }

        public static (string guestName, int partyCount) GetNewGuest()
        {
            string guestName = "";
            int partyCount = 0;

            do
            {
                Console.Write("Enter guest name: ");
                guestName = Console.ReadLine() ?? "";
                if (guestName == "")
                {
                    Console.WriteLine("Guest name can't be empty. Please enter valid name.");
                }
            } while (guestName.Length == 0);


            do
            {
                Console.Write("Enter party count: ");
                string countText = Console.ReadLine();
                if (int.TryParse(countText, out partyCount))
                {
                    if (partyCount <= 0)
                    {
                        Console.WriteLine("Party count must be higher than 0.");
                        continue;
                    }
                    return (guestName ?? "", partyCount);
                }
                Console.WriteLine("Wrong number value. Please enter again.");
            } while (true);


        }

        public static void PrintGuestList(List<(string guestName, int countParty)> guestList)
        {
            int total = 0;
            int i = 1;
            Console.WriteLine("Gest list:");
            foreach (var item in guestList)
            {
                Console.WriteLine($"{i} - {item.guestName}");
                total += item.countParty;
                i++;
            }
            Console.WriteLine($"Total guests number: {total}");
            Console.WriteLine("Pres any key to continue.");
            Console.ReadLine();
        }

        public static string DoYouWantToContinue()
        {
            Console.WriteLine("Do you want to continue? Y/N");
            return Console.ReadLine() ?? "N";
        }
    }
}
