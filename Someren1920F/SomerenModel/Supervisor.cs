using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Supervisor : Teacher
    {
        public Supervisor(int id, string firstname, string lastname, string email, string phonenumber, int supervisorId): base(id, firstname, lastname, email, phonenumber)
        {
            SupervisorId = supervisorId;
        }

        public int SupervisorId { get; private set; }
    }
}
