using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Room
    {
        public Room(int id, string roomtype, int capacity)
        {
            RoomID = id;
            RoomType = roomtype;
            Capacity = capacity;
        }

        public int RoomID { get; set; } 
        public string RoomType { get; set; }
        public int Capacity { get; set; } // number of beds, either 4,6,8,12 or 16

        public override string ToString()
        {
            return string.Format("{0}. Roomtype:{1} (Capacity: {2})", RoomID, RoomType, Capacity);
        }

    }
}
