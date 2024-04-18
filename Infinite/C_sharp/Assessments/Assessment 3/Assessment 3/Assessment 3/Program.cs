using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Assessment_3.CalculatorDelegate;

namespace Assessment_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "Assessment.txt"; 
            string textToAppend = "This text is appended to the file.";

           
            AppendFile.AppendTextToFile(filePath, textToAppend);

            Console.WriteLine("Text has been appended to the file.");
            Console.WriteLine("------------------------------------------------------------------------------");

            //DelegateCalculator
            Console.WriteLine("Calculator Functionalities:");
           
            Console.WriteLine("Enter the first integer:");
            if (!int.TryParse(Console.ReadLine(), out int num1))
            {
                Console.WriteLine("Invalid input. Please enter an integer.");
                return;
            }

            Console.WriteLine("Enter the second integer:");
            if (!int.TryParse(Console.ReadLine(), out int num2))
            {
                Console.WriteLine("Invalid input. Please enter an integer.");
                return;
            }

            ArithmeticOperation addition = (x, y) => x + y;
            ArithmeticOperation subtraction = (x, y) => x - y;
            ArithmeticOperation multiplication = (x, y) => x * y;
   
            Console.WriteLine($"Addition Result: {addition(num1, num2)}");
            Console.WriteLine($"Subtraction Result: {subtraction(num1, num2)}");
            Console.WriteLine($"Multiplication Result: {multiplication(num1, num2)}");
            Console.WriteLine("----------------------------------------------------------------------");
            //Employee Collection
            List<Employee> empList = new List<Employee>
            {
                new Employee { EmployeeID = 1001, FirstName = "Malcolm", LastName = "Daruwalla", Title = "Manager", DOB = DateTime.Parse("16/11/1984"), DOJ = DateTime.Parse("8/6/2011"), City = "Mumbai" },
                new Employee { EmployeeID = 1002, FirstName = "Asdin", LastName = "Dhalla", Title = "AsstManager", DOB = DateTime.Parse("20/08/1984"), DOJ = DateTime.Parse("7/7/2012"), City = "Mumbai" },
                new Employee { EmployeeID = 1003, FirstName = "Madhavi", LastName = "Oza", Title = "Consultant", DOB = DateTime.Parse("14/11/1987"), DOJ = DateTime.Parse("12/4/2015"), City = "Pune" },
                new Employee { EmployeeID = 1004, FirstName = "Saba", LastName = "Shaikh", Title = "SE", DOB = DateTime.Parse("3/6/1990"), DOJ = DateTime.Parse("2/2/2016"), City = "Pune" },
                new Employee { EmployeeID = 1005, FirstName = "Nazia", LastName = "Shaikh", Title = "SE", DOB = DateTime.Parse("8/3/1991"), DOJ = DateTime.Parse("2/2/2016"), City = "Mumbai" },
                new Employee { EmployeeID = 1006, FirstName = "Amit", LastName = "Pathak", Title = "Consultant", DOB = DateTime.Parse("7/11/1989"), DOJ = DateTime.Parse("8/8/2014"), City = "Chennai" },
                new Employee { EmployeeID = 1007, FirstName = "Vijay", LastName = "Natrajan", Title = "Consultant", DOB = DateTime.Parse("2/12/1989"), DOJ = DateTime.Parse("1/6/2015"), City = "Mumbai" },
                new Employee { EmployeeID = 1008, FirstName = "Rahul", LastName = "Dubey", Title = "Associate", DOB = DateTime.Parse("11/11/1993"), DOJ = DateTime.Parse("6/11/2014"), City = "Chennai" },
                new Employee { EmployeeID = 1009, FirstName = "Suresh", LastName = "Mistry", Title = "Associate", DOB = DateTime.Parse("12/8/1992"), DOJ = DateTime.Parse("3/12/2014"), City = "Chennai" },
                new Employee { EmployeeID = 1010, FirstName = "Sumit", LastName = "Shah", Title = "Manager", DOB = DateTime.Parse("12/4/1991"), DOJ = DateTime.Parse("2/1/2016"), City = "Pune" }
            };

            // a. Display detail of all the employee
            Console.WriteLine("Details of all employees:");
            foreach (var emp in empList)
            {
                Console.WriteLine($"EmployeeID: {emp.EmployeeID}, FirstName: {emp.FirstName}, LastName: {emp.LastName}, Title: {emp.Title}, DOB: {emp.DOB.ToShortDateString()}, DOJ: {emp.DOJ.ToShortDateString()}, City: {emp.City}");
            }
            Console.WriteLine();

            // b. Display details of all the employee whose location is not Mumbai
            var empNotInMumbai = empList.Where(emp => emp.City != "Mumbai");
            Console.WriteLine("Details of employees not in Mumbai:");
            foreach (var emp in empNotInMumbai)
            {
                Console.WriteLine($"EmployeeID: {emp.EmployeeID}, FirstName: {emp.FirstName}, LastName: {emp.LastName}, Title: {emp.Title}, DOB: {emp.DOB.ToShortDateString()}, DOJ: {emp.DOJ.ToShortDateString()}, City: {emp.City}");
            }
            Console.WriteLine();

            // c. Display details of all the employee whose title is AsstManager
            var asstManagers = empList.Where(emp => emp.Title == "AsstManager");
            Console.WriteLine("Details of AsstManagers:");
            foreach (var emp in asstManagers)
            {
                Console.WriteLine($"EmployeeID: {emp.EmployeeID}, FirstName: {emp.FirstName}, LastName: {emp.LastName}, Title: {emp.Title}, DOB: {emp.DOB.ToShortDateString()}, DOJ: {emp.DOJ.ToShortDateString()}, City: {emp.City}");
            }
            Console.WriteLine();

            // d. Display details of all the employee whose Last Name starts with S
            var empLastNameStartsWithS = empList.Where(emp => emp.LastName.StartsWith("S"));
            Console.WriteLine("Details of employees whose Last Name starts with S:");
            foreach (var emp in empLastNameStartsWithS)
            {
                Console.WriteLine($"EmployeeID: {emp.EmployeeID}, FirstName: {emp.FirstName}, LastName: {emp.LastName}, Title: {emp.Title}, DOB: {emp.DOB.ToShortDateString()}, DOJ: {emp.DOJ.ToShortDateString()}, City: {emp.City}");
            }
            Console.WriteLine();
            Console.Read();
        }
     
        }
    }


