using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary2;


namespace _6_handson

{
    internal class program
    {

        static void Main(string[] args)
        {
            person p;
            p = new employees();
            p.work();
            p = new manager();
            p.work();
            p = new clerk();
            p.work();    
            Console.WriteLine("---------1st qstn ended--------------------------------");
            bank b1 = new bank();
            b1.print_balance();
            b1.calc_interest();     
            Console.WriteLine("--------2nd qstn ended---------");
            Console.WriteLine("savings account");
            banks b = new savi();
            b.print_balance();
            b.calc_interest();
            Console.WriteLine("current aacount");
            banks b2 = new current();
            b2.print_balance();
            b2.calc_interest();       
            Console.WriteLine("----------------3rd and 4th qstns ended-------------");
            bankss g = new bankss();



            g.current();
            g.savings();
            g.deposits();
            g.withdraw();
            g.total_balc();
            g.deposits1();
            g.withdraw1();
            g.total_balc1();             


            Console.WriteLine("---------5 and 6 qstns ended----------------");






        }
    }
}

