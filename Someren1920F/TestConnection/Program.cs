using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomerenDAL;
using SomerenModel;

namespace TestConnection
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();
        }
        void Start()
        {
            Student_DAO studentDAO = new Student_DAO();

            //display all students
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Displaying all students...");
            Console.ResetColor();

            List<Student> students = studentDAO.Db_Get_All_Students();
            foreach (Student student in students)
            {
                Console.WriteLine(student);
            }
            Console.ReadKey();
            //display all teachers
            Teacher_DAO teacherDAO = new Teacher_DAO();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Displaying all teachers...");
            Console.ResetColor();

            List<Teacher> teachers = teacherDAO.Db_Get_All_Teachers();
            foreach (Teacher teacher in teachers)
            {
                Console.WriteLine(teacher);
            }
            Console.ReadKey();
            //display all rooms
            Room_DAO roomDAO = new Room_DAO();

            //display all students
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Displaying all rooms...");
            Console.ResetColor();

            List<Room> rooms = roomDAO.Db_Get_All_Rooms();
            foreach (Room room in rooms)
            {
                Console.WriteLine(room);
            }
            Console.ReadKey();
        }
    }
}
