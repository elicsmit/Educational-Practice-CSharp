using System;

namespace OrderSystem
{
    class Program
    {
        static void Main()
        {
            OrderProcessor processor = new OrderProcessor();

            processor.AddOrder(new Order(101, "Алексей", "Пицца Маргарита"));
            processor.AddOrder(new Order(102, "Елена", "Суши Сет"));
            processor.AddOrder(new Order(103, "Дмитрий", "Бургер и Кола"));

            processor.PrintAll();

            Console.WriteLine("\nИщем заказ 102...");
            processor.FindOrder(102);

            Console.WriteLine("\nОбработка заказов:");
            processor.ProcessOrder(); 
            processor.ProcessOrder(); 

            processor.PrintAll(); 

            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
