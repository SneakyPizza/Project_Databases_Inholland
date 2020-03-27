﻿using System;
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
            SqlParameter sqlParameter = new SqlParameter("@RoleID", 2);
            SqlParameter[] sqlp = new SqlParameter[] { sqlParameter };
            return ReadTables(ExecuteSelectQuery("GetAllPersonInfo", sqlp));
        }
        public void Db_Supervisor(int selectedTeacherID, int roleID)
        {
            SqlParameter sqlParameter = new SqlParameter("@role", roleID);
            SqlParameter sqlParameter1 = new SqlParameter("@id", selectedTeacherID);
            SqlParameter[] sqlp = new SqlParameter[] { sqlParameter, sqlParameter1 };

            ExecuteEditQuery("ChangePersonRole", sqlp);
        }

        private List<Supervisor> ReadTables(DataTable dataTable)
        {
            List<Supervisor> supervisors = new List<Supervisor>();

            foreach (DataRow dr in dataTable.Rows)
            {
                int id = (int)dr["PersonID"];
                string firstname = (string)(dr["Firstname"].ToString());
                string lastname = (string)(dr["Lastname"].ToString());
                string email = (string)(dr["Email"].ToString());
                string phonenumber = (string)(dr["Phonenumber"].ToString());
                Supervisor supervisor = new Supervisor(id, firstname, lastname, email, phonenumber);
                supervisors.Add(supervisor);
            }
            return supervisors;
        }

            public void Db_Send_NewSupervisor(int TeacherId, int Activityid)
            {
                SqlParameter sqlParameter1 = new SqlParameter("@Productid", TeacherId);
                SqlParameter sqlParameter2 = new SqlParameter("@Personid", Activityid);
                SqlParameter[] sqlp = new SqlParameter[] { sqlParameter1, sqlParameter2 };
                ExecuteEditQuery("INSERT INTO [ActivityJunction] ( Amount, Timestamp, ProductID) VALUES ( @Personid, @Amount, @Timestamp, @Productid)", sqlp); //orderID kan weg als je database deze automatisch invult
            }
        }
    }