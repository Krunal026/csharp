//using System;

//namespace interfacee
//{
//    interface bank
//    {
//        string deposit(int actno, int amt);
//    }

//    class account
//    {
//        public int actno;
//        public int bal = 100;
//    }
//    class saving:account,bank
//    {
//        public string deposit (int actno, int amt)
//        {
//            this.actno = actno;
//            bal = bal + amt;
//            return "deposited successfully successfully ,bal is " + bal;
//        }
//    }

//    class program
//    {
//        static void Main()
//        {
//            bank b = new saving();

//            string res = b.deposit(123, 2000);

//            Console.WriteLine(res);
//        }
//    }
//}