using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Handson
{
    internal class oddrevenswitch
    {
        static void Main(string[] args)
        {
            int num;

            
            Console.Write("Enter your choice as num : ");
            num = Convert.ToInt32(Console.ReadLine());

            switch (num)
            {
                
                case 0:
                    if(num%2==0)
                    Console.WriteLine(num + " is even number");
                    break;

                
                case 1:
                    if(num %2==0)
                    Console.WriteLine(num + " is odd number");
                    break;
                case 2:
                    if (num % 10 == 0)
                    
                        Console.WriteLine("given num is a multipe of ten");
                    break ;


                case 3:
                    if (num > 100)
                    
                        Console.WriteLine("given has num is too large");
                    
                    break ;

                case 4:
                    if(num %2 !=0)
                    
                        Console.WriteLine("it has two digits");
                    
                    break;

                case 5:
                    Console.WriteLine("your choice is wrong");
                    break;

                   
                
            }

            Console.ReadLine();
        }
    }
}
