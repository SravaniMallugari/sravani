using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace filesdemo
{
    internal class qstn1
    {
        static void Main(string[] args)
        {
            string path = @"C:\\dotnet\\filesdemo\\filesdemo";
            Console.WriteLine("Enter the file name");
            string fname = Console.ReadLine();


            fname = string.Concat(path, fname);    

            FileStream fs = new FileStream(fname, FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);

            sw.WriteLine("this is from append method");
            sw.Close();
            fs.Close();
            Console.WriteLine(" appended  successfully...");  
            Console.WriteLine("-----------------------");
            FileStream fs1 = new FileStream(fname, FileMode.Truncate);
            StreamWriter ss1 = new StreamWriter(fs1);

            ss1.WriteLine("this is my new file ");
            ss1.Close();
            fs1.Close();
            Console.WriteLine(" Truncated  successfully...");    

            Console.ReadLine();
        }
    }
}

