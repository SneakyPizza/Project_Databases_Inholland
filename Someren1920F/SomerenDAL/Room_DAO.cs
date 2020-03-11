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
        private SqlConnection dbConnection;

        public Room_DAO()
        {
            string connString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
            dbConnection = new SqlConnection(connString);
        }

        public List<Room> Db_Get_All_Rooms()
        {
            dbConnection.Open();
            SqlCommand cmd = new SqlCommand("GetAllRooms", dbConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@RoomCapacity", 16);
            SqlDataReader reader = cmd.ExecuteReader();
            List<Room> rooms = new List<Room>();
            while (reader.Read())
            {
                Room room = ReadRoom(reader);
                rooms.Add(room);
            }
            reader.Close();
            dbConnection.Close();
            return rooms;
        }
        public Room ReadRoom(SqlDataReader reader)
        {
            int RoomID = (int)reader["RoomID"];
            string RoomType = (string)reader["RoomType"];
            int Capacity = (int)reader["RoomCapacity"];
            return new Room(RoomID, RoomType, Capacity);
        }

    }
}
