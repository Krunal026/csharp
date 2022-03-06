//using System;
//using System.Collections.Generic;


//namespace abc
//{
//    public delegate int del (int n1);

//    class pro
//    {
//        public int cube(int n1)
//        {
//            return n1 * n1 * n1;
//        }


//        static void Main()
//        {
//            pro p = new pro();

//            del d = new del(p.cube);

//            int res = d(3);

//            Console.WriteLine("Cube is :- " + res);
//        }
//    }
//}