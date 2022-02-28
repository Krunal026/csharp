using System;
class Armstrong
{
    static void Main()
    {
        int n=639, r, sum = 0, temp;

       


        temp = n;


        while (n > 0)
        {
            r = n % 10;
            sum = sum + (r * r * r);
            n = n / 10;
        }
        if (temp == sum)
            Console.Write("Armstrong Number.");
        else
            Console.Write("Not Armstrong Number.");
    }
}

