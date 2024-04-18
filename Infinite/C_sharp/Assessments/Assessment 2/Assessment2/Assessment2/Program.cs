using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        abstract class Student
        {
           
            public string Name { get; set; }
            public int StudentId { get; set; }
            public double Grade { get; set; }

           
            public abstract bool IsPassed(double grade);
        }

        class Undergraduate : Student
        {
           
            public override bool IsPassed(double grade)
            {
                return grade >= 70.0; 
            }
        }

        class Graduate : Student
        {
            
            public override bool IsPassed(double grade)
            {
                return grade >= 80.0; 
            }
        }

        static void Main(string[] args)
        {
           
            Console.WriteLine("Enter details for undergraduate student:");
            Undergraduate undergrad = new Undergraduate();
            Console.Write("Name: ");
            undergrad.Name = Console.ReadLine();
            Console.Write("Student ID: ");
            undergrad.StudentId = int.Parse(Console.ReadLine());
            Console.Write("Grade: ");
            undergrad.Grade = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine($"{undergrad.Name} {undergrad.IsPassed(undergrad.Grade)}");

           
            Console.WriteLine("\nEnter details for graduate student:");
            Graduate grad = new Graduate();
            Console.Write("Name: ");
            grad.Name = Console.ReadLine();
            Console.Write("Student ID: ");
            grad.StudentId = int.Parse(Console.ReadLine());
            Console.Write("Grade: ");
            grad.Grade = Convert.ToDouble(Console.ReadLine());

           
            Console.WriteLine($"{grad.Name} {grad.IsPassed(grad.Grade)}");

            Console.ReadLine();

            Product[] products = new Product[10];

            
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Enter details for product {i + 1}:");
                Console.Write("Product ID: ");
                int productId = Convert.ToInt32(Console.ReadLine());
                Console.Write("Product Name: ");
                string productName = Console.ReadLine();
                Console.Write("Price: ");
                double price = Convert.ToDouble(Console.ReadLine());

                products[i] = new Product(productId, productName, price);
            }

            
            Array.Sort(products, (x, y) => x.Price.CompareTo(y.Price));

           
            Console.WriteLine("\nSorted Products:");
            foreach (Product product in products)
            {
                Console.WriteLine($"Product ID: {product.ProductId}, Product Name: {product.ProductName}, Price: {product.Price}");
            }

            Console.ReadLine();


        }
    }
}
