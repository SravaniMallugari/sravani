using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Book
    {
        private int id;
        public int BookId
        {
            get;
            set;
        }
        private string bookname;
        public string Bname
        {
            get { return bookname; }
            set { bookname = value; }
        }
        private float bkprice;
        public float Price
        {
            get { return bkprice; }
            set { bkprice = value; }
        }
        private string bookauthor;
        public string Author
        {
            get { return bookauthor; }
            set { bookauthor = value; }
        }
        public void InsertBook(int id1, string bname1, float price1)
        {
            id = id1;
            bookname = bname1;
            bkprice = price1;

        }
        public void InsertBook(int id1, string bname1, float price1, string author1)
        {
            id = id1;
            bookname = bname1;
            bkprice = price1;
            bookauthor = author1;

        }
        public void InsertBook(int id1, string bname1)
        {
            id = id1;
            bookname = bname1;
        }
        public Book(int id, string bname, float price, string author)
        {
            this.id = id;
            this.bookname = bname;
            this.bkprice = price;
            this.bookauthor = author;
        }
        public void Display()
        {
            Console.WriteLine(id);
            Console.WriteLine(bookname);
            Console.WriteLine(bkprice);
            Console.WriteLine(bookauthor);
        }
        public Book()
        {

        }
    }
    public class Novels : Book
    {
        private int noofpages;
        public int Noofpages
        {
            get { return noofpages; }
            set { noofpages = value; }
        }
        public void InsertBook(int id1, string bname1, float price1, int pages)
        {
            base.BookId = id1;
            base.Bname = bname1;
            base.Price = price1;
            noofpages = pages;
        }
        public void Displays()
        {
            Console.WriteLine(BookId);
            Console.WriteLine(Bname);
            Console.WriteLine(Price);
            Console.WriteLine(Noofpages);
        }
    }
    public class Cart : Book
    {
        private int Customerid;
        public int CustomerId
        {
            get { return Customerid; }
            set { Customerid = value; }
        }
        private int bookingid;
        public int BookingId
        {
            get { return bookingid; }
            set { bookingid = value; }
        }


        List<Book> b = new List<Book>();
        static int Count = 0;
        public void Addtocart(int id, string bname, float price)
        {
            Book b1 = new Book();
            b1.BookId = id;
            b1.Bname = bname;
            b1.Price = price;
            b.Add(b1);
            Count++;
            Console.WriteLine($"Product added {Count}");

        }


        public void dis()
        {
            Console.WriteLine(CustomerId);
            Console.WriteLine(BookingId);
            foreach (var item in b)
            {
                Console.WriteLine(item.BookId);
                Console.WriteLine(item.Bname);
                Console.WriteLine(item.Price);
            }
        }
        public void bookdis()
        {
            foreach (var item in b)
            {
                Console.Write($"{item.BookId}\t{item.Bname}\n");

            }

        }
    }
    public class Bookcategory
    {
        private int catid;
        public int CatId
        {
            get;
            set;
        }
        private string catname;
        public string CatName
        {
            get { return catname; }
            set { catname = value; }
        }
        private string desc;
        public string Description
        {
            get;
            set;
        }
        public void Display()
        {
            Console.WriteLine(catid);
            Console.WriteLine(catname);
            Console.WriteLine(desc);
        }
        public Bookcategory(int id, string name, string descr)
        {
            catid = id;
            catname = name;
            desc = descr;
        }
        public Bookcategory()
        {

        }
    }
}