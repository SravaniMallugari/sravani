using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Handson
{
    internal class oddnatural
    {
        static void Main(string[] args)
        {
            double i, num, sum = 0;
          
            Console.WriteLine("enter the number of terms : ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The  respective odd numbers are :");
            for (i = 1; i <= num; i++)
            {
                Console.WriteLine("{0} ", 2 * i - 1);
                sum += 2 * i - 1;
            }
            Console.WriteLine("The Sum of odd Natural Numbers are upto {0} terms as : {1} ", num, sum);
            Console.ReadLine();
        }
    }
}
