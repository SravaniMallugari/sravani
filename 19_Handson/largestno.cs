using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Handson
{
    internal class largestno
    {
        static void Main(string[] args)
        {
                int a, b,c, maxi;

                Console.Write("input first number : ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("input second number: ");
                b = Convert.ToInt32(Console.ReadLine());
                Console.Write("input third number : ");
                c = Convert.ToInt32(Console.ReadLine());


            if (a > b && a > c)
                maxi = a;
            else if (b > a && b > c)
                maxi = b;
            else
                maxi = c;

            Console.WriteLine("among the three numbers lagergest number is = {0}", maxi);
            Console.ReadLine();
            }
        }
    }



