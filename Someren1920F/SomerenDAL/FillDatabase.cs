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
    public class FillDatabase : Base
    {
        public void BulkInsertPerson()
        {
            SqlConnection conn = null;
            SqlCommand c = new SqlCommand("BulkInsertPerson");
            c.CommandType = CommandType.StoredProcedure;

            try
            {
               conn = OpenConnection();
                c.ExecuteNonQuery();
                
            } catch(SqlException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
