using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qstn12
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
             
            Console.WriteLine("Enter the distance of meter : ");
           int  meter = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the disance  of kilometer : ");
            int km = Int32.Parse(Console.ReadLine());
           double  KM = meter / 1000;
             int meter  = km * 1000;
            Console.WriteLine(" the distance in Kilometer {0} " + km + "km");
            Console.WriteLine(" the distance in Meter {0} " + meter + "m");

            
            }

          
        }

    }


