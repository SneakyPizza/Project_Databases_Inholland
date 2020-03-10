using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlTypes;

namespace SomerenModel
{
    public class Student
    {
        public Student(int studentID, string firstName, string lastName, string emailAddress, string phoneNumber, int role)
        {
            StudentID = studentID;
            FirstName = firstName;
            LastName = lastName;
            EmailAddress = emailAddress;
            PhoneNumber = phoneNumber;
            Role = role;
        }

        public int StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public int Role { get; set; } // student 0, docent 1

    }
}
