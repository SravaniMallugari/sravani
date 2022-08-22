using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qstn6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1;
            Console.Write("Enter your age ");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You look older than " + "" + number1);
            Console.ReadLine();
        }
    }
}
