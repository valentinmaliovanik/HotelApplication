using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    internal class Client
    {
        public int TelephoneNumber { get; set; }

        public string FistName { get; set; }

        public string SecondName { get; set; }
        public Client(int telephoneNumber, string firstName,string secondNsme)
        {
                TelephoneNumber= telephoneNumber;
                FistName= firstName;
                SecondName= secondNsme;

        }
    }
}
