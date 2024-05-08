using System;
using System.Collections.Generic;
using System.Linq;
using Assessment10.Models;

namespace Assessment10.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly NorthwindContext _context;

        public OrderRepository(NorthwindContext context)
        {
            _context = context;
        }

        public void PlaceOrder(Order order)
        {
            _context.Orders.Add(order);
            _context.SaveChanges();
        }

        public Order GetOrderDetails(int orderId)
        {
            return _context.Orders.FirstOrDefault(o => o.OrderId == orderId);
        }

        public decimal CalculateBill(int orderId)
        {
            var order = _context.Orders.FirstOrDefault(o => o.OrderId == orderId);
            if (order != null)
            {
                return (decimal)order.OrderDetails.Sum(od => od.UnitPrice * od.Quantity);
            }
            return 0;
        }

        public List<Customer> GetCustomersByOrderDate(DateTime orderDate)
        {
            return _context.Orders
                .Where(o => o.OrderDate.HasValue && o.OrderDate.Value.Date == orderDate.Date)
                .Select(o => o.Customer)
                .Distinct()
                .ToList();
        }


        public Customer GetCustomerWithHighestOrder()
        {
            var customerWithHighestOrder = _context.Orders
                .GroupBy(o => o.CustomerId)
                .Select(g => new { CustomerId = g.Key, TotalAmount = g.Sum(o => o.OrderDetails.Sum(od => od.UnitPrice * od.Quantity)) })
                .OrderByDescending(x => x.TotalAmount)
                .FirstOrDefault();

            if (customerWithHighestOrder != null)
            {
                return _context.Customers.FirstOrDefault(c => c.CustomerId == customerWithHighestOrder.CustomerId);
            }

            return null;
        }
    }
}
