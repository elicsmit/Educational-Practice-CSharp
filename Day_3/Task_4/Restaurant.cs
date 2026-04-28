using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    public class Restaurant
    {
        public Dish[] Menu { get; set; }

        public Restaurant(Dish[] menu)
        {
            Menu = menu;
        }

        public Dish GetMostExpensiveDish()
        {
            if (Menu == null || Menu.Length == 0) return null;

            return Menu.OrderByDescending(d => d.Price).First();
        }

        public List<Dish> GetDishesByCategory(string category)
        {
            return Menu
                .Where(d => d.Category.Equals(category, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }
    }
}
