using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Collections.ObjectModel;
using SomerenModel;

namespace SomerenDAL
{
    public class Room_DAO : Base
    {
        public List<Room> Db_Get_All_Rooms()
        {
            SqlParameter sqlParameter = new SqlParameter("@RoomCapacity", 16);
            SqlParameter[] sqlp = new SqlParameter[] { sqlParameter };
            return ReadTables(ExecuteSelectQuery("GetAllRooms", sqlp));
        }

        private List<Room> ReadTables(DataTable dataTable)
        {
            List<Room> rooms = new List<Room>();

            foreach (DataRow dr in dataTable.Rows)
            {
                int id = (int)dr["RoomID"];
                string roomtype = (String)(dr["RoomType"].ToString());
                int capacity = (int)(dr["RoomCapacity"]);
                Room room = new Room(id, roomtype, capacity);
                rooms.Add(room);
            }
            return rooms;
        }
    }
}
