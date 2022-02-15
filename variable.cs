using System;

namespace vairable
{
    class @variable
    {
        static int fact = 2;


        static void factorial()
        {
            int fact = 1;

            Console.WriteLine("Value of fact  local variable inside method" + fact);

        }

        static void Main()
        {
            factorial();
            Console.WriteLine("fact inside main = {0}", fact);
            Console.ReadLine();
        }
    }
}