using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Handson
{
    internal class oddoreven
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input enter your number:");
            int no = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your number is: " + no);
            if (no == 0)
            {
                Console.WriteLine("given num is zero");
            }
            else if (no % 2 == 0)
            {
                Console.WriteLine("given num is even");
                if (no % 10 == 0)
                {
                    Console.WriteLine("given num is a multipe of ten");
                }
                else
                {
                    Console.WriteLine(" given num is a  not multipe of ten");
                }


                if (no > 100)
                {
                    Console.WriteLine("given has num is too large");
                }
                else
                {
                    Console.WriteLine("number is odd");
                }
                if (no > 100)
                {
                    Console.WriteLine("entered number has more digits");
                }
                else
                {
                    Console.WriteLine("it has two digits");
                }
                Console.ReadLine();
            }
            
        }
    }
}
