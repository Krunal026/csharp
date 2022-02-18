////5 create a class book ,overload  method with 0 ,1 ,2,3,4 parameters.

//using System;

//namespace book
//{
//    class bookmethover
//    {
//        int bookid;
//        String title, author;
//        int price;


//        public void getdata()
//        {
//            bookid = 1;
//            title = "shivaji maharaj";
//            author = "krunal";
//            price = 200;

//        }

//        public void getdata(int bookid)
//        {
//            this.bookid = bookid;
//        }

//        public void getdata(int bookid, string title)
//        {
//            this.bookid = bookid;
//            this.title = title;
//        }

//        public void getdata(int bookid, string title, string author)
//        {
//            this.bookid = bookid;
//            this.title = title;
//            this.author = author;
//        }

//        public void getdata(int bookid, string title, string author, int price)
//        {
//            this.bookid = bookid;
//            this.title = title;
//            this.author = author;
//            this.price = price;

//        }

//        public void display()
//        {
//            Console.WriteLine("Book id = " + bookid);
//            Console.WriteLine("Book title = " + title);
//            Console.WriteLine("Book author = " + author);
//            Console.WriteLine("book Price = " + price);
//        }

//    }

//    class book
//    {
//        static void Main()
//        {
//            bookmethover meth = new bookmethover();
//            meth.getdata();
//            meth.display();

//            Console.WriteLine("-----------------book1 details ----------");


//            bookmethover meth1 = new bookmethover();
//            meth1.getdata(111, "csharp");
//            meth1.display();

//            Console.WriteLine("-----------------book1 details ----------");
//            bookmethover meth2 = new bookmethover();
//            meth2.getdata(111, "csharp", "manish");
//            meth2.display();

//            Console.WriteLine("-----------------book1 details ----------");

//            bookmethover meth3 = new bookmethover();
//            meth3.getdata(111, "csharp", "arti", 444);
//            meth3.display();

//            Console.WriteLine("-----------------book1 details ----------");

//            Console.ReadLine();

//        }
//    }
//}
