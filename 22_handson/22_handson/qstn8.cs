using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _22_handson
{
    internal class qstn8
    {
        static void Main(string[] args)
        {
            Hashtable fruits = new Hashtable();
            fruits.Add(1, "apple");
            fruits.Add(2, "banana");
            fruits.Add(3, "guava");
            foreach(DictionaryEntry de in fruits)
             Console.WriteLine( "Key {0},Value:{1 }", de.Key,de.Value );

            Console.ReadLine();
        }

    }
}
