//4- create a class employee having fields empno,empname ,designation , basic salary and method calcuate salary to display 
// hra ie 32% of basicsalary, da ie 43%of basicsalary, ta ie 45% of basicsalary and totalsalary(ie hra+da+ta+basicsalary).


using System;

namespace hraaa
{
    class hraaa
    {
        int empno;
        string empname;
        string designation;
        float basicsalary;
        float hra;
        float da;
        float ta;
        float total;


        public void getdata()
        {
            Console.WriteLine("Enter empno,empname,designation,basicsalary");
            empno = Convert.ToInt32(Console.ReadLine());
            empname = Console.ReadLine();
            designation = Convert.ToString(Console.ReadLine());
            basicsalary = Convert.ToSingle(Console.ReadLine());


            hra = basicsalary / 100 * 32;
            da = basicsalary / 100 * 43;
            ta = basicsalary / 100 * 45;

            total = hra + da + ta + basicsalary;
        }

        public void display()
        {
            Console.WriteLine("Empno=" + empno);
            Console.WriteLine("Empname=" + empname);
            Console.WriteLine("Designation=" + designation);
            Console.WriteLine("Basicsalary=" + basicsalary);
            Console.WriteLine("HRA=" + hra);
            Console.WriteLine("Da=" + da);
            Console.WriteLine("TA=" + ta);
            Console.WriteLine("Totalsalary=" + total);
        }
    }

    class @hra
    {
        static void Main()
        {
            hraaa kru = new hraaa();

            kru.getdata();
            kru.display();

            Console.ReadLine();
        }
    }
}
