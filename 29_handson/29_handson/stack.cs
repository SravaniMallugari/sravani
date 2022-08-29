using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_handson
{
    internal class stack
    {
        static void Main(string[] args)
        {
            Userstack<string> st = new Userstack<string>();
            st.Push("1st element");
            st.Push("2nd element");
            st.Push("3rd element");
            Console.WriteLine("Popped element is : ");
            st.Pop();
            Console.WriteLine("Elements in the stack are :");
            st.printData();
            Console.WriteLine("Top  most element at present :");
            string k = st.Peek();
            Console.WriteLine(k);
            Console.ReadLine();


        }

    }
    class Userstack<s>
    {
        internal static int max = 1000;
        s[] stack = new s[max];
        int top = -1;
        public void Push(s str)
        {
            if (top >= 1000)
            {
                Console.WriteLine("can't push");
            }
            else
            {
                stack[++top] = str;
            }
        }
        public void Pop()
        {
            if (top < 0)
            {
                Console.WriteLine("No elements there to pop");
            }
            else
            {
                s value = stack[top--];
                Console.WriteLine(value);
            }
        }
        public s Peek()
        {
            if (top < 0)
            {
                return default(s);
            }
            else
            {
                s value = stack[top];
                return value;
            }
        }
        public void printData()
        {
            for (int i = top; i >= 0; i--)
            {
                Console.WriteLine(stack[i]);

            }
        }
       
    }
}