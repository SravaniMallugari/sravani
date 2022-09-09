using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _9_handson
{
    internal class prioritydemo
    {
    

        static public void Main()
        {

           
            Thread T1 = new Thread(m1);
            Thread T2 = new Thread(m2);

           
            T1.Priority = ThreadPriority.Lowest;
            T2.Priority = ThreadPriority.Highest;
            T1.Start();
            T2.Start();
            Console.ReadLine();
        }
        public static void m1()
        {

            Console.WriteLine("My 1st thread..");
        }
        public static void m2()
        {

            Console.WriteLine("my 2nd thread..");

        }
        
    }

}

