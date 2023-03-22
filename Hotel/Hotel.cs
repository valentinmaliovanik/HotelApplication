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
            Console.WriteLine("В гостинице : " + rooms.Count + " номеров.");
            foreach(var room in rooms)
            {
                room.InRoom();
            }

        }

        public void RoomFree()
        {
            UnloadingNumbers();
            
            foreach (var room in rooms)
            {
                room.RoomNotReservation();
            }
        }

        public void RoomNotFree()
        {
            bool resault = false;
            foreach (var room in rooms)
            {
                room.RoomReservation();
                if (room.Reservation == false)
                {
                    resault = true;
                }
            }       
                
                if (resault == false)
                {
                    Console.WriteLine("В отеле нет забронированых номеров!!!");
                }

            
        }

        public void ReservationForRoom()
        {
            Console.WriteLine("Введите номер комнаты : ");
            int number = int.Parse(Console.ReadLine()); 
            foreach(var room in rooms)
            {
                if(room.NumberRoom == number)
                {
                    if (!room.Reservation )
                    {
                        Console.WriteLine("Этот номер уже забронирован !!!");
                        return;
                    }
                    else
                    {
                        room.Reserve();
                    }

                     
                }

            }
          
        }

        public void AddRoom()
        {
           
            int b = 1;
            for (int i = 1; i <=15; i++)
            {
                if (i > 5)
                {
                    b=2;                    
                }
                if (i >= 10)
                {
                    b =3;
                }

                rooms.Add(new Room(i, b));
            }                   
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
