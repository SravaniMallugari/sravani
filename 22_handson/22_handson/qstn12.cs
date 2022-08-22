using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_handson
{
    internal class qstn12
    {
        static void Main(string[] args)
        {
            int[] array = new int[100];
            int i, maxi, mini, n;
            Console.Write("enter  the number of elements to be stored in the array :");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input {0} elements in the array :", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                array[i] = Convert.ToInt32(Console.ReadLine());
            }


            maxi = array[0];
            mini = array[0];

            for (i = 1; i < n; i++)
            {
                if (array[i] > maxi)
                {
                    maxi = array[i];
                }


                if (array[i] < mini)
                {
                    mini = array[i];
                }
            }
            Console.WriteLine(" the maximum element in the arraty is : {0}", maxi);
            Console.WriteLine("the minimum element in the array is : {0}", mini);
            Console.ReadLine();
        }
       
    }
}
    
