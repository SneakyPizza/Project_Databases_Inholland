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

namespace SomerenDAL
{
    public class Activity_DAO : Base
    {
        public List<Activity> Db_Get_All_Activities()
        {
            return ReadTables(ExecuteSelectQuery("GetAllActivities"));
        }

        public void Db_Add_Activity(string name, DateTime dateTime, string description)
        {
            SqlParameter sqlParameter1 = new SqlParameter("@name", name);
            SqlParameter sqlParameter2 = new SqlParameter("@dateTime", dateTime);
            SqlParameter sqlParameter3 = new SqlParameter("@desc", description);
            SqlParameter[] sqlp = new SqlParameter[] { sqlParameter1, sqlParameter2, sqlParameter3 };
            ExecuteEditQuery("InsertActivity", sqlp);
        }
        public void Db_Update_Activity(int id, string name, DateTime dateTime, string description)
        {
            SqlParameter sqlParameter1 = new SqlParameter("@id", id);
            SqlParameter sqlParameter2 = new SqlParameter("@name", name);
            SqlParameter sqlParameter3 = new SqlParameter("@dateTime", dateTime);
            SqlParameter sqlParameter4 = new SqlParameter("@desc", description);
            SqlParameter[] sqlp = new SqlParameter[] { sqlParameter1, sqlParameter2, sqlParameter3, sqlParameter4 };
            ExecuteEditQuery("UpdateActivity", sqlp); 
        }
        public void Db_Delete_Activity(int id)
        {
            SqlParameter sqlParameter1 = new SqlParameter("@id", id);
            SqlParameter[] sqlp = new SqlParameter[] { sqlParameter1 };
            ExecuteEditQuery("DeleteActivity", sqlp); 
        }
        private List<Activity> ReadTables(DataTable dataTable)
        {
            List<Activity> activities = new List<Activity>();

            foreach (DataRow dr in dataTable.Rows)
            {
                int id = (int)dr["ActivityID"];
                string name = (string)(dr["Name"].ToString());
                DateTime date = (DateTime)(dr["Date"]);
                string description = (string)(dr["Description"]);
                Activity activity = new Activity(id, name, date, description);
                activities.Add(activity);
            }
            return activities;
        }
    }
}
