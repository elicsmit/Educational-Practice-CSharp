using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace OrderApp
{
    public class Order
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }

        public Order(int id, string productName, int quantity)
        {
            Id = id;
            ProductName = productName;
            Quantity = quantity;
        }
    }

    public class OrderFileReader
    {
        private readonly string _filePath;

        public OrderFileReader(string filePath)
        {
            _filePath = filePath;
        }

        public List<Order> ReadOrders()
        {
            List<Order> orders = new List<Order>();

            if (!File.Exists(_filePath))
            {
                Console.WriteLine("Файл данных не найден.");
                return orders;
            }

            foreach (string line in File.ReadLines(_filePath))
            {
                if (string.IsNullOrWhiteSpace(line)) continue;

                string[] parts = line.Split('|');
                if (parts.Length == 3)
                {
                    if (int.TryParse(parts[0], out int id) &&
                        int.TryParse(parts[2], out int quantity))
                    {
                        orders.Add(new Order(id, parts[1], quantity));
                    }
                }
            }

            return orders;
        }
    }

    public class OrderProcessor
    {
        private readonly List<Order> _orders;

        public OrderProcessor(List<Order> orders)
        {
            _orders = orders;
        }

        public List<string> GetMostPopularProducts(int topN)
        {
            return _orders
                .GroupBy(o => o.ProductName) 
                .Select(g => new
                {
                    Name = g.Key,
                    TotalQuantity = g.Sum(o => o.Quantity) 
                })
                .OrderByDescending(p => p.TotalQuantity) 
                .Take(topN) 
                .Select(p => $"{p.Name} (Продано: {p.TotalQuantity})")
                .ToList();
        }
    }

    class Program
    {
        static void Main()
        {
            string fileName = "file.data";

            OrderFileReader reader = new OrderFileReader(fileName);
            List<Order> loadedOrders = reader.ReadOrders();

            OrderProcessor processor = new OrderProcessor(loadedOrders);

            Console.WriteLine($"Загружено заказов: {loadedOrders.Count}");
            Console.WriteLine("\nТоп-2 популярных товара ");

            var popular = processor.GetMostPopularProducts(2);
            foreach (var item in popular)
            {
                Console.WriteLine(item);
            }
        }
    }
}
