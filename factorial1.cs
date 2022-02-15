
using System;

namespace fact
{
    class @factorial1
    {
        static void Factorial(int num)
        {
            int fact = 1;
            while (num > 0)
            {
                fact = fact * num;
                num--;
            }

            Console.WriteLine("fact =" + fact);

        }

        static void Main()
        {
            int num;
            Console.WriteLine("Enter number");
            num = Convert.ToInt32(Console.ReadLine());
                
            Factorial(num);

            Console.ReadLine();



        }
    }
}