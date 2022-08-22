using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Handson
{
    internal class numberssum
    {
        static void Main(string[] args)
        {
            double i, sum = 0;
            
           for (i = 101; i < 200; i++)
            {
               
                
                    Console.Write("{0} ", i);
                    sum += i;
                
            }
            Console.WriteLine("The sum is  : {0} ", sum);
            Console.ReadLine();
        }
    }
}
