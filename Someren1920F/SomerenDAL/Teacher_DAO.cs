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
            SqlParameter sqlParameter = new SqlParameter("@RoleID", 1);
            SqlParameter[] sqlp = new SqlParameter[] { sqlParameter };
            return ReadTables(ExecuteSelectQuery("GetAllPersonInfo", sqlp));
        }

        private List<Teacher> ReadTables(DataTable dataTable)
        {
            List<Teacher> teachers = new List<Teacher>();

            foreach (DataRow dr in dataTable.Rows)
            {
                
                int id = (int)dr["PersonID"];
                string firstname = (String)(dr["Firstname"].ToString());
                string lastname = (String)(dr["Lastname"].ToString());
                string email = (String)(dr["Email"].ToString());
                string phonenumber = (String)(dr["Phonenumber"].ToString());
                Teacher teacher = new Teacher(id, firstname, lastname, email, phonenumber);
                teachers.Add(teacher);
            }
            return teachers;
        }
    }
}
