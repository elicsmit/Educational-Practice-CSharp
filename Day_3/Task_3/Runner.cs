using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    public sealed class Runner : Athlete
    {
        public double TopSpeed { get; set; }

        public Runner(string name, int age, int medals, double topSpeed)
            : base(name, age, "Бег", medals)
        {
            TopSpeed = topSpeed;
        }

        public override void Train() => Console.WriteLine($"{Name} тренируется на стадионе.");
    }

}
