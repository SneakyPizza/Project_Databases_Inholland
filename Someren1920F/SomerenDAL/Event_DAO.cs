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
    public class Event_DAO : Base
    {
        public List<Event> Db_GetAllEvents()
        {
            return ReadTables(ExecuteSelectQuery("GetAllEvents"));
        }

        private List<Event> ReadTables(DataTable dataTable)
        {
            List<Event> events = new List<Event>();

            foreach (DataRow dr in dataTable.Rows)
            {
                int id = (int)dr["ProductID"];
                DateTime date = (DateTime)(dr["Date"]);
                string description = (string)(dr["Description"].ToString());
                int supervisorId = (int)dr["SuperVisorID"];
                int activityId = (int)dr["ActivityID"];
                int eventJunctionId = (int)dr["EventJunctionID"];
                Event eventt = new Event(id, date, description, supervisorId, activityId, eventJunctionId);
                events.Add(eventt);
            }
            return events;
        }
    }
}