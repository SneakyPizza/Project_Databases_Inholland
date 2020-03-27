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
using System.Data.SqlTypes;

namespace SomerenDAL
{
    public class Event_DAO
    {
        public List<Event> Db_Get_All_Event()
        {

            return ReadTables(ExecuteSelectQuery("GetAllEvents"));
        }

        private List<Event> ReadTables(DataTable dataTable)
        {
            List<Event> events = new List<Event>();

            foreach (DataRow dr in dataTable.Rows)
            {
                int id = (int)dr["ProductID"];
                string name = (string)(dr["Name"].ToString());
                decimal price = (decimal)(dr["Price"]);
                int btw = (int)(dr["BTWPercentile"]);
                int amount = (int)dr["Amount"];
                string description = (string)(dr["Description"].ToString());
                Event eventt = new Event(id, name, price, btw, amount, description);
                events.Add(eventt);
            }
            return events;
        }
}
