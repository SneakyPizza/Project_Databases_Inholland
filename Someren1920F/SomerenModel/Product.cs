using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Product
    {

        private int _btw;
        public Product(int id, string name, decimal price, int btwpercentile, string description = "", int amount = 0)
        {
            Id = id;
            Name = name;
            PriceExcl = price;
            _btw = btwpercentile;
            Description = description;
            Amount = amount;
        }

        public int Id { get; private set; }
        public string Name { get; private set; }
        public decimal PriceExcl { get; private set; }
        public decimal PriceIncl { get { return (PriceExcl / 100 * _btw) + PriceExcl; } }
        public string Description { get; private set; }
        public int Amount { get; set; }

        /*public Product(int id, string name, decimal price, int btw, int amount, string description)
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
        */
    }
}
