using System;
using System.Collections.Generic;
using System.Linq;
using Assessment10.Models;

namespace Assessment10.Repository
{
    public class OrderDetailRepository : IOrderDetailRepository
    {
        private readonly NorthwindContext _context;

        public OrderDetailRepository(NorthwindContext context)
        {
            _context = context;
        }

        public List<OrderDetail> GetOrderDetailsByOrderId(int orderId)
        {
            return _context.OrderDetails.Where(od => od.OrderId == orderId).ToList();
        }

       
    }
}

