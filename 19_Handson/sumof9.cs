using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Handson
{
    internal class sumof9
    {
        static void Main(string[] args)
        {
            double i, sum = 0;
            Console.Write("Numbers between 100-200 which are  divisible by 9 : ");
            for (i = 101; i < 200; i++)
            {
                if (i % 9 == 0)
                {
                    Console.WriteLine("{0} ", i);
                    sum += i;
                }
            }
            Console.WriteLine("The sum : {0} ", sum);
            Console.ReadLine();
        }
    }
}
