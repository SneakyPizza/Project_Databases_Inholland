using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Supervisor
    {
        public Supervisor(int id, int TeacherId , int activityId)
        {
            EventJunctionID = id;
            PersonId = TeacherId;
            ActivityId = activityId;
        }

        public int EventJunctionID { get; set; }
        public int PersonId { get; set; }
        public int ActivityId { get; set; }
    }
}
