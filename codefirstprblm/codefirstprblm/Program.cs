using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using dal;


namespace codefirstprblm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyContext context = new MyContext();

            context.Courses.Add(new Course { Courseid = 101, Coursename = "Physics" });
            context.Courses.Add(new Course { Courseid = 102, Coursename = "Chemistry" });
            context.Courses.Add(new Course { Courseid = 103, Coursename = "Biology" });
            context.Courses.Add(new Course { Courseid = 104, Coursename = "Maths" });

            context.SaveChanges();
            Console.WriteLine("Done");
            Console.ReadLine();
        }
    }
}