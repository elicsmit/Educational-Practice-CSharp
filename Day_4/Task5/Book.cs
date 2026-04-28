using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public abstract class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }

        public abstract void Read();

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Книга: {Title}, Автор: {Author}");
        }
    }
}
