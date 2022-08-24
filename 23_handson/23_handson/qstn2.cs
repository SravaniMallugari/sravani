using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_handson
{
    internal class qstn2
    {
        
       
            public static int add(int a, int b)
            {
                return (a + b);
            }

            public static void Main()
            {
                int a, b;
                int sum;

                Console.Write("Enter first number: ");
                a = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter second number: ");
                b = Convert.ToInt32(Console.ReadLine());

                sum = add(a, b);

                Console.WriteLine("Sum of two numbers is " + sum);
                Console.ReadLine();
            }
        }
    }

