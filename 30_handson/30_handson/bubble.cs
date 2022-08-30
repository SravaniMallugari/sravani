using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_handson
{
    class Bubble
    {

        static void Main(string[] args)
        {
           

            int[] arr = new int[50]; 
            int n;

            Console.WriteLine("Enter no of elements you want to store in an array");

            n = Convert.ToInt32(Console.ReadLine()); 

            Console.WriteLine("Enter elements in an array");

            for (int i = 1; i <= n; i++)

            {

                arr[i] = Convert.ToInt32(Console.ReadLine());
              

            }
           
            bubbleSort(arr);

            Console.Read();

        }
        static void bubbleSort(int[] arr)
        {

            int temp;
            for (int i = 0; i < (arr.Length) - 1; i++)
            {
                for (int j = 0; j < (arr.Length - 1) - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("the elements after  bubble sort");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
            }


        }

    }
}
