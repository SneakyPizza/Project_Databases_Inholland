using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Room
    {
        public Room(int roomID, string roomType, int capacity)
        {
            RoomID = roomID;
            RoomType = roomType;
            Capacity = capacity;

        }

        public int RoomID { get; set; } 
        public string RoomType { get; set; }
        public int Capacity { get; set; } // number of beds, either 4,6,8,12 or 16


    }
}
