using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Handson
{
    internal class forloop
    {
        static void Main(string[] args)
        {
            for (int i = 0, j = 25; i <25  && j >= 0; i++, j--)
            {


                
                if (i > j)
                {
                    Console.WriteLine("crossed over");
                    break;
                }
               
                Console.WriteLine("FOR: i={0}, j={1}", i, j);
                
            }
            Console.ReadLine();

        }
        }
    }

