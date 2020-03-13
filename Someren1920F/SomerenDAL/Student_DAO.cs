using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Collections.ObjectModel;
using SomerenModel;

namespace SomerenDAL
{
    public class Student_DAO : Base
    {
        private SqlConnection dbConnection;

        public Student_DAO()
        {
            /*          
            string connString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
            dbConnection = new SqlConnection(connString);
            */
        }
      
        public List<Student> Db_Get_All_Students()
        {
            dbConnection.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Person WHERE Role = 0", dbConnection);
            SqlDataReader reader = cmd.ExecuteReader();
            List<Student> students = new List<Student>();
            while (reader.Read())
            {
                Student student = ReadStudent(reader);
                students.Add(student);
            }
            reader.Close();
            dbConnection.Close();
            return students;
        }
        public Student ReadStudent(SqlDataReader reader)
        {
            int StudentID = (int)reader["CustomerID"];
            string FirstName = (string)reader["FirstName"];
            string LastName = (string)reader["LastName"];
            string EmailAddress = (string)reader["EmailAddress"];
            string PhoneNumber = (string)reader["PhoneNumber"];
            int Role = (int)reader["Role"];
            return new Student(StudentID, FirstName, LastName, EmailAddress, PhoneNumber, Role);
        }

    }
}
