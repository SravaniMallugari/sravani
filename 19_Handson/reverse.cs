using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Handson
{
    internal class reverse
    {
        static void Main(string[] args)
        {
            int num, rev, sum = 0, temp;
            Console.Write("Enter a no: ");
            num = Convert.ToInt32(Console.ReadLine());

            for (temp = num; temp != 0; temp = temp / 10)
            {
                rev = temp % 10;
                sum = sum * 10 + rev;
            }
            Console.WriteLine("The number in reverse order is : {0} ", sum);
            Console.ReadLine();
        }
    }
}
