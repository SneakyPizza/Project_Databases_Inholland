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
    public class Teacher_DAO : Base
    {
        private SqlConnection dbConnection;

        public Teacher_DAO()
        {
            string connString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
            dbConnection = new SqlConnection(connString);
        }

        public List<Teacher> Db_Get_All_Teachers()// RoleID for teachers = 1
        {
            dbConnection.Open();
            SqlCommand cmd = new SqlCommand("GetAllPersonInfo", dbConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@RoleID", 1);

            SqlDataReader reader = cmd.ExecuteReader();
            List<Teacher> teachers = new List<Teacher>();
            while (reader.Read())
            {
                Teacher teacher = ReadTeacher(reader);
                teachers.Add(teacher);
            }
            reader.Close();
            dbConnection.Close();
            return teachers;
        }
        public Teacher ReadTeacher(SqlDataReader reader)
        {
            int StudentID = (int)reader["CustomerID"];
            string FirstName = (string)reader["FirstName"];
            string LastName = (string)reader["LastName"];
            string EmailAddress = (string)reader["EmailAddress"];
            string PhoneNumber = (string)reader["PhoneNumber"];
            int Role = (int)reader["Role"];
            return new Teacher(StudentID, FirstName, LastName, EmailAddress, PhoneNumber, Role);
        }

    }
}
