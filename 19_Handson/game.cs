using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Handson
{
    internal class game
    {
        static void Main(string[] args)
        {
            int total = 100;
            int obj = 0;    
            string input;

            while (obj < 4)
            {
                input = Console.ReadLine();


                if (input.Equals("HIT"))
                {
                    total = total + 10;

                }
                else if (input.Equals("MISS"))
                {
                    total = total - 20;


                }


                obj++;

            }
                Console.WriteLine(total);
                Console.ReadLine();
            
        }
    }
}
