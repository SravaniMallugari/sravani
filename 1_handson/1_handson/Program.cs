using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_handson
{
    internal class Program

    {
        static void Main(string[] args)
        {
            Console.WriteLine("----Taken Array-----");
            int[] MyArray = { 20, 5, 1000, 45, -2, 31, 27 };
            
            PrintArray(MyArray);

            shellsort(MyArray);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("---Sorted Array----");
            PrintArray(MyArray);
            Console.ReadLine();
        }
        static void shellsort(int[] Array)
            {
                int n = Array.Length;
                int gap = n / 2;
                int temp, i, j;
                while (gap > 0)
                {
                    for (i = gap; i < n; i++)
                    {
                        temp = Array[i];
                        j = i;
                        while (j >= gap && Array[j - gap] > temp)
                        {
                            Array[j] = Array[j - gap];
                            j = j - gap;
                        }
                        Array[j] = temp;
                    }
                    gap = gap / 2;
                }
            }

           
            static void PrintArray(int[] Array)
            {
                int n = Array.Length;
                for (int i = 0; i < n; i++)
                    Console.Write(Array[i] + " ");
                Console.Write("\n");
            }

            
            
        }
    }