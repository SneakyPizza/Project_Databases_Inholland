using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Product
    {
        public Product(int id, string name, decimal price, int btw, int amount, string description)
        {
            ProductID = id;
            Name = name;
            Price = price;
            BTWpercentile = btw;
            Amount = amount;
            Description = description;
        }

        public int ProductID { get; set; }
        public string Name { get; set; }

        public decimal Price { get; set; }

        public int BTWpercentile { get; set; }

        public int Amount { get; set; }

        public string Description { get; set; }

    }
}
