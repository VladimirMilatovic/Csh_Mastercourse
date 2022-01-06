using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1_ConsoleUI
{
    public class AddressModel
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }

        public string FullAddress
        {
            get
            {
                return $"{Street} {City} {ZipCode}";
            }
        }
    }
}
