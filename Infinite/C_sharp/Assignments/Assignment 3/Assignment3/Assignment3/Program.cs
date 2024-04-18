using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3

{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first name : ");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter the last name: ");
            string lastName = Console.ReadLine();

            Program program = new Program();
            program.Display(firstName, lastName);
            Console.WriteLine();

            Console.WriteLine("Enter the string : ");
            string inputString = Console.ReadLine();

            Console.Write("Enter the letter to see their occurence : ");
            char letterToCount = Console.ReadKey().KeyChar;

            Console.WriteLine();

            OccurencesOfLetter obj = new OccurencesOfLetter();
            int count=obj.displayInfo(inputString, letterToCount);

            Console.WriteLine("Number of occurrences of " + letterToCount + " in the string: " +count);
            Console.ReadLine();
            Console.WriteLine();

            try
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

                account.UpdateBalance(transactionType, amount);
                account.ShowData();
                Console.ReadLine();
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Invalid input format. Please enter a valid input.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message); 
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            Console.ReadLine();
            

            Scholarship scholarship = new Scholarship();

            Console.WriteLine("Enter marks:");
            double marks = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter fees:");
            double fees = double.Parse(Console.ReadLine());

            double scholarshipAmount = scholarship.Merit(marks, fees);
            Console.WriteLine("Scholarship Amount: " + scholarshipAmount);
            Console.ReadLine();

            Doctor doctor = new Doctor();

            Console.WriteLine("Enter Registration Number:");
            int regnNo = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Fees Charged:");
            double feesCharged = double.Parse(Console.ReadLine());

            doctor.SetValues(regnNo, name, feesCharged);
            Console.WriteLine();
            doctor.Display();
        }
        public  void Display(string firstName, string lastName)
        {
            Console.WriteLine("First Name : " + firstName.ToUpper());
            Console.WriteLine("Last Name : " + lastName.ToUpper());
            Console.ReadLine();
        }
    }
}
