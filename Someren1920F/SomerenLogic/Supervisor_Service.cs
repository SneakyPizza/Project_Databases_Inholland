using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenLogic
{
    public class Supervisor_Service
    {
        Supervisor_DAO supervisor_db = new Supervisor_DAO();

        public List<Supervisor> GetSupervisors()
        {
            try
            {
                return supervisor_db.Db_Get_All_Supervisors();
            }
            catch (Exception e)
            {
                // something went wrong connecting to the database, so we will add a fake student to the list to make sure the rest of the application continues working!
                List<Supervisor> supervisor = new List<Supervisor>();
                Supervisor a = new Supervisor(1, "Test", "Teacher", "691420@inholland.nl", "0612345678");
                supervisor.Add(a);
                return supervisor;
                throw;
                //throw new Exception("Someren couldn't connect to the database");

            }


        }
    }
}