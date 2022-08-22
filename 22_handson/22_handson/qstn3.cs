using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_handson
{
    internal class qstn3
    {
        static void Main(string[] args)
        {
            int[] array = new int[3];
            int i,sum=0;
            Console.WriteLine("enter the elements");
            for (i = 0; i < 3; i++)
            {
                Console.Write("arr{0} =", i);
                array[i] = Convert.ToInt32(Console.ReadLine());


            }
            
            Console.WriteLine("the Elements stored  in array are: ");
            for (i = 0; i < 3; i++)
            {
                sum = sum + array[i];   
                Console.WriteLine("afer the sum the elements are {0}:{1}", array[i],sum);
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}

