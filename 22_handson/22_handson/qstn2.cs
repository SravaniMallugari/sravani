using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_handson
{
    internal class qstn2
    {
            static void Main(string[] args)
            {
                int[] array = new int[10];
                int i;
                Console.WriteLine("enter the elements");
                for (i = 0; i < 10; i++)
                {
                    Console.Write("arr{0} =", i);
                    array[i] = Convert.ToInt32(Console.ReadLine());
                }

                Console.WriteLine("the Elements stored  in array are: ");
                Console.WriteLine("before sorting the elements are");
                Array.Sort(array);
                for (i = 0; i < 10; i++)
                {
                    Console.Write("{0}  ", array[i]);
                }
                Array.Reverse(array);

                Console.WriteLine(" after  reversing the elements are");
                for (i = 0; i < 10; i++)
                {
                    Console.WriteLine("{0}  ", array[i]);
                }

                Console.WriteLine();
                Console.ReadKey();
            }
        }
    }



