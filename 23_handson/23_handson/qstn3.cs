using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_handson
{
    internal class qstn3
    {
        struct employee
        {
            public int Emplyno;
            public string Emplyname;
            public int Emplysalary;
            public int Emplydeptno;
        };

        public class program
        {
            public static void Main(string[] args)
            {
                employee emply1;
                employee emply2;

                emply1.Emplyno = 01;
                emply1.Emplyname = "sravs";
                emply1.Emplysalary = 27000;
                emply1.Emplydeptno = 412;

                emply2.Emplyno = 02;
                emply2.Emplyname = "isra";
                emply2.Emplysalary = 28000;
                emply2.Emplydeptno = 413;
                Console.WriteLine("Employee-1 details");
                Console.WriteLine(emply1.Emplyno);
                Console.WriteLine(emply1.Emplyname);
                Console.WriteLine(emply1.Emplysalary);
                Console.WriteLine(emply1.Emplydeptno);
                Console.WriteLine("Employee-2 details");
                Console.WriteLine(emply2.Emplyno);
                Console.WriteLine(emply2.Emplyname);
                Console.WriteLine(emply2.Emplysalary);
                Console.WriteLine(emply2.Emplydeptno);



                Console.ReadKey();
            }
        }
    }
}

