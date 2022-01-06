using GuestBookLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetterGuestBookConsoleUI
{
    public class GuestData
    {
        public GuestModel GetGuestData()
        {
            GuestModel guest = new GuestModel();
            guest.FirstName = ConsoleData.GetString("First name: ");
            guest.LastName = ConsoleData.GetString("Last name: ");
            guest.NumberOfAdults = ConsoleData.GetInt("Number of adults in group: ");
            guest.NumberOfChildrens = ConsoleData.GetInt("Number of childrens in group: ");

            return guest;
        }


    }
}
