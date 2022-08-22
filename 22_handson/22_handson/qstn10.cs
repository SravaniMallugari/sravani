using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_handson
{
    internal class qstn10
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> Mydict = new Dictionary<int, string>();
            Mydict.Add(1, "hi");
            Mydict.Add(2, "hello");
            Mydict.Add(3, "folks");

            foreach (KeyValuePair<int, string> elem in Mydict)
            {
                Console.WriteLine("{0} and {1}", elem.Key, elem.Value);
                          
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
