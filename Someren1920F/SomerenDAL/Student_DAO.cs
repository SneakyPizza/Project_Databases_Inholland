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
        public List<Student> Db_Get_All_Students()
        {
            string query = "GetAllPersonInfo";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Student> ReadTables(DataTable dataTable)
        {
            List<Student> students = new List<Student>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Student student = new Student()
                {
                    StudentID = (int)dr["PersonID"],
                    FirstName = (String)(dr["Firstname"].ToString()),
                    LastName = (String)(dr["Lastname"].ToString()),
                    EmailAddress = (String)(dr["Email"].ToString()),
                    PhoneNumber = (String)(dr["Phonenumber"].ToString()),
                    Role = (int)dr["Role"]
                };
                students.Add(student);
            }
            return students;
        }
    }
}
