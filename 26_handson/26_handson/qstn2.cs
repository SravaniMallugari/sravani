using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using products;

namespace _26_handson
{
    internal class qstn2
    {
        static void Main(string[] args)
        {
            {
                
                Class_stud[] s = new Class_stud[1];
                for (int i = 0; i < s.Length; i++)
                {
                    
                    s[i] = new Class_stud();
                    Console.WriteLine("enter the employee details");
                    Console.WriteLine("Enter employee id:");
                    s[i].emplyid = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter employee Name:");
                    s[i].EmplyName = Console.ReadLine();
                    Console.WriteLine("Enter employee Age:");
                    s[i].Emplyage = Convert.ToInt32(Console.ReadLine());
                }
                foreach (var item in s)
                {
                    Console.WriteLine(" are the details");
                    Console.WriteLine(item.emplyid);
                    Console.WriteLine(item.EmplyName);
                    Console.WriteLine(item.Emplyage);


                }
                Console.ReadLine();

            }
        }
    }
    }

