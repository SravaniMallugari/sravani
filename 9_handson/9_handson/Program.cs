using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ClassLibrary1;

namespace _9_handson
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Thread thr = new Thread(class1.Job);
            
            thr.Start();
            Console.ReadLine(); 

        }
    }
}
