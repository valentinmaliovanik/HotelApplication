using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    internal class Room
    {
        public int IdRoom { get; set; }

        public int NumberRoom { get; set; }

        public bool Reservation { get; set; }
        public DateTime StartDate = DateTime.Now;
        public DateTime FinalDate = DateTime.Now;
        public Client Client { get; set; }
        public Room(int number, int idRoom, bool reservation)
        {
            IdRoom = idRoom;
            NumberRoom = number;
            Reservation = true; Reservation = reservation;

        }
        
    }
}
