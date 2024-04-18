using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Product
    {
        public int ProductId;
        public string ProductName;
        public double Price;

        public Product(int ProductId, string ProductName, double Price)
        {
            this.ProductId = ProductId;
            this.ProductName = ProductName;
            this.Price = Price;
        }


    }
}