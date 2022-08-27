using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using products;

namespace _26_handson
{
    internal class qstn3
    {
        static void Main(string[] args)
        {
            List<int> productlist = new List<int>();
            List<string> product_namelist = new List<string>();
            productlist.Add(1);
            productlist.Add(2);
            productlist.Add(3);
            //productIDlist.Add(3);
            product_namelist.Add("colgate");
            product_namelist.Add("closeup");
            product_namelist.Add("pepsodyne");
            foreach (var i in productlist)
            {
                Console.WriteLine(i);
            }
            foreach (var j in product_namelist)
            {
                Console.WriteLine(j);
            }
            int indexToRemove = 1;
            productlist.Remove(indexToRemove);
            foreach (var i in productlist)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
        }
}
