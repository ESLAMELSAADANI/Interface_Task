using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal interface IOrderProcessor
    {
        void ProcessOrder(int orderId, string customerName, decimal orderAmount);
        decimal CalculateDiscount(decimal orderAmount);
    }
}
