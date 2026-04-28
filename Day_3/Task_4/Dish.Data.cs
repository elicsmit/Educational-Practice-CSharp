using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    public partial class Dish
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public double Weight { get; set; }

        public Dish(string name, string category, decimal price, double weight)
        {
            Name = name;
            Category = category;
            Price = price;
            Weight = weight;
        }
    }
}
