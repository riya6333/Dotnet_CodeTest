using System;
using System.Collections.Generic;
using Assessment10.Models;

namespace Assessment10.Repository
{
    public interface IOrderRepository
    {
        void PlaceOrder(Order order);
        Order GetOrderDetails(int orderId);
        decimal CalculateBill(int orderId);
        List<Customer> GetCustomersByOrderDate(DateTime orderDate);
        Customer GetCustomerWithHighestOrder();
    }
}
