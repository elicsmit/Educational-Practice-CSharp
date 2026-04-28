using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public class Novel : Book
    {
        public Novel(string title, string author) : base(title, author) { }

        public override void Read()
        {
            Console.WriteLine("Reading a novel");
        }

        public override void DisplayInfo()
        {
            Console.Write("[Жанр: Роман] ");
            base.DisplayInfo();
        }
    }
}
