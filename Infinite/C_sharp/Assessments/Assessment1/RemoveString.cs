using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskCodes
{
    class RemoveString
    {
        public void Remove()
        {
            Console.WriteLine("Program to remove a letter from string at any given position");
            string str;
           
            Console.WriteLine("Enter the string: ");
            str = Console.ReadLine();
            Console.WriteLine("Enter the position to be removed: ");
            int n;
            n = Convert.ToInt32(Console.ReadLine());

            if (n > 0)
            {
                Console.WriteLine(str.Remove(n, 1));

            }
            Console.Read();
        }
    }
}
