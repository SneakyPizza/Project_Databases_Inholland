using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Supervisor
    {

        public Supervisor(int id, string firstname, string lastname, string email, string phonenumber)
        {
            SupervisorID = id;
            FirstName = firstname;
            LastName = lastname;
            EmailAddress = email;
            PhoneNumber = phonenumber;
        }

        public int SupervisorID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }

        public override string ToString()
        {
            return string.Format("{0}. {1} {2} (Email: {3})", SupervisorID, FirstName, LastName, EmailAddress);
        }
        /*
        public Supervisor(int id, int TeacherId , int activityId)
        {
            EventJunctionID = id;
            PersonId = TeacherId;
            ActivityId = activityId;
        }

        public int EventJunctionID { get; set; }
        public int PersonId { get; set; }
        public int ActivityId { get; set; }
        */
    }
}
