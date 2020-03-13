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
using System.Data.SqlTypes;

namespace SomerenDAL
{
    public class Student_DAO : Base
    {
        public List<Student> Db_Get_All_Students()
        {
            SqlParameter sqlParameter = new SqlParameter("@RoleID", 0);
            SqlParameter[] sqlp = new SqlParameter[] { sqlParameter };
            return ReadTables(ExecuteSelectQuery("GetAllPersonInfo", sqlp));
        }

        private List<Student> ReadTables(DataTable dataTable)
        {
            List<Student> students = new List<Student>();

            foreach (DataRow dr in dataTable.Rows)
            {
                int id = (int)dr["PersonID"];
                string firstname = (String)(dr["Firstname"].ToString());
                string lastname = (String)(dr["Lastname"].ToString());
                string email = (String)(dr["Email"].ToString());
                string phonenumber = (String)(dr["Phonenumber"].ToString());
                Student student = new Student(id, firstname, lastname, email, phonenumber);
                students.Add(student);
            }
            return students;
        }
    }
}
