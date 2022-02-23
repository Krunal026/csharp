//create a base class account having fields actno, bal and methods deposit  and showbalance
//create a derieved class current inherited from account class and override the deposit method
//create another derieved class saving inherited from account class and override the deposit method (add interest with amount)

//using System;

//namespace abc
//{
//    class account
//    {
//        public int actno;
//        public int balance = 2000;

//        public virtual String deposit(int actno, int amount)
//        {
//            return "deposit method of account class";
//        }
//        public String showbalance()
//        {
//            return "balance amount : " + balance;
//        }

//    }

//    class current:account
//    {
//        public override string deposit(int actno, int amount)
//        {
//            this.actno = actno;
//            balance = balance + amount;
//            return "amount deposited successfully without interest in current class";
//        }

//    }
//    class saving:account
//    {
//        public override string deposit(int actno, int amount)
//        {
//            this.actno = actno;
//            int interest = 500;
//            balance = balance + amount + interest;
//            return "amount deposited successfully with interest in saving class";
//        }

//    }

//    public class test
//    {
//        public static void Main()
//        {
//            Console.WriteLine("enter account no ");
//            int actno = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("enter amount to be deposited ");
//            int amount = Convert.ToInt32(Console.ReadLine());

//            account cur = new current();
//            string res = cur.deposit(111, 1000);
//            Console.WriteLine("account no is " + cur.actno);
//            Console.WriteLine(res);
//            res = cur.showbalance();
//            Console.WriteLine(res);


//            Console.WriteLine("enter account no ");
//            int actno1 = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("enter amount to be deposited ");
//            int amount1 = Convert.ToInt32(Console.ReadLine());

//            account sav = new saving();
//            string res1 = sav.deposit(222, 1000);
//            Console.WriteLine("Account number is = " + sav.actno);
//            Console.WriteLine(res1);
//            res1 = sav.showbalance();
//            Console.WriteLine(res1);



//        }
//    }
//}