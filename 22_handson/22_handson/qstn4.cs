using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_handson
{
    internal class qstn4
    {
        static void Main(string[] args)
        {
            ArrayList arrli = new ArrayList() { 1,2,3,4, "hi" };
            arrli.Add(0);
            arrli.Add(9);
            arrli.Add("hello");
            arrli.Remove(2);
            arrli.RemoveAt(3);

            Console.WriteLine(" TheElements in the Arraylist are: ");
            foreach (var item in arrli)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\nCount is : " + arrli.Count);
            Console.ReadLine();
        }
    }
}
