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
    public class Product_DAO : Base
    {
        public List<Product> Db_Get_All_Products()
        {
            return ReadTables(ExecuteSelectQuery("GetAllProducts"));
        }

        private List<Product> ReadTables(DataTable dataTable)
        {
            List<Product> products = new List<Product>();

            foreach (DataRow dr in dataTable.Rows)
            {
                int id = (int)dr["ProductID"];
                string name = (String)(dr["Name"].ToString());
                decimal price = (decimal)(dr["Price"]);
                int btw = (int)(dr["BTWPercentile"]);
                int amount = (int)dr["Amount"];
                string description = (String)(dr["Description"].ToString());
                Product product = new Product(id, name, price, btw, description, amount);
                products.Add(product);
            }
            return products;
        }
    }
}
