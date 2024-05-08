using Microsoft.AspNetCore.Mvc;
using Assessment10.Models;
using Assessment10.Repository;
using System;
using System.Collections.Generic;

namespace Assessment10.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderRepository _orderRepository;

        public OrderController(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

     
        [HttpPost]
        public IActionResult PlaceOrder(Order order)
        {
            if (ModelState.IsValid)
            {
                _orderRepository.PlaceOrder(order);
                return RedirectToAction("OrderDetails", new { orderId = order.OrderId });
            }
            return View(order);
        }

        public IActionResult OrderDetails(int orderId)
        {
            var order = _orderRepository.GetOrderDetails(orderId);
            return View(order);
        }

 
        public IActionResult DisplayBill(int orderId)
        {
            decimal billAmount = _orderRepository.CalculateBill(orderId);
            ViewBag.OrderId = orderId;
            ViewBag.BillAmount = billAmount;
            return View();
        }

  
        public IActionResult DisplayCustomerDetailsByOrderDate(DateTime orderDate)
        {
            var customers = _orderRepository.GetCustomersByOrderDate(orderDate);
            return View(customers);
        }

        
        public IActionResult ShowCustomerWithHighestOrder()
        {
            var customer = _orderRepository.GetCustomerWithHighestOrder();
            return View(customer);
        }
    }
}
