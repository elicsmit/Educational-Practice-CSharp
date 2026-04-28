using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    public abstract class Athlete
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Sport { get; set; }
        public int Medals { get; set; }

        protected Athlete(string name, int age, string sport, int medals)
        {
            Name = name;
            Age = age;
            Sport = sport;
            Medals = medals;
        }

        public abstract void Train();
    }
}
