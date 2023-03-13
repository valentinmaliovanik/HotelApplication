using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    public class Hotel
    {
        public List<Room> rooms { get; set; } = new List<Room>
        { 
            new Room {IdRoom = "Один" },
            new Room {IdRoom = "Два" },
            new Room {IdRoom = "Три" }
           

        };
        
        //public void AddRoom()
        //{
        //    Room room1 = new Room(1, 1, true);
        //    Room room2 = new Room(2, 1, true);
        //    Room room3 = new Room(3, 1, true);
        //    Room room4 = new Room(4, 1, true);
        //    Room room5 = new Room(5, 1, true);
        //    Room room6 = new Room(6, 2, true);
        //    Room room7 = new Room(7, 2, true);
        //    Room room8 = new Room(8, 2, true);
        //    Room room9 = new Room(9, 2, true);
        //    Room room10 = new Room(10, 2, true);
        //    Room room11 = new Room(11, 3, true);
        //    Room room12 = new Room(12, 3, true);
        //    Room room13 = new Room(13, 3, true);
        //    Room room14 = new Room(14, 3, true);
        //    Room room15 = new Room(15, 3, true);

        //    rooms.Add(room1);
        //    rooms.Add(room2);
        //    rooms.Add(room3);
        //    rooms.Add(room4);
        //    rooms.Add(room5);
        //    rooms.Add(room6);
        //    rooms.Add(room7);
        //    rooms.Add(room8);
        //    rooms.Add(room9);
        //    rooms.Add(room10);
        //    rooms.Add(room11);
        //    rooms.Add(room12);
        //    rooms.Add(room13);
        //    rooms.Add(room14);
        //    rooms.Add(room15);            
        //}

       
    }
}
