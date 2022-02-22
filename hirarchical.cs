////hierarchical inheritance

//using System;

//namespace inheritance
//{
//    public class person
//    {
//        string name;
//        string address;

//        public void getpersondata(string name, string address)
//        {
//            this.name = name;
//            this.address = address;
//        }

//        public void displayPersonData()
//        {
//            Console.WriteLine("name : " + name);
//            Console.WriteLine("address : " + address);

//        }

//    }

//    public class student : person
//    {
//        int rno;
//        int marks;

//        public void getstudentdata(int rno, int marks)
//        {
//            this.rno = rno;
//            this.marks = marks;

//        }
//        public void displaystudentdata()
//        {
//            Console.WriteLine("Roll number :" + rno);
//            Console.WriteLine("Marks :" + marks);
//        }
//    }

//    public class employee : person
//    {
//        int salary;
//        string designation;

//        public void getemployeedata(int salary, string designation)
//        {
//            this.salary = salary;
//            this.designation = designation;
//        }

//        public void displayemployeedata()
//        {
//            Console.WriteLine("Salary :" + salary);
//            Console.WriteLine("Designation :" + designation);
//        }
//    }

//    class abc
//    {
//        static void Main()
//        {
//            student s1 = new student();
//            s1.getpersondata("Krunal", "Nagpur");
//            s1.getstudentdata(26, 98);
//            s1.displayPersonData();
//            s1.displaystudentdata();

//            employee e1 = new employee();
//            e1.getpersondata("Vivek", "Pune");
//            e1.getemployeedata(50000, "HR");
//            e1.displayPersonData();
//            e1.displayPersonData();
//        }
//    }


//}
