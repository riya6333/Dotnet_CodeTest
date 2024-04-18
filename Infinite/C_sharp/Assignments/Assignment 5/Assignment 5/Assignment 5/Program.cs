using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    public class Books
    {
        public string BookName { get; set; }
        public string AuthorName { get; set; }

        public Books(string bookName, string authorName)
        {
            BookName = bookName;
            AuthorName = authorName;
        }

        public void Display()
        {
            Console.WriteLine("Book Name: " + BookName);
            Console.WriteLine("Author Name: " + AuthorName);
        }
    }

    public class BookShelf : IEnumerable<Books>
    {
        private List<Books> books;

        public BookShelf()
        {
            books = new List<Books>();
        }

        public Books this[int index]
        {
            get
            {
                if (index >= 0 && index < books.Count)
                {
                    return books[index];
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
            set
            {
                if (index >= 0 && index < books.Count)
                {
                    books[index] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
        }

        public void AddBook(Books book)
        {
            if (book != null)
            {
                books.Add(book);
            }
            else
            {
                throw new ArgumentNullException("Book cannot be null.");
            }
        }


        public IEnumerator<Books> GetEnumerator()
        {
            return books.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            BookShelf shelf = new BookShelf();

            // Taking input from the user for book details
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter details for Book " + (i + 1) + ":");
                Console.Write("Book Name: ");
                string bookName = Console.ReadLine();
                Console.Write("Author Name: ");
                string authorName = Console.ReadLine();

                // Creating Books object and adding it to the list
                shelf.AddBook(new Books(bookName, authorName));
            }

            // Displaying the details using foreach loop
            Console.WriteLine("\nBook Details:");
            int index = 1;
            foreach (var book in shelf)
            {
                Console.WriteLine("Book " + index++ + ":");
                book.Display();
                Console.WriteLine();
            }
            Console.WriteLine("------------------------------------------------------------------------------");

            Box box1 = GetBoxDetails("Box 1");
            Box box2 = GetBoxDetails("Box 2");

            Console.WriteLine("\nBox 1:");
            box1.Display();
            Console.WriteLine("\nBox 2:");
            box2.Display();

            Box sumBox = Box.Add(box1, box2);
            Console.WriteLine("\nSum of Box 1 and Box 2:");
            sumBox.Display();
            Console.WriteLine("------------------------------------------------------------------------------");


            Employee employee = GetEmployeeDetails("Full-time Employee");
            PartTimeEmployee partTimeEmployee = GetPartTimeEmployeeDetails("Part-time Employee");

            Console.WriteLine("\nDetails of Full-time Employee:");
            employee.Display();

            Console.WriteLine("\nDetails of Part-time Employee:");
            partTimeEmployee.Display();
            Console.WriteLine("------------------------------------------------------------------------------");


            IStudent student1 = GetStudentDetails("Day Scholar");
            IStudent student2 = GetStudentDetails("Resident");

            Console.WriteLine("\nDetails of Day Scholar:");
            student1.ShowDetails();

            Console.WriteLine("\nDetails of Resident:");
            student2.ShowDetails();
            Console.Read();


        }

        //Question2--------------------------------------------------------------------------
        static Box GetBoxDetails(string boxName)
        {
            Console.WriteLine($"Enter dimensions for {boxName}:");
            Console.Write("Length: ");
            double length = Convert.ToDouble(Console.ReadLine());
            Console.Write("Breadth: ");
            double breadth = Convert.ToDouble(Console.ReadLine());
            return new Box(length, breadth);
        }

        //Question3----------------------------------------------------------------------------------------
        static Employee GetEmployeeDetails(string employeeType)
        {
            Console.WriteLine($"Enter details for {employeeType}:");
            Console.Write("Employee ID: ");
            int empId = GetIntegerInput();
            Console.Write("Employee Name: ");
            string empName = Console.ReadLine();
            Console.Write("Salary: ");
            float salary = GetFloatInput();
            return new Employee(empId, empName, salary);
        }

        static PartTimeEmployee GetPartTimeEmployeeDetails(string employeeType)
        {
            Console.WriteLine($"Enter details for {employeeType}:");
            Console.Write("Employee ID: ");
            int empId = GetIntegerInput();
            Console.Write("Employee Name: ");
            string empName = Console.ReadLine();
            Console.Write("Salary: ");
            float salary = GetFloatInput();
            Console.Write("Wages: ");
            float wages = GetFloatInput();
            return new PartTimeEmployee(empId, empName, salary, wages);
        }

        static int GetIntegerInput()
        {
            int result;
            while (!int.TryParse(Console.ReadLine(), out result))
            {
                Console.WriteLine("Invalid input. Please enter an integer:");
            }
            return result;
        }

        static float GetFloatInput()
        {
            float result;
            while (!float.TryParse(Console.ReadLine(), out result))
            {
                Console.WriteLine("Invalid input. Please enter a number:");
            }
            return result;
        }

        //Question
        static IStudent GetStudentDetails(string studentType)
        {
            Console.WriteLine($"Enter details for {studentType}:");
            Console.Write("Student ID: ");
            int studentId = int.Parse(Console.ReadLine());
            Console.Write("Name: ");
            string name = Console.ReadLine();

            IStudent student;

            switch (studentType)
            {
                case "Day Scholar":
                    student = new Dayscholar(studentId, name);
                    break;
                case "Resident":
                    student = new Resident(studentId, name);
                    break;
                default:
                    throw new ArgumentException("Invalid student type.");
            }

            return student;
        }
    }
}
