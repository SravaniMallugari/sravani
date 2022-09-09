using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class class1
    {
        public static void  Job()
        {
            Console.WriteLine("My thread is" +
                        " in progress...!!");

            for (int z = 0; z < 10; z++)
            {
                Console.WriteLine(z);
            }
        }
    }
}
