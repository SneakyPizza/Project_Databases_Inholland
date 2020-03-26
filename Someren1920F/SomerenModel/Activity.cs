using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Activity
    {
        public Activity(int id, string name, DateTime date, string description)
        {
            ID = id;
            Name = name;
            Date = date;
            Description = description;
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
    }
}
