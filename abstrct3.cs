//using System;


//namespace abstractt
//{
//    abstract class account
//    {
//        public int actno;
//        public int balance = 1000;

//        public abstract string deposit(int actno, int amount);


//        public string showbalance()
//        {
//            return "Balance amount : " + balance;
//        }
//    }

//    class current : account
//    {
//        public override string deposit(int actno, int amount)
//        {
//            this.actno = actno;
//            balance = balance + amount;

//            return "amount deposited successfully without interest in current class";
//        }
        

//    }

//    class saving : account
//    {
//        public override string deposit(int actno, int amount)
//        {
//            this.actno = actno;
//            int intrest = 500;

//            balance = balance + amount + intrest;

//            return "amount deposited successfully with interest in saving class";
//        }
//    }

//    public class testt
//    {
//        public static void Main()
//        {
//            Console.WriteLine("enter account no ");
//            int actno = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("enter amount to be deposited ");
//            int amount = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("enter account type (saving or currrent)");

//            string acttype = Console.ReadLine();

//            account act = null;
//            if(acttype=="current")
//            {
//                act = new current();
//            }

//            else if(acttype=="saving")
//            {
//                act = new saving();
//            }

//            string res = act.deposit(actno, amount);
//            Console.WriteLine("Account number is " + act.actno);
//            Console.WriteLine(res);
//            res = act.showbalance();
//            Console.WriteLine(res);

//        }
//    }
    
//}
