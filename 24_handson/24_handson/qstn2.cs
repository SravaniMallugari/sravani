using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_handson
{
    internal class qstn2
    {
        static void Main(string[] args)
        {
            String s1;
            String s2;
            Console.Write("Enter string : ");
            s1 = Console.ReadLine();
            s2 = String.Copy(s1);
            Console.WriteLine("Value is str1 : " + s1);
            Console.WriteLine("Value of str2 : " + s2);
            Console.ReadLine();
        }
    }
}
