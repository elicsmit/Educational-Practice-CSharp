using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;
using System.Xml.Linq;
using System.Threading.Tasks;

namespace Task_4
{
        public partial class Dish
        {
            public void DisplayInfo()
            {
                Console.WriteLine($"{Name} ({Category}) - {Price} руб. за {Weight}г.");
            }
        }

}
