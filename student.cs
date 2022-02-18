////3- create a class student having fields rno,name,mathsmarks, chemmarks,phymarks,
////total, per,grade and method result to calculate and display total, per and grade


//using System;

//namespace student
//{
//    class student
//    {
//        int rno;
//        string name;
//        int mathsmarks;
//        int chemmarks;
//        int phymarks;
//        int total;
//        float per;
//        string grade;

//        public void totall(int mathsmarks, int chemmarks, int phymarks)
//        {
//            total = mathsmarks + chemmarks + phymarks;
//        }
//        public void showtotall()
//        {
//            Console.WriteLine("Total of all Marks are" + total);
//        }



//        public void perr(int mathsmarks, int chemmarks, int phymarks)
//        {
//            per = (mathsmarks + chemmarks + phymarks)*100 / 300;
//        }
//        public void showperr()
//        {
//            Console.WriteLine("Percentage are" + per);
//        }


//        public void gradee(int mathsmarks, int chemmarks, int phymarks)
//        {
//            per = (mathsmarks + chemmarks + phymarks) *100 / 300;



//        }
//        public void showgradee()
//        {
//            if(per>80)
//            {
//                Console.WriteLine("Grade A");
//            }

//            else if(per >35 && per<79)
//            {
//                Console.WriteLine("Grade B");
//            }

//            else
//            {
//                Console.WriteLine("Grade C");
//            }
//        }

//    }

//    class @studentt
//    {
//        static void Main()
//        {
//            student stu = new student();

//            Console.WriteLine("Enter Your Name");
//            string name = Console.ReadLine();
//            Console.WriteLine("Enter Your Roll Number");
//            int rno = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("Enter maths marks");
//            int mathsmarks = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("Enter chemistry marks");
//            int chemmarks = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("Enter Physics marks");
//            int phymarks = Convert.ToInt32(Console.ReadLine());


//            stu.totall(mathsmarks,chemmarks,phymarks);
//            stu.showtotall();

//            stu.perr(mathsmarks, chemmarks, phymarks);
//            stu.showperr();

//            stu.gradee(mathsmarks, chemmarks, phymarks);
//            stu.showgradee();


//            Console.ReadLine();


//        }
//    }



//}

