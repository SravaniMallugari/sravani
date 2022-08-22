using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_handson
{
    internal class qstn6
    {
        static void Main(string[] args)
        {
            Stack<int> stack1 = new Stack<int>();
            stack1.Push(10);
            stack1.Push(20);
            stack1.Push(30);
            stack1.Push(40);
            stack1.Push(50);
            Console.WriteLine($"No.of.elements in stack:" + stack1.Count);
            Console.WriteLine("the elements in the stack are :");

            stack1.Push(0);
            foreach (var item in stack1)
            {
                Console.WriteLine(item + "\t");
            }
            Console.WriteLine("top element:" + stack1.Peek());
            stack1.Pop();
            stack1.Pop();
            Console.WriteLine("top element:" + stack1.Peek());
            Console.ReadLine();
        }
    }
}
