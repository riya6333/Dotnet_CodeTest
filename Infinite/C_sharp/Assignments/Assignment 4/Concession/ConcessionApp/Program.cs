using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcessionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your age:");
            int age = int.Parse(Console.ReadLine());

            Concession.TicketConcession.CalculateConcession(age, name);

            Console.WriteLine("-------------------------------------------------------------------------------------------");

            //Lamda exp1

            Console.WriteLine("Enter numbers separated by spaces:");
            string input = Console.ReadLine();
            string[] inputNumbers = input.Split( ',');

            List<int> numbers = new List<int>();
            foreach (string num in inputNumbers)
            {
                if (int.TryParse(num, out int parsedNum))
                {
                    numbers.Add(parsedNum);
                }
                else
                {
                    Console.WriteLine($"Invalid input: {num}");
                }
            }

            SquareNo sn = new SquareNo();
            List<int> squaresGreaterThan20 = sn.GetSquaresGreaterThan20(numbers);

            Console.WriteLine("Numbers whose squares are greater than 20:");
            foreach (int square in squaresGreaterThan20)
            {
                Console.WriteLine(square);
            }

            Console.WriteLine("-------------------------------------------------------------------");

            //Lamda exp2

            Console.WriteLine("Enter words separated by commas (,):");
            string input1 = Console.ReadLine();
            List<string> inputWords = input1.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            WordCollection Output = new WordCollection();
            List<string> filteredWords = Output.filteredWords(inputWords);

            Console.WriteLine("Words starting with 'a' and ending with 'm':");
            foreach (string word in filteredWords)
            {
                Console.WriteLine(word);
            }
            Console.Read();
        }
    }
}
