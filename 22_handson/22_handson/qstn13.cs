using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_handson
{
    internal class qstn13
    {
        static void Main(string[] args)
        {

            int[] Arr = { 1, 3, 5, 200, 22, 2244, 213, 111 };


            var num = from nums in Arr where nums > 100 select nums;


            Console.WriteLine("The numbers larger than 786 are :");
            foreach (int n in num)
            {
                Console.Write(n + " ");
            }
            Console.ReadLine();
        }
    }
}

