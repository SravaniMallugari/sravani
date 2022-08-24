using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_handson
{
    internal class qstn7
    {
        static void Main(string[] args)
        {
            //year, month, day, hour, minute, second, millisecond etc.
            DateTime dt1 = new DateTime();
            dt1 = DateTime.Now;
            Console.WriteLine(dt1);
            Console.WriteLine("year" + dt1.Year);
            Console.WriteLine("month" + dt1.Month);
            Console.WriteLine("day" + dt1.Day);
            Console.WriteLine("hour" + dt1.Hour);
            Console.WriteLine("minute" + dt1.Minute);
            Console.WriteLine("second" + dt1.Second);
            Console.WriteLine(" millisecond" +dt1.Millisecond);
            Console.ReadLine();
        }
    }
}
