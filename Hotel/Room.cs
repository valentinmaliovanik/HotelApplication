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
        public Room(int _number, int _idRoom )
        {
            IdRoom = _idRoom;
            NumberRoom = _number;
            Reservation = false; 
        }
        
        public void InRoom()
        {
            Console.WriteLine("Количество мест :" + IdRoom + "  Номер комнаты :" + NumberRoom);
        }

        public void RoomNotReservation() 
        { 
            if(!Reservation ) 
            {
                Console.WriteLine("Свободные номера: " + NumberRoom);
            }
        }

        public void RoomReservation()
        {
            if (Reservation)
            {
                Console.WriteLine("Зарезервированый номер: " + NumberRoom);
                Console.WriteLine("Номер зарезервирован на имя: " + Client.FistName + " " + Client.SecondName);
                Console.WriteLine("Номер забронирован с :" + StartDate + " по " + FinalDate);
            }            
        }

        public void Reserve()
        {
            int telephoneNumb = ParseInt("Ведите номер телефона клиента : ");

            Console.WriteLine("Ведите имя клиента : ");           
            string nameClient = Console.ReadLine();

            Console.WriteLine("Введите фамилию клиента : ");           
            string secondNameClient = Console.ReadLine();

            Console.WriteLine("На какую дату вы хотите забронировать номер?");
            int year = ParseInt("Введите год : ");
            int month = ParseInt("Введите месяц : ");
            int day =ParseInt("Введите день : ");

            Console.WriteLine("До какой даты вы хотите забронировать номер?");
            int year2 = ParseInt("Введите год : ");
            int month1 = ParseInt("Введите месяц : ");
            int day2 = ParseInt("Введите день : ");

            Reservation = false;
            Client  = new Client(telephoneNumb, nameClient, secondNameClient);
            StartDate  = new DateTime (year, month, day);
            FinalDate  = new DateTime (year2, month1, day2);
        }

        public int ParseInt(string message)
        {
            while (true)
            {
                Console.WriteLine(message);
                bool resault = int.TryParse(Console.ReadLine(), out int number);
                if (!resault)
                {
                    Console.WriteLine("Вы ввели некоректные даные");
                }
                if (resault)
                {
                    return number;
                }
            }
        }
    }
}
