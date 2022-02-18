////6 create a class student having fields rno,name,course,fees create a method getdata with no parameters ,
////create overloaded method with 2 parameters, 3 parameters, 4 parameters and display method.


//using System;
//namespace student
//{
//    class student
//    {
//        int rno;
//        string name, course;
//        int fees;

//        public void getdata()
//        {
//            rno = 123;
//            name = "krunal";
//            course = "dotnet";
//            fees = 75000;
//        }

//        public void getdata(int rno,string name)
//        {
//            this.rno = rno;
//            this.name = name;
//        }

//        public void getdata( int rno, string name, string course)
//        {
//            this.rno = rno;
//            this.name = name;
//            this.course = course;

//        }

//        public void getdata(int rno, string name, string course, int fees)
//        {
//            this.rno = rno;
//            this.name = name;
//            this.course =course;
//            this.fees = fees;

//        }

//        public void showdata()
//        {
//            Console.WriteLine("Roll number = " + rno);
//            Console.WriteLine("Name = " + name);
//            Console.WriteLine("Course = " + course);
//            Console.WriteLine("Fees = " + fees);
//        }
//    }

//    class buk
//    {
//        static void Main()
//        {
//            student stu = new student();
//            stu.getdata();
//            stu.showdata();
//            Console.WriteLine("------------------------------------------------------");

//            student stu1 = new student();
//            stu1.getdata(12,"vivek");
//            stu1.showdata();
//            Console.WriteLine("------------------------------------------------------");

//            student stu2 = new student();
//            stu2.getdata(12, "vivek","python");
//            stu2.showdata();
//            Console.WriteLine("------------------------------------------------------");

//            student stu3 = new student();
//            stu3.getdata(12, "vivek", "python",50000);
//            stu3.showdata();
//            Console.WriteLine("------------------------------------------------------");


//            Console.ReadLine();


//        }
//    }
//}
