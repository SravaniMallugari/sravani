using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dollarinruppee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double dollar = 0;
            double rupee = 0;
            double value = 0;

            Console.Write("Enter amount in dollar: ");
            dollar = double.Parse(Console.ReadLine());

            Console.Write("Enter the dollar value :");
            value = double.Parse(Console.ReadLine());

            rupee = dollar * value;
            Console.WriteLine("dollar  " + dollar + "rupee " + rupee);
            Console.ReadLine();
        }
    }
}
