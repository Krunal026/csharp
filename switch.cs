//wap to accept 2 no. and operator

using System;

namespace switchh
{
    class @switch
    {
        static void Main()
        {
            int n1, n2, res = 0;
            char op;
            Console.WriteLine("Enter 2 no");
            n1 = Convert.ToInt32(Console.ReadLine());
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter operator");
            op = Convert.ToChar(Console.ReadLine());
            switch (op)
            {
                case '+':
                    res = n1 + n2;
                    break;
                case '-':
                    res = n1 - n2;
                    break;
                case '*':
                    res = n1 * n2;
                    break;
                default:
                    Console.WriteLine("invalid");
                    break;

            }

            Console.WriteLine("res " + res);
            Console.ReadLine();


        }
    }
}
