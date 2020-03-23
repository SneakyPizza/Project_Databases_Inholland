using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Order
    {

        public Order(Product p, int amount, int personId)
        {
            Amount = amount;
            ProductName = p.Name;
            ProductPrice = p.PriceIncl;
            PersonId = personId;
            ProductId = p.Id;
        }

        public int Amount { get; private set; }
        public string ProductName { get; private set; }
        public decimal ProductPrice { get; private set; }
        public int PersonId { get; private set; }
        public int ProductId { get; private set; }
        public decimal OrderTotalPrice { get { return Amount * ProductPrice; } }
    }
}
