//another example of runtime polymorphism by accepting type of account(Saving or current)

using System;

namespace abc
{
    class account
    {
        public int actno;
        public int balance = 2000;

        public virtual String deposit(int actno, int amount)
        {
            return "deposit method of account class";
        }
        public String showbalance()
        {
            return "balance amount : " + balance;
        }

    }

    class current : account
    {
        public override string deposit(int actno, int amount)
        {
            this.actno = actno;
            balance = balance + amount;
            return "amount deposited successfully without interest in current class";
        }

    }
    class saving : account
    {
        public override string deposit(int actno, int amount)
        {
            this.actno = actno;
            int interest = 500;
            balance = balance + amount + interest;
            return "amount deposited successfully with interest in saving class";
        }

    }

    public class test
    {
        public static void Main()
        {
            Console.WriteLine("enter account no ");
            int actno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter amount to be deposited ");
            int amount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter account type (saving or currrent)");
            String acttype = Console.ReadLine();

            account act = null;
            if (acttype == "saving")
            {
                act = new saving();
            }
            else if (acttype == "current")
            {
                act = new current();
            }


            String res = act.deposit(actno, amount);
            Console.WriteLine("account no is " + act.actno);
            Console.WriteLine(res);
            res = act.showbalance();
            Console.WriteLine(res);



        }
    }
}