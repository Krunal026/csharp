﻿////example of protected internal access modifier
//using System;


//namespace inheritance
//{
//    public class Person
//    {
//        String name;
//        String address;
//        protected internal void getPersonData(String name, String address)
//        {
//            this.name = name;
//            this.address = address;
//        }
//        protected internal void displayPersonData()
//        {
//            Console.WriteLine("name : " + name);
//            Console.WriteLine("address : " + address);

//        }
//    }
//    public class Student : Person
//    {
//        int rno;
//        int marks;
//        public void getStudentData(int rno, int marks)
//        {
//            //getPersonData("vivek", "nagpur");
//            this.rno = rno;
//            this.marks = marks;
//        }
//        public void displayStudentData()
//        {
//            //displayPersonData();
//            Console.WriteLine("rno : " + rno);
//            Console.WriteLine("marks : " + marks);

//        }
//    }
//    class TestInheritance
//    {
//        public static void Main(string[] args)
//        {
//            Student p1 = new Student();//creating object of child class++++++

//            p1.getStudentData(50, 46);
//            p1.displayStudentData();
//            p1.getPersonData("Vivek", "Pune");
//            p1.displayPersonData();


//        }
//    }

//}
