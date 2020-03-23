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
    public class Order_Service
    {
        private Order_DAO _dao = new Order_DAO();
        private List<Order> _order;

        public List<Order> GetOrders()
        {
            return _dao.getAllOrders();
        }

        public int TotalAmountofDrinks(DateTime d1, DateTime d2)
        {
            try
            {
                int a = 0;
                _order = _dao.getOrdersBetween(d1, d2);
                foreach (Order o in _order)
                {
                    a += o.Amount;
                }
                return a;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public decimal PricePerPeriod(List<Order> ol)
        {
            decimal price = 0;
            foreach (Order o in ol)
            {
                price += o.OrderTotalPrice;
            }
            return price;
        }

        public int CountDistinctPerson(List<Order> ol)
        {
            List<int> i = new List<int>();

            foreach (Order o in ol)
            {
                if (!i.Contains(o.PersonId))
                {
                    i.Add(o.PersonId);
                }
            }
            return i.Count;
        }


    }
}

