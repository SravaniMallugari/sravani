using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_handson
{
    internal class qstn6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("department of purchase=" + (int)deptname.purchase);
            Console.WriteLine("department of sales=" + (int)deptname.sales);
            Console.WriteLine("department of training=" + (int)deptname.training);
            Console.WriteLine("department of account=" + (int)deptname.account);

            Console.ReadLine();
        }
        enum deptname
        {
            purchase = 1,
            sales,
            training,
            account

        }
    }
}







        
           

        
        

