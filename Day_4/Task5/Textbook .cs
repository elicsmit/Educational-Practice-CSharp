using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public class Textbook : Book
    {
        public string Subject { get; set; }

        public Textbook(string title, string author, string subject) : base(title, author)
        {
            Subject = subject;
        }

        public override void Read()
        {
            Console.WriteLine("Reading a textbook");
        }

        public override void DisplayInfo()
        {
            Console.Write($"[Учебник по предмету: {Subject}] ");
            base.DisplayInfo();
        }
    }
}
