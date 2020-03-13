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
    public class Student_Service
    {
        Student_DAO student_db = new Student_DAO();
        Teacher_DAO teacher_db = new Teacher_DAO();
        Room_DAO room_db = new Room_DAO();

        public List<Student> GetStudents()
        {
            try
            {
                List<Student> student = student_db.Db_Get_All_Students();
                return student;
            }
            catch (Exception e)
            {
                // something went wrong connecting to the database, so we will add a fake student to the list to make sure the rest of the application continues working!
                List<Student> student = new List<Student>();
                Student a = new Student(1, "Test", "Student", "111111@student.inholland.nl", "0612345678", 0);
                student.Add(a);
                return student;
                throw;
                //throw new Exception("Someren couldn't connect to the database");
                
            }
            

        }

        public List<Teacher> GetTeachers()
        {
            try
            {
                List<Teacher> teacher = teacher_db.Db_Get_All_Teachers();
                return teacher;
            }
            catch (Exception e)
            {
                // something went wrong connecting to the database, so we will add a fake student to the list to make sure the rest of the application continues working!
                List<Teacher> teacher = new List<Teacher>();
                Teacher a = new Teacher(1, "Test", "Teacher", "691420@inholland.nl", "0612345678", 0);
                teacher.Add(a);
                return teacher;
                throw;
                //throw new Exception("Someren couldn't connect to the database");

            }


        }

        public List<Room> GetRoom()
        {
            try
            {
                List<Room> room = room_db.Db_Get_All_Rooms();
                return room;
            }
            catch (Exception e)
            {
                // something went wrong connecting to the database, so we will add a fake student to the list to make sure the rest of the application continues working!
                List<Room> room = new List<Room>();
                Room a = new Room(69420, 6, "Grote kamer");
                room.Add(a);
                return room;
                throw;
                //throw new Exception("Someren couldn't connect to the database");

            }


        }
    }
}
