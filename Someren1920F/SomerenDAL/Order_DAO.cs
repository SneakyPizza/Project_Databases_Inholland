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
    public class Order_DAO : Base
    {
        public void Db_Send_Order(int Productid, int Personid)
        {
            SqlParameter sqlParameter1 = new SqlParameter("@Productid", Productid);
            SqlParameter sqlParameter2 = new SqlParameter("@Personid", Personid);
            SqlParameter sqlParameter3 = new SqlParameter("@Amount", 1);
            SqlParameter sqlParameter4 = new SqlParameter("@Timestamp", DateTime.Now);
            SqlParameter[] sqlp = new SqlParameter[] { sqlParameter1, sqlParameter2, sqlParameter3, sqlParameter4 };
            ExecuteEditQuery("INSERT INTO [Order] (PersonID, Amount, Timestamp, ProductID) VALUES ( @Personid, @Amount, @Timestamp, @Productid)", sqlp); //orderID kan weg als je database deze automatisch invult
        }
        public List<Order> ReadOrders(DataTable dt)
        {
            List<Order> orders = new List<Order>();

            foreach (DataRow dr in dt.Rows)
            {
                int id = (int)dr["OrderID"];
                int personid = (int)dr["PersonID"];
                int amount = (int)dr["Amount"];
                DateTime time = (DateTime)dr["Timestamp"];
                //product of the order
                int productID = (int)dr["ProductId"];
                string name = (string)dr["Name"];
                decimal price = (decimal)dr["Price"];
                int btw = (int)dr["BTWPercentile"];

                Product p = new Product(productID, name, price, btw);
                Order o = new Order(p, amount, personid);
                orders.Add(o);
            }
            return orders;
        }
        public List<Order> getAllOrders()
        {
            SqlParameter[] sqlp = new SqlParameter[] { };
            return ReadOrders(ExecuteSelectQuery("GetAllOrders", sqlp));
        }

        public List<Order> getOrdersBetween(DateTime t1, DateTime t2)
        {
            SqlParameter p1 = new SqlParameter("StartDate", t1);
            SqlParameter p2 = new SqlParameter("EndDate", t2);
            SqlParameter[] sqlp = new SqlParameter[] { p1, p2 };
            return ReadOrders(ExecuteSelectQuery("GetOrders", sqlp));
        }


    }
}
