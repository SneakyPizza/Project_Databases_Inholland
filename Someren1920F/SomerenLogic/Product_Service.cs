using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenLogic
{
    public class Product_Service
    {
        Product_DAO product_db = new Product_DAO();

        public List<Product> GetProducts()
        {
            try
            {
                return product_db.Db_Get_All_Products();
            }
            catch (Exception e)
            {
                   // something went wrong connecting to the database, so we will add a fake student to the list to make sure the rest of the application continues working!
                   List<Product> product = new List<Product>();
                   Product a = new Product(99, "Test", 99, 21, "Something went wrong", 99);
                   product.Add(a);
                   return product;
                   throw;
                   //throw new Exception("Someren couldn't connect to the database");

            }
        }
    }
}
