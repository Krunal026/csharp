////example of abstract class in C# which has one abstract method draw().
////Its implementation is provided by derived classes: Rectangle and Circle.
////Both classes have different implementation.

//using System;

//namespace abstractt
//{
//    public abstract class shape
//    {
//        public abstract void draw();
//    }

//    class rectangle : shape
//    {
//        public override void draw()
//        {
//            Console.WriteLine("Drawing rectangle....");
//        }
//    }

//    class circle : shape
//    {
//        public override void draw()
//        {
//            Console.WriteLine("Drawing Circle....");
//        }
//    }

//    public class abc
//    {
//        public static void Main()
//        {
//            shape s = new rectangle();
//            s.draw();
//            shape s1 = new circle();
//            s1.draw();

//        }
//    }
//}