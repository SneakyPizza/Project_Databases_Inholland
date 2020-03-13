﻿using SomerenDAL;
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
        Student_DAO students_db = new Student_DAO();
        

        public List<Student> GetStudents()
        {
            try
            {
                List<Student> student = students_db.Db_Get_All_Students();
                return student;
            }
            catch (Exception e)
            {
                // something went wrong connecting to the database, so we will add a fake student to the list to make sure the rest of the application continues working!
                List<Student> student = new List<Student>();
                Student a = new Student(1, "Test", "111111@student.inholland.nl", "0612345678", "0", 0);
                student.Add(a);
                return student;
                
                //throw new Exception("Someren couldn't connect to the database");
                
            }
        }
    }
}
