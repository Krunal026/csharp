﻿using System;
using System.Collections.Generic;


namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 0;
            try
            {
                Console.WriteLine("enter age ");
                age = Convert.ToInt32(Console.ReadLine());

                if (age < 18)
                {
                    throw new Exception("age should be greater or equal to 18");
                }

            }
            catch (DivideByZeroException ee)
            {
                Console.WriteLine(ee.ToString());
                Console.WriteLine("enter age ");
                age = Convert.ToInt32(Console.ReadLine());
            }

            finally
            {
                Console.WriteLine("finally block is executing");
                Console.WriteLine("Age is :- " + age);
            }

            Console.WriteLine("bye");
        }
    }
}
