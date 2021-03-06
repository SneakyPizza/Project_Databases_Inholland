﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Teacher
    {
        public Teacher(int id, string firstname, string lastname, string email, string phonenumber)
        {
            TeacherID = id;
            FirstName = firstname;
            LastName = lastname;
            EmailAddress = email;
            PhoneNumber = phonenumber;
        }

        public int TeacherID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }

        public override string ToString()
        {
            return string.Format("{0}. {1} {2} (Email: {3})", TeacherID, FirstName, LastName, EmailAddress);
        }

    }
}
