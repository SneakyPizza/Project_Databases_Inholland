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
    class SetParameter : Base
    {
        private void StudentParameter()
        {
            SqlParameter sqlParameter = new SqlParameter("@RoleID", 0);
            SqlParameter[] sqlp = new SqlParameter[] { sqlParameter };
            ExecuteEditQuery("GetAllPersonInfo", sqlp);
        }
        private void TeacherParameter()
        {
            SqlParameter sqlParameter = new SqlParameter("@RoleID", 1);
            SqlParameter[] sqlp = new SqlParameter[] { sqlParameter };
            ExecuteEditQuery("GetAllPersonInfo", sqlp);
        }
        private void RoomParameter()
        {
            SqlParameter sqlParameter = new SqlParameter("@RoomID", 16);
            SqlParameter[] sqlp = new SqlParameter[] { sqlParameter };
            ExecuteEditQuery("GetAllPersonInfo", sqlp);
        }
    }
}
