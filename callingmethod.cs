//7 -calling another method from one method

//using System;

//namespace call
//{
//    class calling
//    {
//        int bookid;
//        string title, author;
//        int price;

//        public void getdata()
//        {
//            bookid = 1;
//            title = "Jay maharashtra";
//            author = "Mich aho";
//            price = 1500;
//        }

//        public void getdata(int bookid)
//        {
//            this.bookid = bookid;
//            getdata(bookid, "html");

//        }


//        public void getdata(int bookid, String title)
//        {
//            this.bookid = bookid;
//            this.title = title;
//            getdata(bookid, title, "amitabh");

//        }
//        public void getdata(int bookid, String title, String author)
//        {
//            this.bookid = bookid;
//            this.title = title;
//            this.author = author;
//            getdata(bookid, title, author, 234);

//        }
//        public void getdata(int bookid, String title, String author, int price)
//        {
//            this.bookid = bookid;
//            this.title = title;
//            this.author = author;
//            this.price = price;
//        }

//        public void display()
//        {
//            Console.WriteLine("book id = " + bookid);
//            Console.WriteLine("book title = " + title);
//            Console.WriteLine("book author= " + author);
//            Console.WriteLine("price = " + price);
//        }

//    }

//    class abc
//    {
//        static void Main()
//        {
//            calling call = new calling();

//            call.getdata();
//            call.display();

//            Console.WriteLine("-----------------book1 details ----------");


//            Console.ReadLine();

//        }
//    }
//}