using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2

{
    public class Accounts
    {
        private int accountNo;
        private string customerName;
        private string accountType;
        private char transactionType;
        private double amount;
        private double balance;

        public Accounts(int accountNo, string customerName, string accountType)
        {
            this.accountNo = accountNo;
            this.customerName = customerName;
            this.accountType = accountType;
            this.balance = 0.0; 
        }

        public void Credit(double amount)
        {
            balance += amount;
        }
        public void Debit(double amount)
        {
            if (amount <= balance)
            {
                balance -= amount; 
            }
            else
            {
                Console.WriteLine("Insufficient funds!");
            }
        }

        public void UpdateBalance(char transactionType, double amount)
        {
           
            this.transactionType = transactionType;
             this.amount = amount;

            if (transactionType == 'D')
            {
                Credit(amount); 
            }
            else if (transactionType == 'W')
            {
                Debit(amount); 
            }
            else
            {
                Console.WriteLine("Invalid transaction type!");
            }
        }
        public void ShowData()
        {
            Console.WriteLine("Account Number: " +accountNo);
            Console.WriteLine("Customer Name: " +customerName);
            Console.WriteLine("Account Type: " +accountType);
            Console.WriteLine("Transaction Type: " +transactionType);
            Console.WriteLine("Amount: " +amount);
            Console.WriteLine("Balance: " +balance);
            Console.ReadLine();
        }

       
        public static void Main(string[] args)
        {

            Console.WriteLine("Enter Account Number:");
            int accountNo = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Customer Name:");
            string customerName = Console.ReadLine();

            Console.WriteLine("Enter Account Type:");
            string accountType = Console.ReadLine();

            Accounts account = new Accounts(accountNo, customerName, accountType);

            Console.WriteLine("Enter Transaction Type (D for Deposit, W for Withdrawal):");
            char transactionType = char.Parse(Console.ReadLine());

            Console.WriteLine("Enter Amount:");
            double amount = double.Parse(Console.ReadLine());
            Console.WriteLine();

            account.UpdateBalance( transactionType, amount);
            account.ShowData();
            Console.ReadLine();

            Console.Write("Enter Roll No.:");
            int rollNo = int.Parse(Console.ReadLine());
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Class Name: ");
            string className = Console.ReadLine();
            Console.Write("Enter Semester: ");
            int semester = int.Parse(Console.ReadLine());
            Console.Write("Enter Branch: ");
            string branch = Console.ReadLine();
            Student student = new Student(rollNo,  name, className, semester, branch);
            student.GetMarks();
            Console.WriteLine();
            student.DisplayResult();
            student.DisplayData();
            Console.ReadLine();

            Console.WriteLine("Enter Sales Number:");
            int salesNo = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Product Number:");
            int productNo = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Price:");
            double price = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter Quantity:");
            int qty = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Date of Sale (yyyy-mm-dd):");
            DateTime dateOfSale = DateTime.Parse(Console.ReadLine());


            Saledetails sale = new Saledetails(salesNo, productNo, price, dateOfSale, qty);

            Console.WriteLine();
            sale.ShowData();
            Console.ReadLine();

            Console.WriteLine("Enter Customer ID:");
            int customerId = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Customer Name:");
            string Cust_name = Console.ReadLine();

            Console.WriteLine("Enter Age:");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Phone:");
            string phone = Console.ReadLine();

            Console.WriteLine("Enter City:");
            string city = Console.ReadLine();


            Customer customer = new Customer(customerId, Cust_name, age, phone, city);
            Console.WriteLine();
            customer.DisplayCustomer();
            Console.WriteLine("\nDisplaying customer details using static method:");
            Customer.DisplayCustomerStatic(customer);


        }
    }
}
