using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomerenDAL;
using SomerenModel;

namespace SomerenLogic
{
    public class Event_Service
    {
        Event_DAO event_db = new Event_DAO();

        public List<Event> GetEvents(DateTime beginDate, DateTime endDate)
        {
            try
            {
                return event_db.GetAllEventsBeween(beginDate, endDate);
            }
            catch(Exception e)
            {
                List<Event> events = new List<Event>();
                Event a = new Event(1, DateTime.Now, e.Message, 1, e.Source);

                events.Add(a);
                return events;
                throw;
            }
        }
    }
}
