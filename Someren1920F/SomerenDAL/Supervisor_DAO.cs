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
    public class Supervisor_DAO : Base
    {

        public List<Supervisor> Db_Get_All_Supervisors()
        {
            return ReadTables(ExecuteSelectQuery("GetAllPersonInfo"));
        }

        private List<Supervisor> ReadTables(DataTable dataTable)
        {
            List<Supervisor> supervisors = new List<Supervisor>();

            foreach (DataRow dr in dataTable.Rows)
            {
                int id = (int)dr["EventJunctionID"];
                int TeacherId = (int)dr["PersonID"];
                int ActivityId = (int)dr["EventID"];
                Supervisor supervisor = new Supervisor(id, TeacherId, ActivityId);
                supervisors.Add(supervisor);
            }
            return supervisors;
        }

        
        public void Db_Send_NewSupervisor(int TeacherId, int Activityid)
        {
            SqlParameter sqlParameter1 = new SqlParameter("@Productid", TeacherId);
            SqlParameter sqlParameter2 = new SqlParameter("@Personid", Activityid);
            SqlParameter[] sqlp = new SqlParameter[] { sqlParameter1, sqlParameter2};
            ExecuteEditQuery("INSERT INTO [ActivityJunction] ( Amount, Timestamp, ProductID) VALUES ( @Personid, @Amount, @Timestamp, @Productid)", sqlp); //orderID kan weg als je database deze automatisch invult
        }
        
    }
}
