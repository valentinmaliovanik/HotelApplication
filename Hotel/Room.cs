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
        public Room(int number, int idRoom )
        {
            IdRoom = idRoom;
            NumberRoom = number;
            Reservation = true; 
        }
        
        public void InRoom()
        {
            Console.WriteLine("Количество мест :" + IdRoom + "  Номер комнаты :" + NumberRoom);
        }

        public void RoomNotReservation() 
        { 
            if(Reservation ) 
            {
                Console.WriteLine("Свободные номера: " + NumberRoom);
            }
        }

        public void RoomReservation()
        {
            if (!Reservation)
            {
                Console.WriteLine("Зарезервированый номер: " + NumberRoom);
                Console.WriteLine("Номер зарезервирован на имя: " + Client.FistName + " " + Client.SecondName);
                Console.WriteLine("Номер забронирован с :" + StartDate + " по " + FinalDate);
            }
        }
    }

}
