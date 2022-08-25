using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace filesdemo
{
    internal class qstn2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the file name to be created: ");
            string name = Console.ReadLine();

            string path = @"C:\\dotnet\\filesdemo";

            string fname = String.Concat(path, name);
            File.Create(fname);
            string s = "sravs";
            File.WriteAllText(fname, s);
            Console.WriteLine("file copied");
            File.Copy(fname, "newfile.txt");
            Console.WriteLine("file moved");
            File.Move(fname, "movedfile.txt");
            Console.WriteLine("file deleted");
            File.Delete(path);
            FileInfo fileInfo = new FileInfo(fname);
            Console.WriteLine(fileInfo.FullName + "  Full Name");
            Console.WriteLine(fileInfo.DirectoryName + " DirectoryName");
            Console.WriteLine(fileInfo.CreationTime);
            Directory.CreateDirectory("MyDir");
            Console.ReadLine();

        }

    }
}
       
