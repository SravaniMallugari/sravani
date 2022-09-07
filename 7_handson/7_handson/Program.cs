using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static _7_handson.Program;


namespace _7_handson
{
    internal class Program
    {
        public delegate string stren5(string spo, string spo1);
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the string");
            string m = Console.ReadLine();
            strin s1 = new strin();
            str1 s2 = new str1(s1.lengthofstring);
            s2(m);
           Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Enter  the username to greet");//2
            string g = Console.ReadLine();
            str1 s3 = new str1(s1.greet);
            s3(g);
            Console.ForegroundColor= ConsoleColor.Green;
            Console.WriteLine("Enter the two numbers to do calculations");//3
            int yu = Convert.ToInt32(Console.ReadLine());
            int uy = Convert.ToInt32(Console.ReadLine());
            integer mi = new integer();
            str2[] d3 = new str2[3] { mi.Add, mi.Sub, mi.Multiply };
            str2 d4 = (str2)MulticastDelegate.Combine(d3);
            d4(yu, uy);
            Console.ForegroundColor = ConsoleColor.Magenta; 
            Console.WriteLine("Enter productId and product name");
            Products mo = new Products();
            mo.PId = Convert.ToInt32(Console.ReadLine());
            mo.Name = Console.ReadLine();
            str3 poi = new str3(mo.Display);
            poi(mo);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Enter the year,Month,date");
            int year = Convert.ToInt32(Console.ReadLine());
            int month = Convert.ToInt32(Console.ReadLine());
            int date = Convert.ToInt32(Console.ReadLine());
            Employee emp = new Employee();
            DateTime dt = new DateTime(year, month, date);
            emp.Joining = dt;
            str4 se = new str4(emp.Expyrs);
            int po = se(emp.Joining);
            Console.WriteLine($"Years of exp {po}");
            Console.ForegroundColor=ConsoleColor.White;
            Console.WriteLine("Enter strings to Concatenate");
            string yum = Console.ReadLine();
            string muy = Console.ReadLine();
            stren5 dpo = delegate (string so, string su)
            {
                return so + su;
            };
            string sod = dpo(yum, muy);
            Console.WriteLine($"Concatenated string is {sod}");
            Console.ReadLine();
        }
    }
}
