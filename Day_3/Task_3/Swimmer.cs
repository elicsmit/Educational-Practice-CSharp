using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    public sealed class Swimmer : Athlete
    {
        public string StrokeStyle { get; set; }

        public Swimmer(string name, int age, int medals, string strokeStyle)
            : base(name, age, "Плавание", medals)
        {
            StrokeStyle = strokeStyle;
        }

        public override void Train() => Console.WriteLine($"{Name} тренируется в бассейне.");
    }
}
