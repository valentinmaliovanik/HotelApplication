using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    internal class Hotel
    {
       public List<Room> rooms = new List<Room>();
       private DateTime currentDate = DateTime.Now;
         
        public Hotel()
        {
            AddRoom();
            AddDay();
        }
        public void AddDay()
        {
            currentDate = currentDate.AddDays(1);
        }
        public void NumberOffRooms()
        {
            Console.WriteLine("В гостинице :" + rooms.Count + " номеров.");
            foreach(var room in rooms)
            {
                Console.WriteLine("Количество мест :"+ room.IdRoom+ "  Номер комнаты :"+room.NumberRoom);
            }

        }

        public void RoomFree()
        {
            UnloadingNumbers();

            foreach (var room in rooms)
            {
                if (room.Reservation )
                {
                    Console.WriteLine("Свободные номера: " + room.NumberRoom);
                }
            }
        }

        public void RoomNotFree()
        {
            foreach (var room in rooms)
            {
                if (!room.Reservation )
                {
                    Console.WriteLine("Зарезервированый номер: " + room.NumberRoom);
                    Console.WriteLine("Номер зарезервирован на имя: " + room.Client.FistName+ " " + room.Client.SecondName );
                    Console.WriteLine("Номер забронирован с :"+room.StartDate+" по "+ room.FinalDate );
                }
            }
        }

        public void ReservationForRoom()
        {
            int numberRoom ;
            int numberTelephone ;
            string fistName;
            string secondName;
            
            Console.WriteLine("Какой номер вы хотите забронировать ?");
            bool resault = int.TryParse(Console.ReadLine(), out numberRoom);
            if (!resault)
            {
                Console.WriteLine("Вы ввели некоректные даные");
                return;
            }

            Console.WriteLine("Введите номер телефона клиента :");
            bool resault2 = int.TryParse(Console.ReadLine(), out numberTelephone);
            if (!resault2)
            {
                Console.WriteLine("Вы ввели некоректные даные");
                return;
            }

            Console.WriteLine("Введите имя клиента");
            fistName = Console.ReadLine();

            Console.WriteLine("Введите фамилию клиента");
            secondName = Console.ReadLine();

            Console.WriteLine("На какую дату вы хотите забронировать номер :  ");
            Console.WriteLine("Введите год:");
            int Year;
            bool resault3 = int.TryParse(Console.ReadLine(), out Year);
            if (!resault3)
            {
                Console.WriteLine("Вы ввели некоректные даные");
                return;
            }

            Console.WriteLine("Введите месяц:");
            int Month;
            bool resault4 = int.TryParse(Console.ReadLine(), out Month);
            if (!resault4)
            {
                Console.WriteLine("Вы ввели некоректные даные");
                return;
            }

            Console.WriteLine("Введите день:");
            int Day;
            bool resault5 = int.TryParse(Console.ReadLine(), out Day);
            if (!resault5)
            {
                Console.WriteLine("Вы ввели некоректные даные");
                return;
            }

            Console.WriteLine("До кокого числа вы хотите забронировать номер? :");
            Console.WriteLine("Введите год:");
            int Year1;
            bool resault6 = int.TryParse(Console.ReadLine(), out Year1);
            if (!resault6)
            {
                Console.WriteLine("Вы ввели некоректные даные");
                return;
            }

            Console.WriteLine("Введите месяц:");
            int Month1;
            bool resault7 = int.TryParse(Console.ReadLine(), out Month1);
            if (!resault7)
            {
                Console.WriteLine("Вы ввели некоректные даные");
                return;
            }

            Console.WriteLine("Введите день:");
            int Day1;
            bool resault8 = int.TryParse(Console.ReadLine(), out Day1);
            if (!resault8)
            {
                Console.WriteLine("Вы ввели некоректные даные");
                return;
            }


            foreach (var room in rooms)
            {
                if(room.NumberRoom == numberRoom)
                {
                    room.Reservation = false;
                    room.Client = new Client(numberTelephone,fistName,secondName);
                    room.StartDate = new DateTime(Year, Month, Day);
                    room.FinalDate = new DateTime(Year1, Month1, Day1);
                }
            }

        }

        public void AddRoom()
        {
            Room room1 = new Room(1, 1,true);
            Room room2 = new Room(2, 1, true);
            Room room3 = new Room(3, 1, true);
            Room room4 = new Room(4, 1, true);
            Room room5 = new Room(5, 1, true);
            Room room6 = new Room(6, 2 , true);
            Room room7 = new Room(7, 2, true);
            Room room8 = new Room(8, 2, true);
            Room room9 = new Room(9, 2, true);
            Room room10 = new Room(10, 2, true);
            Room room11 = new Room(11, 3, true);
            Room room12 = new Room(12, 3, true);
            Room room13 = new Room(13, 3, true);
            Room room14 = new Room(14, 3, true);
            Room room15 = new Room(15, 3, true);

            rooms.Add(room1);
            rooms.Add(room2);
            rooms.Add(room3);
            rooms.Add(room4);
            rooms.Add(room5);
            rooms.Add(room6);
            rooms.Add(room7);
            rooms.Add(room8);
            rooms.Add(room9);
            rooms.Add(room10);
            rooms.Add(room11);
            rooms.Add(room12);
            rooms.Add(room13);
            rooms.Add(room14);
            rooms.Add(room15);
            
            
        }

        public void UnloadingNumbers()
        {
            foreach(var Date in rooms)
            {
                if(Date.FinalDate<= currentDate)
                {
                    Date.Reservation = true;
                }
            }
        }

        public void FreeRoomsToDate()
        {
            Console.WriteLine("На каккую дату вы хотите забронировать номер ?");
           
            Console.WriteLine("Введите год");
            int Year = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Введите месяц");
            int Month = int.Parse(Console.ReadLine());
           
            Console.WriteLine("Введите день");
            int Day = int.Parse(Console.ReadLine());
           
            DateTime dateTime = new DateTime(Year, Month, Day);
            Console.WriteLine("Свободніе нномера на эту дату : ");

            foreach (var date in rooms)
            {

                if (date.FinalDate <= dateTime)
                {
                    Console.WriteLine(date.NumberRoom);
                }
            }
        }

        public void ToCancelReservation()
        {
            Console.WriteLine("Какой номер вы хотите разбронировать ? ");
            int NumberRoom = int.Parse(Console.ReadLine());
            foreach(var number in rooms)
            {
                if (number.NumberRoom == NumberRoom)
                {
                    number.Reservation = true;
                }
            }
            Console.WriteLine("Бронь снята))");
        }
    }
    
    
}
