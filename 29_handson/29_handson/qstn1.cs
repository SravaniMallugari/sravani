using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_handson
{
    class qstn1
    {

        static void Main(string[] args)
        {
            // string linked List
            GenericsLinkedList<string> stringLinkedList = new GenericsLinkedList<string>(); //object 1
            string str1 = "element1";
            string str2 = "element2";
            string str3 = "element3";
            string str4 = "element4";
            stringLinkedList.AddHead(str1);
            stringLinkedList.AddHead(str2);
            stringLinkedList.AddHead(str3);
            stringLinkedList.AddHead(str4);
            //display List
            foreach (string s in stringLinkedList)
            {
                Console.WriteLine(s);
            }

            //Integer LinkedList
            GenericsLinkedList<int> integerList = new GenericsLinkedList<int>();
            int n1 = 10;
            int n2 = 20;
            int n3 = 30;

            integerList.AddHead(n1);
            integerList.AddHead(n2);
            integerList.AddHead(n3);

            foreach (int Intger in integerList)
            {
                Console.WriteLine(Intger);
            }


            Console.ReadKey();


        }
    }


    // Generic Linked List
    class GenericsLinkedList<T>
    {
        class LinkedlistNode
        {
            private LinkedlistNode next;
            private T item;

            public LinkedlistNode(T t)
            {
                next = null;
                item = t;

            }
            public LinkedlistNode Next
            {
                get
                {
                    return next;
                }
                set
                {
                    next = value;
                }
            }
            public T Item
            {
                get
                {
                    return item;
                }
                set
                {
                    item = value;
                }
            }
        }
        private LinkedlistNode head;
        public GenericsLinkedList()
        {
            head = null;
        }
        public void AddHead(T t)
        {
            LinkedlistNode node = new LinkedlistNode(t);
            node.Next = head;
            head = node;
        }
        public IEnumerator<T> GetEnumerator()
        {
            LinkedlistNode current = head;
            while (current != null)
            {
                yield return current.Item;
                current = current.Next;
            }

        }

    }
}
