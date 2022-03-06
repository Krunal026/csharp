using System;
using System.Collections.Generic;


namespace delegatee
{
    
    public delegate int del1(int n1, int n2);

    class Program
    {
        
        public int addition(int n1, int n2)
        {
            return n1 + n2;
        }
        public int substraction(int n1, int n2)
        {
            return n1 - n2;
        }
        static void Main()
        {
            Program p1 = new Program();
            del1 d1 = new del1(p1.addition);
            int res = d1(2, 4);
            Console.WriteLine(" addition result " + res);

            del1 d2 = new del1(p1.substraction);
            res = d2(4, 1);
            Console.WriteLine(" substraction result " + res);


        }
    }
}
