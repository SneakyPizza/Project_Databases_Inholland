using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    class Event
    {
        public Event(int id, DateTime date, string description, int supervisorId, int activityId, int eventJunctionId)
        {
            ID = id;
            Date = date;
            Description = description;
            SupervisorId = supervisorId;
            ActivityId = activityId;
            EventJunctionId = eventJunctionId;

        }

        public int ID { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public int SupervisorId { get; set; }
        public int ActivityId { get; set; }
        public int EventJunctionId { get; set; }
    }
}
