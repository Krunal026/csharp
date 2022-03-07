//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp8
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int n1 = 10;
//            int n2 = 2;
//            int res = 0;
//            try
//            {
//                res = n1 / n2;
//            }
//            catch (DivideByZeroException ee)
//            {
//                Console.WriteLine("catch block is executing");
//                Console.WriteLine(ee.ToString());
//            }
//            catch (Exception ee)
//            {
//                Console.WriteLine(ee.ToString());
//            }
//            finally
//            {
//                Console.WriteLine("finally block is executing");

//            }

//            Console.WriteLine("bye");
//        }
//    }
//}
