using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskCodes
{
    class SwapFirstLastChar
    {
       
        public static void Swap(String str)
        {
            Console.WriteLine($" orginal String{str}");
            if (str.Length > 1)
            {

                Console.WriteLine(str.Substring(str.Length - 1) + str.Substring(1, str.Length - 2) + str.Substring(0, 1));

            }
            else
            {
                Console.WriteLine(str);
            }
        }
    }
   
       
     

    
}
