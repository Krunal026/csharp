//to find reverse no. of 4 digit number...

using System;

namespace rev
{
    class @reverse
    {
        static void Main()
        {
            int num, num1, rev = 0, rem;
            Console.WriteLine("Enter any 4 digit number");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Entred 4 digit number is " +num);



            num1 = num;

            rem = num % 10;
            rev = rev * 10 + rem;
            num = num / 10;

            rem = num % 10;
            rev = rev * 10 + rem;
            num = num / 10;

            rem = num % 10;
            rev = rev * 10 + rem;
            num = num / 10;

            rem = num % 10;
            rev = rev * 10 + rem;
            num = num / 10;


            Console.WriteLine("Reversed 4 digit number is " + rev);

            Console.ReadLine();        }
    }
}

