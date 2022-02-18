﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{

    class Book
    {
        int bookid;
        String title, author;
        int price;

        //method overloaded 
        public void getdata(int bookid, String title, String author, int price)
        {
            this.bookid = bookid;
            this.title = title;
            this.author = author;
            this.price = price;

        }
        public void getdata(int bookid, int price, String title, String author)
        {
            this.bookid = bookid;
            this.title = title;
            this.author = author;
            this.price = price;

        }
        public void getdata(String author, int bookid, int price, String title)
        {
            this.bookid = bookid;
            this.title = title;
            this.author = author;
            this.price = price;

        }

        public void display()
        {
            Console.WriteLine("book id = " + bookid);
            Console.WriteLine("book title = " + title);
            Console.WriteLine("book author= " + author);
            Console.WriteLine("price = " + price);



        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Book b = new Book();
            b.getdata(1, "html", "abc", 1200);
            b.display();
            Console.WriteLine("-----------------book1 details ----------");

            Book b1 = new Book();
            b1.getdata(1, 1200, "html", "abc");
            b1.display();
            Console.WriteLine("-----------------book1 details ----------");

            Book b2 = new Book();
            b2.getdata("css", 111, 300, "abc");
            b2.display();
            Console.WriteLine("-----------------book1 details ----------");




            Console.ReadLine();

        }
    }
}

