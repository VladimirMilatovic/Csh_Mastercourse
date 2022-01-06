
using MiniProject_GuestBook;



bool exit = false;
string option = "0";
List<(string guestName, int countParty)> GuestList = new();
do
{
    //Run option menu
    Console.Clear();
    GuestBook.WelcomeMessage();
    GuestBook.PrintMainMenu();
    option = Console.ReadLine() ?? "";
    switch (option)
    {
        case "1":
            do
            {
                GuestList.Add(GuestBook.GetNewGuest());
            } while (GuestBook.DoYouWantToContinue().ToLower() != "n");
            break;
        case "2":
            GuestBook.PrintGuestList(GuestList);
            break;
        case "3":
            exit = true;
            break;
        default:
            Console.WriteLine("Wrong option");
            break;
    }
} while (!exit);
