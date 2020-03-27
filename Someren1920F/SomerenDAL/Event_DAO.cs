using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomerenModel;

namespace SomerenDAL
{
    public class Event_DAO : Base
    {
        public List<Event> GetAllEventsBeween(DateTime begindate, DateTime enddate)
        {
            List<Event> le = new List<Event>();
            SqlParameter sqlParameter1 = new SqlParameter("@beginDate", begindate);
            SqlParameter sqlParameter2 = new SqlParameter("@endDate", enddate);
            SqlParameter[] sqlp = new SqlParameter[] { sqlParameter1, sqlParameter2 };

            return ReadTables(ExecuteSelectQuery("GetAllEventsBetween", sqlp));
        }

        private List<Event> ReadTables(DataTable dt)
        {
            List<Event> events = new List<Event>();

            foreach(DataRow dr in dt.Rows)
            {
                int eid = (int)dr["EventId"];
                DateTime date = (DateTime)dr["Date"];
                string desc = (string)dr["Description"];
                string actname = (string)dr["Name"];
                int supid = (int)dr["PersonId"];
                Event e = new Event(eid, date, desc, supid, actname);
                events.Add(e);
            }

            return events;    
        }
    }
}
