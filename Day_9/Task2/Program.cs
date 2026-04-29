using System;
using System.Collections.Generic;
using System.IO;

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

        public override string ToString()
        {
            return $"{Id}|{ProductName}|{Quantity}";
        }
    }

    public class OrderFileWriter
    {
        private readonly string _filePath;

        public OrderFileWriter(string filePath)
        {
            _filePath = filePath;
        }

        public void WriteOrders(List<Order> orders)
        {
            using (StreamWriter writer = new StreamWriter(_filePath, false))
            {
                foreach (var order in orders)
                {
                    writer.WriteLine(order.ToString());
                }
            }
            Console.WriteLine($"Данные успешно записаны в {_filePath}");
        }
    }

    public class OrderFileReader
    {
        private readonly string _filePath;

        public OrderFileReader(string filePath)
        {
            _filePath = filePath;
        }

        public bool VerifyFile()
        {
            if (!File.Exists(_filePath)) return false;

            Console.WriteLine("Проверка корректности данных через чтение файла ");
            try
            {
                using (StreamReader reader = new StreamReader(_filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        Console.WriteLine($"Считано: {line}");

                        var parts = line.Split('|');
                        if (parts.Length != 3) return false;
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при чтении: {ex.Message}");
                return false;
            }
        }
    }

    class Program
    {
        static void Main()
        {
            string fileName = "file.data";

            var orders = new List<Order>
            {
                new Order(1, "Laptop", 2),
                new Order(2, "Mouse", 10),
                new Order(3, "Monitor", 5)
            };

            OrderFileWriter writer = new OrderFileWriter(fileName);
            OrderFileReader reader = new OrderFileReader(fileName);

            writer.WriteOrders(orders);

            bool isValid = reader.VerifyFile();

            Console.WriteLine($"\nРезультат проверки: {(isValid ? "Успешно" : "Ошибка")}");
        }
    }
}
