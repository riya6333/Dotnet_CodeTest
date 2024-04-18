using System;


    public class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public float Salary { get; set; }

        public Employee(int empId, string empName, float salary)
        {
            EmpId = empId;
            EmpName = empName;
            Salary = salary;
        }

        public void Display()
        {
            Console.WriteLine($"Employee ID: {EmpId}");
            Console.WriteLine($"Employee Name: {EmpName}");
            Console.WriteLine($"Salary: {Salary}");
        }
    }

    public class PartTimeEmployee : Employee
    {
        public float Wages { get; set; }

        public PartTimeEmployee(int empId, string empName, float salary, float wages): base(empId, empName, salary)
        {
            Wages = wages;
        }

        public new void Display()
        {
            base.Display();
            Console.WriteLine($"Wages: {Wages}");
        }
    }

