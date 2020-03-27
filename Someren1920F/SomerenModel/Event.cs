using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Event
    {
        public Event(int eventId, DateTime eventDate, string eventDescription, int supervisorId, string activityName)
        {
            EventId = eventId;
            EventDate = eventDate;
            EventDescription = eventDescription;
            EventSuperVisorId = supervisorId;
            ActivityName = activityName;
        }

        public int EventId { get; private set; }
        public DateTime EventDate { get; private set; }
        public string EventDescription { get; private set; }
        public int  EventSuperVisorId { get; private set; }
        public string ActivityName { get; private set; }
    }
}
