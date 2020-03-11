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
        public List<Teacher> Db_Get_All_Teachers()
        {
            string query = "GetAllPersonInfo";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Teacher> ReadTables(DataTable dataTable)
        {
            List<Teacher> teachers = new List<Teacher>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Teacher teacher = new Teacher()
                {
                    TeacherID = (int)dr["PersonID"],
                    FirstName = (String)(dr["Firstname"].ToString()),
                    LastName = (String)(dr["Lastname"].ToString()),
                    EmailAddress = (String)(dr["Email"].ToString()),
                    PhoneNumber = (String)(dr["Phonenumber"].ToString()),
                    Role = (int)dr["Role"]
                };
                teachers.Add(teacher);
            }
            return teachers;
        }
    }
}
