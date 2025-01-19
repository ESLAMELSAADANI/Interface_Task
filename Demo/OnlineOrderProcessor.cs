using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class OnlineOrderProcessor : IOrderProcessor
    {
        public void ProcessOrder(int orderId, string customerName, decimal orderAmount)
        {
            decimal discountedAmount = CalculateDiscount(orderAmount);
            Console.WriteLine($"Order {orderId} processed for {customerName}. Final amount after 10% discount: ${discountedAmount}");
        }

        public decimal CalculateDiscount(decimal orderAmount)
        {
            return orderAmount * 0.9m; 
        }
    }
}
