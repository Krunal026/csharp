////3-- create a class employee having fields empno,empname , designation and salary
//// create a constructor with no parameters and create another parameterized constructor with 4 parameters


//using System;

//namespace emp
//{
//    class employee
//    {
//        int empno;
//        string empname, designation;
//        float salary;

//        public employee()
//        {
//            empno = 1;
//            empname = "Krunal";
//            designation = "HR";
//            salary = 12000f;
//        }

//        public employee(int empno, string empname, string designation, int salary)
//        {
//            this.empno = empno;
//            this.empname = empname;
//            this.designation = designation;
//            this.salary = salary;
//        }

//        public void display()
//        {
//            Console.WriteLine("Empno = " + empno);
//            Console.WriteLine("Empname = " + empname);
//            Console.WriteLine("Emp Designation = " + designation);
//            Console.WriteLine("Emp salary = " + salary);
//        }
//    }

//    class empp
//    {
//        static void Main()
//        {
//            employee emp = new employee();

//            emp.display();

//            Console.WriteLine("----------------------------------------------------");

//            employee emp1 = new employee(2,"vivrk","Engineer",78000);

//            emp1.display();


//        }
//    }
//}
