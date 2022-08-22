using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Handson
{
    internal class leapyear
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input enter the year to check : ");
            int Year = int.Parse(Console.ReadLine());
            if (((Year % 4 == 0) && (Year % 100 != 0)) || (Year % 400 == 0)) 
                Console.WriteLine("{0} the given year is a Leap Year.", Year);
            else 
                Console.WriteLine("{0} the given year is  not a Leap Year.", Year);
            Console.ReadLine();
        }
    }
}
