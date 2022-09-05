using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace _5_handson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book(01, "mahabharat", 200.00f, "valamiki");
            Console.WriteLine("class book");
            book.Display();
            Book b2 = new Book();
            b2.InsertBook(2, "ramayanam", 200.0f);
            Console.WriteLine("default and parametrized constructor");
            b2.Display();
            Book b3 = new Book();
            b3.InsertBook(12, "god and goddess", 300.000f, "karnaswife");
            Console.WriteLine("book insertion");
            b3.Display();
            Console.WriteLine("another method for book insertion");
            Book b4 = new Book();
            b4.InsertBook(1, "greek mythology");
            b4.Display();
            Bookcategory b1 = new Bookcategory(1, "mythology", "goddesspower");
            Console.WriteLine("another book inserted");
            b1.Display();
            Console.WriteLine("novels class inherited");
            Novels n1 = new Novels();
            n1.InsertBook(1, "Shilpi", 200.0f);
            n1.Display();
            Novels n2 = new Novels();
            n2.InsertBook(2, "meluha", 200.6f, "libertion seeta");
            n2.Display();
            Cart c1 = new Cart();
            c1.CustomerId = 02;
            c1.BookingId = 2022;
            c1.Addtocart(1, "The hindu", 345.00f);
            c1.Addtocart(2, "Tales from indian mythology", 879.03f);
            Console.WriteLine("cart class");
            c1.dis();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("-----List of all books in the cart-----");
            c1.bookdis();
            Cart c2 = new Cart();
            c2.CustomerId = 10;
            c2.BookingId = 10001;
            c2.Addtocart(1, "the hidden hindu", 788.005f);
            c2.Addtocart(2, "Finding radha", 319.00f);
            c2.dis();
            c2.bookdis();

            Console.ReadLine();


        }
    }
}
