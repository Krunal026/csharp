////4 -create a class book having member variables bookid , title, author, and price and a method getdata() with no parameters ,
////create another overloaded method getdata() with 4 parameters and method display


//using System;

//namespace method
//{
//    class methodoverloading
//    {
//        int bookid;
//        string title, author;
//        int price;


//        public void getdata()
//        {
//            bookid = 1;
//            title = "shivaji maharaj";
//            author = "Krunal";
//            price = 1500;
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
//            Console.WriteLine("book id = " + bookid);
//            Console.WriteLine("title = " + title);
//            Console.WriteLine("Author = " + author);
//            Console.WriteLine("Price = " + price);
//        }
//    }

//    class method
//    {
//        static void Main()
//        {
//            methodoverloading meth = new methodoverloading();
//            meth.getdata();
//            meth.display();

//            Console.WriteLine("-----------------book1 details ----------");

//            methodoverloading meth1 = new methodoverloading();
//            meth1.getdata(2, "Sambhaji Maharaj", "vivek", 1200);
//            meth1.display();

//            Console.WriteLine("-----------------book2 details ----------");

//            Console.WriteLine("Enter Book id");
//            int id = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("Enter Book Title");
//            string name = Console.ReadLine();
//            Console.WriteLine("Enter Authors name");
//            string author = Console.ReadLine();
//            Console.WriteLine("Enter book price");
//            int price = Convert.ToInt32(Console.ReadLine());

//            Console.WriteLine("-----------------book3 details ----------");

//            methodoverloading meth2 = new methodoverloading();
//            meth2.getdata(id, name, author, price);
//            meth2.display();



//            Console.ReadLine();





//        }
//    }
//}
