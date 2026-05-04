using System;
using System.Collections.Generic;

namespace MySetProject
{
    class Program
    {
        static void Main()
        {
            MySet<int> set1 = new MySet<int>();
            set1.Add(1);
            set1.Add(2);
            set1.Add(3);
            set1.Add(1); 

            MySet<int> set2 = new MySet<int>();
            set2.Add(3);
            set2.Add(4);
            set2.Add(5);

            SetOperations<int> service = new SetOperations<int>();

            service.PrintSet("Множество 1", set1);
            service.PrintSet("Множество 2", set2);

            MySet<int> unionResult = service.Union(set1, set2);
            service.PrintSet("Объединение (Union)", unionResult);

            MySet<int> intersectResult = service.Intersect(set1, set2);
            service.PrintSet("Пересечение (Intersect)", intersectResult);

            Console.WriteLine("\nНажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
