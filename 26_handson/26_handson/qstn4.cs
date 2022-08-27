using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_handson
{
    internal class qstn4
    {
        static void Main(string[] args)
        {
            //AddAfter,AddBefore, Previous,Next, AddFirst, AddLast and Find.
            LinkedList<string> list = new LinkedList<string>();
            list.AddFirst("start");
            list.AddLast("end");

            list.AddAfter(list.First, "this is  from add after method");
            list.AddBefore(list.Last, "this is from add before method");
            list.AddBefore(list.Last.Previous, "this is from last.previous  method");
            list.AddBefore(list.First.Next, "this is from last.next  method");
            LinkedListNode<string> foundnode = list.Find("end");
            foundnode.Value = "start";
           
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        

        }
    }
}
