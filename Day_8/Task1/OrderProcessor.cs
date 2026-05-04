using System.Collections; 
namespace OrderSystem
{
    public class OrderProcessor
    {
        private Queue _orderQueue = new Queue();

        public void AddOrder(Order order)
        {
            _orderQueue.Enqueue(order);
            Console.WriteLine($"Заказ #{order.OrderId} принят.");
        }

        public void ProcessOrder()
        {
            if (_orderQueue.Count > 0)
            {
                Order processed = (Order)_orderQueue.Dequeue();
                Console.WriteLine($"ВЫПОЛНЕНО: {processed}");
            }
            else
            {
                Console.WriteLine("Нет заказов для обработки.");
            }
        }

        public void FindOrder(int id)
        {
            foreach (Order order in _orderQueue)
            {
                if (order.OrderId == id)
                {
                    Console.WriteLine($"РЕЗУЛЬТАТ ПОИСКА: {order}");
                    return;
                }
            }
            Console.WriteLine($"Заказ №{id} не найден.");
        }

        public void PrintAll()
        {
            Console.WriteLine($"\n--- В очереди: {_orderQueue.Count} заказа(ов) ---");
            foreach (Order order in _orderQueue)
            {
                Console.WriteLine(order);
            }
        }
    }
}
