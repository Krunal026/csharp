////repeat the above program for person and employee class


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
//        public void showpersondata()
//        {
//            Console.WriteLine("Name = " + name);
//            Console.WriteLine("Address = "+address);
//        }
//    }

//    public class employee : person
//    {
//         int empno;
//         int salary;
//         string designation;

//        public void getempdata(int empno, int salary, string designation)
//        {
//            this.empno = empno;
//            this.salary = salary;
//            this.designation = designation;

//        }

//        public void showempdata()
//        {
//            Console.WriteLine("Number = " + empno);
//            Console.WriteLine("Salary = " + salary);
//            Console.WriteLine("Designation = " + designation);
//        }
//    }

//    class abc
//    {
//        static void Main()
//        {
//            employee emp = new employee();




//            emp.getpersondata("krunal", "Pune");
//            emp.showpersondata();
//            emp.getempdata(111, 50000, "HR");
//            emp.showempdata();

//            Console.ReadLine();
//        }
//    }
//}