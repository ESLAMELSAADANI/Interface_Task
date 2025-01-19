namespace Demo
{
    internal class Program
    {
        public static IOrderProcessor AssignOrderProcessor(string orderType)
        {
            if (orderType == "online" || orderType == "Online")
            {
                return new OnlineOrderProcessor();
            }
            else if (orderType == "in-store" || orderType == "In-store")
            {
                return new InStoreOrderProcessor();
            }
            else
            {
                throw new ArgumentException("Invalid order type");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Order ID:");
            int orderId = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Enter Customer Name:");
            string customerName = Console.ReadLine()!;

            Console.WriteLine("Enter Order Amount:");
            decimal orderAmount = decimal.Parse(Console.ReadLine()!);

            Console.WriteLine("Enter Order Type (Online/In-Store):");
            string orderType = Console.ReadLine()!;

            Order order = new Order
            {
                OrderId = orderId,
                CustomerName = customerName,
                OrderAmount = orderAmount,
                OrderProcessor = AssignOrderProcessor(orderType)
            };

            order.OrderProcessor.ProcessOrder(order.OrderId, order.CustomerName, order.OrderAmount);
        }

    }
}
