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
    public class Teacher_Service
    {
        Teacher_DAO teacher_db = new Teacher_DAO();

        public List<Teacher> GetTeachers()
        {
            try
            {
                return teacher_db.Db_Get_All_Teachers();
            }
            catch (Exception e)
            {
                // something went wrong connecting to the database, so we will add a fake student to the list to make sure the rest of the application continues working!
                List<Teacher> teacher = new List<Teacher>();
                Teacher a = new Teacher(1, "Test", "Teacher", "691420@inholland.nl", "0612345678");
                teacher.Add(a);
                return teacher;
                throw;
                //throw new Exception("Someren couldn't connect to the database");

            }


        }
    }
}
