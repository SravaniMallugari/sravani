using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_handson
{
    internal class qstn4
    {
        static void Main(string[] args)
        {
            string newStr = "Welcome to the world of C# Programming";
            string[] sep = { "#", "," };
            
            int count = 2;
            string[] result = newStr.Split(sep, count, StringSplitOptions.RemoveEmptyEntries);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
