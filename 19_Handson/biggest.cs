using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Handson
{
    internal class biggest
    {
        static void Main(string[] args)
        {
            int a, b, bigger;
            Console.Write("Enter first number : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            b = Convert.ToInt32(Console.ReadLine());
            bigger = (a > b) ? a : b;
            Console.WriteLine("The biggest  number is {0}", bigger);
            Console.ReadLine();

        }
    }
}
