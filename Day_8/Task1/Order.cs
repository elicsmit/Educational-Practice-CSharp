namespace OrderSystem
{
    public class Order
    {
        public int OrderId { get; set; }
        public string Customer { get; set; }
        public string Items { get; set; }

        public Order(int id, string customer, string items)
        {
            OrderId = id;
            Customer = customer;
            Items = items;
        }

        public override string ToString()
        {
            return $"[Заказ #{OrderId}] Клиент: {Customer}, Состав: {Items}";
        }
    }
}
