using System;
using System.Collections.Generic;
using Assessment10.Models;

namespace Assessment10.Repository
{
    public interface IOrderDetailRepository
    {
        List<OrderDetail> GetOrderDetailsByOrderId(int orderId);
      
    }
}

