using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Handson
{
    internal class maxandmin
    {
        static void Main(string[] args)
        {


            int a, b, mini, maxi;

            Console.Write("input first number : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            b = Convert.ToInt32(Console.ReadLine());


            if (a > b)
            {
                maxi = a;
            }
            else
            {
                maxi = b;
            }


            if (a < b)
            {
                mini = a;
            }

            else
            {
                mini = b;
            }
                
            Console.WriteLine("Minimum number = {0}", mini);
            Console.WriteLine("Maximum number = {0}", maxi);


            Console.ReadLine();
        }
    }
}

       