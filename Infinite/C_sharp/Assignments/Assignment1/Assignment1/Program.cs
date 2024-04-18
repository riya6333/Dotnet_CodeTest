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


            Console.WriteLine("Enter value of n1");
            int n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter value of n2");
            int n2 = Convert.ToInt32(Console.ReadLine());

            if (n1 == n2)
            {
                Console.WriteLine("n1 and n1 are equal");
            }
            else
            {
                Console.WriteLine("n1 and n1 are not equal");
            }
            Console.ReadLine();

            Program program = new Program();
            
            program.Avg();
            /*
              program.Positive();
              program.Operations();
            
              program.Multiple();
              program.Sum();

             
              program.TenMarks();
              program.TwoArray();
              program.String();
              program.StringReverse();
              program.SameString();
             */
        }
        /*
                public void Positive()
                {
                    Console.WriteLine("Enter value of No.");
                    int n = Convert.ToInt32(Console.ReadLine());

                    if (n >= 0)
                    {
                        Console.WriteLine("n is Positive");
                    }
                    else
                    {
                        Console.WriteLine("Given no. is negative");
                    }
                    Console.ReadLine();
                }


                public void Operations() {
                    int Num1, Num2, option,result;

                    Console.Write("Enter the First Number : ");
                    Num1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter the Second Number : ");
                    Num2 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("1. Addition");
                    Console.WriteLine("2. Subtraction");
                    Console.WriteLine("3. Multiplication");
                    Console.WriteLine("4. Division");
                    Console.Write("Enter the Operation you want to perform : ");
                    option = Convert.ToInt32(Console.ReadLine());
              switch (option)
                    {
                        case 1:
                            result = Num1 + Num2;
                            Console.WriteLine("The result of Addition is : {0}", result);
                            break;
                        case 2:
                            result = Num1 - Num2;
                            Console.WriteLine("The result of Subtraction is : {0}", result);
                            break;
                        case 3:
                            result = Num1 * Num2;
                            Console.WriteLine("The result of Multiplication is : {0}", result);
                            break;
                        case 4:
                            result = Num1 / Num2;
                            Console.WriteLine("The result of Division is : {0}", result);
                            break;
                        default:
                            Console.WriteLine("Invalid Option");
                            break;
                    }
                    Console.ReadLine();
                }

                  public void Multiple()
                  {
                       Console.WriteLine("Enter value of n1");
                       int n1 = Convert.ToInt32(Console.ReadLine());

                       for (int i = 0; i <= 10; i++)
                          {
                              Console.WriteLine(n1 + " * " + i + " = " + i * n1);
                           }
                        Console.ReadLine();
                    }


              public void Sum()
              {
                   Console.WriteLine("Enter value of n1");
                   int n1 = Convert.ToInt32(Console.ReadLine());
                   Console.WriteLine("Enter value of n2");
                   int n2 = Convert.ToInt32(Console.ReadLine());

                  if (n1 == n2)
                  {
                      Console.WriteLine("n1 and n1 are equal " + 3 * (n1 + n2));
                  }
                  else
                  {
                      Console.WriteLine("n1 and n1 are equal " + (n1 + n2));
                  }
                  Console.ReadLine();
              }

          
        public void Day()
            {
                    int Num, result;
                Console.WriteLine("1. Monday");
                Console.WriteLine("2. Tuesday");
                Console.WriteLine("3. Wednesday");
                Console.WriteLine("4. Thursday");
                Console.WriteLine("5. Friday");
                Console.WriteLine("6. Saturday");
                Console.WriteLine("7. Sunday");

            Console.Write("Enter the  Number : ");
            Num = Convert.ToInt32(Console.ReadLine());
            result = Num % 7;
            string day = "";
            switch (result)
                {
                    case 1:
                        day = "Monday";
                        break;
                    case 2:
                        day = "Tueday";
                        break;
                    case 3:
                        day = "Wednesday";
                        break;
                    case 4:
                        day = "Thursday";
                        break;
                    case 5:
                        day = "Friday";
                        break;
                    case 6:
                        day = "Saturday";
                        break;
                    case 0:
                        day = "Sunday";
                        break;
                    default:
                        Console.WriteLine("Invalid input.");
                        break;
                }

                Console.WriteLine(day);
                Console.ReadLine();
            }
        */
        
    public void Avg()
            {
            int i, mx, mn, n, sum = 0;
            float avg = 0.0F;
            Console.Write("Input number of elements in array :");
            n = Convert.ToInt32(Console.ReadLine());

            int[] arr1 = new int[n];

            Console.Write("Input {0} elements in the array : ", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());

            }
            mx = arr1[0];
            mn = arr1[0];

            for (i = 0; i < n; i++)
            {
                if (arr1[i] > mx)
                {
                    mx = arr1[i];
                }

                if (arr1[i] < mn)
                {
                    mn = arr1[i];
                }
            }

            Console.WriteLine("Maximum element is : {0} ", mx);
            Console.WriteLine("Minimum element is : {0} ", mn);
            for (i = 0; i < arr1.Length; i++)
            {
                sum += arr1[i];
            }

            avg = (float)sum / arr1.Length;

            Console.WriteLine("Average of Array elements: " + avg);

            Console.Read();

        }
        /*
            public void TenMarks()
            {

                int i, mx, mn, sum = 0;
                float avg = 0.0F;


                Console.Write("Input the number of elements to be stored in the array :");



                int[] arr1 = new int[10];

                for (i = 0; i < 10; i++)
                {
                    Console.Write("element - {0} : ", i);
                    arr1[i] = Convert.ToInt32(Console.ReadLine());

                }
                mx = arr1[0];
                mn = arr1[0];

                // Finding maximum and minimum elements
                for (i = 1; i < 10; i++)
                {
                    if (arr1[i] > mx)  // If current element is greater than the current maximum
                    {
                        mx = arr1[i];  // Update maximum
                    }

                    if (arr1[i] < mn)  // If current element is smaller than the current minimum
                    {
                        mn = arr1[i];  // Update minimum
                    }
                }



                for (i = 0; i < 10; i++)
                {
                    sum += arr1[i];
                }

                avg = (float)sum / 10;

                Console.WriteLine("Total Marks: " + sum);
                Console.WriteLine("Average Marks: " + avg);
                Console.WriteLine("Maximum element is :  " + mx);
                Console.WriteLine("Minimum element is :  " + mn);
                Console.WriteLine("Display Marks in ascending order :  ");
                System.Array.Sort(arr1);
                for (i = 0; i < arr1.Length; i++)
                {
                    Console.WriteLine(arr1[i]);
                }
                Console.WriteLine("Display Marks in descending order :  ");
                Array.Reverse(arr1);
                for (i = 0; i < arr1.Length; i++)
                {
                    Console.WriteLine(arr1[i]);
                }
                Console.Read();
            }

            public void TwoArray()
            {

                int[] array1 = { 1, 2, 3 };
                int n = array1.Length;
                int i;
                int[] array2 = new int[n];

                for (i = 0; i < n; i++)
                {
                    array2[i] = array1[i];
                }
                Console.WriteLine(" The elements stored in the first array are: ");
                for (i = 0; i < n; i++)
                {
                    Console.Write("{0}  ", array1[i]);
                }

                // Display the elements copied into the second array 'arr2'
                Console.WriteLine("The elements copied into the second array are:");
                for (i = 0; i < n; i++)
                {
                    Console.Write("{0}  ", array2[i]);
                }
                Console.Read();
            }

            public void String()
            {
                Console.WriteLine("Enter name:");
                string Name = Console.ReadLine();
                Console.WriteLine("Username is: " + Name);
                Console.WriteLine("Length of name: " + Name.Length);
                Console.Read();
            }


      public void StringReverse()
      {
          Console.WriteLine("Enter name:");
          string Name = Console.ReadLine();
          Console.WriteLine("Username is: " + Name);
          char[] charArray = Name.ToCharArray();
          Array.Reverse(charArray);
          Console.WriteLine(charArray);
          Console.Read();
      }
      */
        public void SameString()
        {
            Console.WriteLine("Enter String1");
            string str1 = Console.ReadLine();
            Console.WriteLine("Enter String2");
            string str2 = Console.ReadLine();
            if (str1.Equals(str2))
            {
                Console.WriteLine("Same");
            }
            else
            {
                Console.WriteLine("Not Same");
            }
            Console.ReadLine();
        }






        
    }
}
