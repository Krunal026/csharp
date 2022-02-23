////create a base class account having fields actno,bal and methods deposit  and showbalance
////create a derieved class current inherited from account class and override the deposit method


//using System;

//namespace abc
//{
//    public class account
//    {
//        public int actno;
//        public int balance = 1000;


//        public virtual string deposit(int actno, int amount)
//        {
//            return "deposit method of account class";
//        }
//        public string showbalance()
//        {
//            return "balance amount : " + balance;
//        }
//    }

//    class current : account
//    {
//        public override string deposit(int actno, int amount)
//        {
//            this.actno = actno;
//            balance = balance + amount;
//            return "amount deposited successfully in current class";
//        }
//    }

//    public class test
//    {
//        static void Main()
//        {
//            account act = new current();
//            Console.WriteLine("Enter account number");
//            int actno = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("Enter amount to be deposited");
//            int amount = Convert.ToInt32(Console.ReadLine());

//            String res = act.deposit(actno, amount);
//            Console.WriteLine("Account number is = " + act.actno);
//            Console.WriteLine(res);
//            res = act.showbalance();
//            Console.WriteLine(res);
//        }
//    }
//}

