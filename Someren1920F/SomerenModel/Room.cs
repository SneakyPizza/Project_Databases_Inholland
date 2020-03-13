using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Room
    {
        public Room(int roomID, int capacity, string roomType)
        {
            RoomID = roomID;
            Capacity = capacity;
            RoomType = roomType;
        }

        public int RoomID { get; set; } 
        public int Capacity { get; set;  } // number of beds, either 4,6,8,12 or 16
        public string RoomType { get; set; }

    }
}
