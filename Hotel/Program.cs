using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hotel hotel = new Hotel();
            
            while (true)
            {
                hotel.AddDay();
                Console.WriteLine();
                Console.WriteLine(" Виберите действие : ");
                Console.WriteLine(" Количество номеров - 1 ");
                Console.WriteLine(" Показать свободные номера - 2 ");
                Console.WriteLine(" Показать забронированые номера - 3 ");               
                Console.WriteLine(" Забронювати номер -- натисніть 4 ");
                Console.WriteLine(" Свободные номера на определенную дату 5 ");
                Console.WriteLine(" Снять бронь 6 ");

                int action = int.Parse(Console.ReadLine());
                switch (action)
                {
                    case 1:
                        hotel.NumberOffRooms();
                        break;
                    case 2:
                        hotel.RoomFree();
                        break;
                    case 3:
                        hotel.RoomNotFree();
                        break;
                    case 4:
                        hotel.ReservationForRoom();
                        break;
                    case 5:
                        hotel.FreeRoomsToDate();
                        break;
                    case 6:
                        hotel.ToCancelReservation();
                        break;

                        default:
                        Console.WriteLine("Вы ввели некоректные даные");
                        break;
                }

            }


        }
    }
}
