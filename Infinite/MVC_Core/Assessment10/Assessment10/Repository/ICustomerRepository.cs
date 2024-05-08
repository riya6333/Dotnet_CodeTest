using System;
using System.Collections.Generic;
using Assessment10.Models;

namespace Assessment10.Repository
{
    public interface ICustomerRepository
    {
        Customer GetCustomerById(string customerId);
        List<Customer> GetAllCustomers();
       
    }
}
