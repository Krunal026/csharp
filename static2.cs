////Let's see the simple example of static field in C#.

//using System;
//namespace staticc
//{
//    public class account
//    {
//        int accno;
//        string name;
//        static float roi = 8.8f;


//        public account(int accno, string name)
//        {
//            this.accno = accno;
//            this.name = name;

//        }

//        public void display()
//        {
//            Console.WriteLine(accno + " " + name + " " + roi);
//        }

//    }

//    class act
//    {
//        static void Main()
//        {
//            account a1 = new account(101, "Krunal");

//            account a2 = new account(102, "Vivek");

//            a1.display();
//            a2.display();


//        }

//    }
//}