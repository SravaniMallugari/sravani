using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace logicofapp
{
    public class sampleclass
    {
        public static void Greet()
        {
            Console.WriteLine("helloyaar");

        }
        public static void Makefile()
        {
            string path = @" C:\dotnet\filehandling\firstfile.txt";
            File.Create(path);
                

            
        }

    }
}
