using System;
using System.Collections.Generic;
using System.Linq;
using Assessment10.Models;

namespace Assessment10.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly NorthwindContext _context;

        public CustomerRepository(NorthwindContext context)
        {
            _context = context;
        }

        public Customer GetCustomerById(string customerId)
        {
            return _context.Customers.FirstOrDefault(c => c.CustomerId == customerId);
        }

        public List<Customer> GetAllCustomers()
        {
            return _context.Customers.ToList();
        }

        
    }
}

