using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> empList = new List<Employee>
        {
           new Employee { EmployeeID = 1001, FirstName = "Malcolm", LastName = "Daruwalla", Title = "Manager", DOB = new DateTime(1984, 11, 16), DOJ = new DateTime(2011, 6, 8), City = "Mumbai" },
                new Employee { EmployeeID = 1002, FirstName = "Asdin", LastName = "Dhalla", Title = "AsstManager", DOB = new DateTime(1984, 8, 20), DOJ = new DateTime(2012, 7, 7), City = "Mumbai" },
                new Employee { EmployeeID = 1003, FirstName = "Madhavi", LastName = "Oza", Title = "Consultant", DOB = new DateTime(1987, 11, 14), DOJ = new DateTime(2015, 4, 12), City = "Pune" },
                new Employee { EmployeeID = 1004, FirstName = "Saba", LastName = "Shaikh", Title = "SE", DOB = new DateTime(1990, 6, 3), DOJ = new DateTime(2016, 2, 2), City = "Pune" },
                new Employee { EmployeeID = 1005, FirstName = "Nazia", LastName = "Shaikh", Title = "SE", DOB = new DateTime(1991, 3, 8), DOJ = new DateTime(2016, 2, 2), City = "Mumbai" },
                new Employee { EmployeeID = 1006, FirstName = "Amit", LastName = "Pathak", Title = "Consultant", DOB = new DateTime(1989, 11, 7), DOJ = new DateTime(2014, 8, 8), City = "Chennai" },
                new Employee { EmployeeID = 1007, FirstName = "Vijay", LastName = "Natrajan", Title = "Consultant", DOB = new DateTime(1989, 12, 2), DOJ = new DateTime(2015, 6, 1), City = "Mumbai" },
                new Employee { EmployeeID = 1008, FirstName = "Rahul", LastName = "Dubey", Title = "Associate", DOB = new DateTime(1993, 11, 11), DOJ = new DateTime(2014, 11, 6), City = "Chennai" },
                new Employee { EmployeeID = 1009, FirstName = "Suresh", LastName = "Mistry", Title = "Associate", DOB = new DateTime(1992, 8, 12), DOJ = new DateTime(2014, 12, 3), City = "Chennai" },
                new Employee { EmployeeID = 1010, FirstName = "Sumit", LastName = "Shah", Title = "Manager", DOB = new DateTime(1991, 4, 12), DOJ = new DateTime(2016, 1, 2), City = "Pune" }
            };


            // 1 Employees who joined before 1/1/2015
            var joined_Before2015 = empList.Where(emp => emp.DOJ < new DateTime(2015, 1, 1));
            Console.WriteLine("Employees who joined before 1/1/2015:");
            foreach (var emp in joined_Before2015)
            {
                Console.WriteLine($"{emp.FirstName} {emp.LastName}");
            }
            Console.WriteLine("---------------------------------------------------------------------------------");


            // 2 Employees whose date of birth is after 1/1/1990
            Console.WriteLine("Employees whose date of birth is after 1/1/1990:");
            foreach (var emp in empList)
            {
                if (emp.DOB > new DateTime(1990, 1, 1))
                    Console.WriteLine($"{emp.FirstName} {emp.LastName}");
            }
            Console.WriteLine("---------------------------------------------------------------------------------");


            // 3 Employees whose designation is Consultant or Associate
            Console.WriteLine("Employees whose designation is Consultant or Associate:");
            foreach (var emp in empList)
            {
                if (emp.Title == "Consultant" || emp.Title == "Associate")
                    Console.WriteLine($"{emp.FirstName} {emp.LastName}");
            }
            Console.WriteLine("---------------------------------------------------------------------------------");


            // 4. Total number of employees
            Console.WriteLine($"Total number of employees: {empList.Count}");
            Console.WriteLine("---------------------------------------------------------------------------------");


            // 5. Total number of employees belonging to “Chennai”
            Console.WriteLine($"Total number of employees in Chennai: {empList.Count(emp => emp.City == "Chennai")}");
            Console.WriteLine("---------------------------------------------------------------------------------");


            // 6. Highest employee id from the list
            int maxEmployeeID = empList.Max(emp => emp.EmployeeID);
            Console.WriteLine($"Highest employee ID: {maxEmployeeID}");
            Console.WriteLine("---------------------------------------------------------------------------------");


            // 7. Total number of employees who have joined after 1/1/2015
            Console.WriteLine($"Total number of employees joined after 1/1/2015: {empList.Count(emp => emp.DOJ > new DateTime(2015, 1, 1))}");
            Console.WriteLine("---------------------------------------------------------------------------------");


            // 8. Total number of employees whose designation is not “Associate”
            Console.WriteLine($"Total number of employees whose designation is not Associate: {empList.Count(emp => emp.Title != "Associate")}");
            Console.WriteLine("---------------------------------------------------------------------------------");


            // 9. Total number of employees based on City
            Console.WriteLine("Total number of employees based on City:");
            var cityGroup = empList.GroupBy(emp => emp.City);
            foreach (var group in cityGroup)
            {
                Console.WriteLine($"{group.Key}: {group.Count()}");
            }
            Console.WriteLine("---------------------------------------------------------------------------------");


            // 10. Total number of employees based on city and title
            Console.WriteLine("Total number of employees based on city and title:");
            var cityTitleGroup = empList.GroupBy(emp => new { emp.City, emp.Title });
            foreach (var group in cityTitleGroup)
            {
                Console.WriteLine($"{group.Key.City} - {group.Key.Title}: {group.Count()}");
            }
            Console.WriteLine("---------------------------------------------------------------------------------");


            // 11. Total number of employees who is youngest in the list
            DateTime currentDate = DateTime.Now;
            int minAge = empList.Min(emp => (currentDate - emp.DOB).Days);
            var youngestEmployees = empList.Where(emp => (currentDate - emp.DOB).Days == minAge);
            Console.WriteLine("Youngest employee(s) in the list:");
            foreach (var emp in youngestEmployees)
            {
                Console.WriteLine($"{emp.FirstName} {emp.LastName}");
            }
            Console.WriteLine();
            Console.Read();
        }
    }
}
