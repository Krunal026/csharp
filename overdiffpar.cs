
//// example of overloading with differernt parameter type

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

//        public void getdata(int bookid, int price)
//        {
//            this.bookid = bookid;
//            this.price = price;
           

//        }


//        public void getdata(int bookid, String title)
//        {
//            this.bookid = bookid;
//            this.title = title;
           

//        }
//        public void getdata(String title,int bookid)
//        {
//            this.bookid = bookid;
//            this.title = title;
            
           

//        }
//        public void getdata(String title, String author)
//        {
            
//            this.title = title;
//            this.author = author;
            
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

//            call.getdata(1,1200);
//            call.display();
//            Console.WriteLine("-----------------book1 details ----------");


//            calling call1 = new calling();
//            call1.getdata(1,"krunal");
//            call1.display();
//            Console.WriteLine("-----------------book1 details ----------");

//            calling call2 = new calling();
//            call2.getdata("krunal",3);
//            call2.display();
//            Console.WriteLine("-----------------book1 details ----------");

//            calling call3 = new calling();
//            call3.getdata("krunal","vivek");
//            call3.display();
//            Console.WriteLine("-----------------book1 details ----------");


//            Console.ReadLine();

//        }
//    }
//}
