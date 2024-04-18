using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskCodes
{
    class Program
    {
        static void Main(string[] args)
        {
            int N1, N2, N3;
            Console.WriteLine("Enter the three No. :");
            N1 = Convert.ToInt32(Console.ReadLine());
            N2 = Convert.ToInt32(Console.ReadLine());
            N3 = Convert.ToInt32(Console.ReadLine());
            
            if ((N1 > N2) && (N1 > N3))
            {
                Console.WriteLine(+ N1 + " is the greatest no.");
            }
            else if((N2 > N1) && (N2 > N3))
            {
                Console.WriteLine(+N2 + " is the greatest no.");
            }
            else
            {
                Console.WriteLine(+N3 + " is the greatest no.");
            }
            Console.Read();

           
            SwapFirstLastChar.Swap("Riya");
            RemoveString ps = new RemoveString();
            ps.Remove();
        }
       
    }
}
