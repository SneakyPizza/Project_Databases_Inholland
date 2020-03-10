using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlClient;
using System.Data;

namespace SomerenDAL
{
    public class FillDatabase
    {
        public void InsertString(List<string> str, SqlConnection sqlcon)
        {
            string cmd = "INSERT @parameter INTO Person Where";
            SqlCommand sc = new SqlCommand(cmd, sqlcon);


            foreach(string s in str)
            {
                sc.Parameters.Clear();
                sc.Parameters.Add("", s);

            }
        }

        public void InsertPerson(List<string> firstname, List<string> lastname, DateTime date, SqlConnection conn)
        {
            /* CREATE TABLE Person(
	    ID int NOT NULL PRIMARY KEY,
	    Firstname nvarchar(20) NOT NULL,
	    Lastname nvarchar(20) NOT NULL,
	    Email nvarchar(40) NOT NULL,
	    Phonenumber nvarchar(13) NOT NULL,
	    [Role] bit(1) NOT NULL
         ) */

            string cmdstring = "";
            SqlCommand cmd = new SqlCommand(cmdstring, conn);
            cmd.Parameters.Add("@Firstname", SqlDbType.NVarChar);
            cmd.Parameters.Add("@Lastname", SqlDbType.NVarChar);
            cmd.Parameters.Add("@Birthdate", SqlDbType.Date);



            for (int i = 0; i < firstname.Count; i++)
            {
                cmd.Parameters["@Firstname"].Value = firstname[i];
                cmd.Parameters["@Lastname"].Value = lastname[i];
                cmd.Parameters["@Birthdate"].Value = date;
                cmd.ExecuteNonQuery();
            }

        }


        public List<string> ReadText(string path)
        {
            List<string> stringl = new List<string>();
            string line;

            StreamReader sr = new StreamReader(path);
            while((line = sr.ReadLine()) != null)
            {
                stringl.Add(line);
            }
            sr.Close();
            return stringl;
        }
    }
}
