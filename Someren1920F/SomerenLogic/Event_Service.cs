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


        public List<Event> GetEvents()
        {
            try
            {
                return event_db.Db_GetAllEvents();
            }
            catch (Exception e)
            {
                // something went wrong connecting to the database, so we will add a fake student to the list to make sure the rest of the application continues working!
                List<Event> eventt = new List<Event>();
                Event a = new Event(99, DateTime.Now, "Something went wrong in the database.", 1, 1, 1);

                eventt.Add(a);
                return eventt;
                throw;
                //throw new Exception("Someren couldn't connect to the database");
            }
        }
    }
}
