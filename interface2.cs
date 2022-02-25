//using System;

//namespace interfacee
//{
//    interface bank
//    {
//        string deposite(int actno, int amt);
//    }

//    class saving : bank
//    {
//        int actno;
//        int bal = 1000;
//        public string deposite(int actno, int amt)
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

//            string str = b.deposite(111, 2000);
//            Console.WriteLine(str);

//        }
//    }
//}

