using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuestBookLibrary.Models
{
    public class GuestModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int NumberOfAdults { get; set; } = 0;
        public int NumberOfChildrens { get; set; } = 0;
        public string MessageToHost { get; set; }
        public string GuestInfo
        {
            get
            {
                return $"{FirstName} {LastName} - Total in group: {NumberOfAdults+ NumberOfChildrens}";
            }
        }
    }
}
