//using System;

//namespace staff
//{
//    class staff
//    {
//        int staffid, storeid, manid;
//        string fname, lname, email;
//        long phone;

//        public void getdata()
//        {
//            staffid = 1;
//            fname = "Krunal";
//            lname = "jibhkate";
//            email = "krunaljibhkate7@gmail.com";
//            phone = 721973843;
//            storeid = 22;
//            manid = 333;
//        }

//        public void getdata(int staffid)
//        {
//            this.staffid = staffid;
//        }
//        public void getdata(int staffid, string fname)
//        {
//            this.staffid = staffid;
//            this.fname = fname;
//        }
//        public void getdata(int staffid, string fname, string lname)
//        {
//            this.staffid = staffid;
//            this.fname = fname;
//            this.lname = lname;
//        }
//        public void getdata(int staffid, string fname, string lname, string email)
//        {
//            this.staffid = staffid;
//            this.fname = fname;
//            this.lname = lname;
//            this.email = email;
//        }
//        public void getdata(int staffid, string fname, string lname, string email, long phone)
//        {
//            this.staffid = staffid;
//            this.fname = fname;
//            this.lname = lname;
//            this.email = email;
//            this.phone = phone;
//        }
//        public void getdata(int staffid, string fname, string lname, string email, long phone, int storeid)
//        {
//            this.staffid = staffid;
//            this.fname = fname;
//            this.lname = lname;
//            this.email = email;
//            this.phone = phone;
//            this.storeid = storeid;
//        }
//        public void getdata(int staffid, string fname, string lname, string email, long phone, int storeid, int manid)
//        {
//            this.staffid = staffid;
//            this.fname = fname;
//            this.lname = lname;
//            this.email = email;
//            this.phone = phone;
//            this.storeid = storeid;
//            this.manid = manid;
//        }

//        public void showdata()
//        {
//            Console.WriteLine("Staff id is = " + staffid);
//            Console.WriteLine("Staff first name is = " + fname);
//            Console.WriteLine("Staff last name is = " + lname);
//            Console.WriteLine("Staff email is = " + email);
//            Console.WriteLine("Staff phone is = " + phone);
//            Console.WriteLine("Staff store id is = " + storeid);
//            Console.WriteLine("Staff manager id is = " + manid);
//        }
//    }

//    class stafff
//    {
//        static void Main()
//        {
//            staff stf = new staff();
//            stf.getdata();
//            stf.showdata();
//            Console.WriteLine("------------------------------------------------------------------------");

//            staff stf1 = new staff();
//            stf1.getdata(1);
//            stf1.showdata();
//            Console.WriteLine("------------------------------------------------------------------------");

//            staff stf2 = new staff();
//            stf2.getdata(1, "Vivek");
//            stf2.showdata();
//            Console.WriteLine("------------------------------------------------------------------------");

//            staff stf3 = new staff();
//            stf3.getdata(1, "Vivek", "Bhanushali");
//            stf3.showdata();
//            Console.WriteLine("------------------------------------------------------------------------");

//            staff stf4 = new staff();
//            stf4.getdata(1, "Vivek", "Bhanushali", "vivek@gmail.com");
//            stf4.showdata();
//            Console.WriteLine("------------------------------------------------------------------------");

//            staff stf5 = new staff();
//            stf5.getdata(1, "Vivek", "Bhanushali", "vivek@gmail.com", 7219713843);
//            stf5.showdata();
//            Console.WriteLine("------------------------------------------------------------------------");

//            staff stf6 = new staff();
//            stf6.getdata(1, "Vivek", "Bhanushali", "vivek@gmail.com", 7219713843, 555);
//            stf6.showdata();
//            Console.WriteLine("------------------------------------------------------------------------");

//            staff stf7 = new staff();
//            stf7.getdata(1, "Vivek", "Bhanushali", "vivek@gmail.com", 7219713843, 555, 66);
//            stf7.showdata();
//            Console.WriteLine("------------------------------------------------------------------------");
//        }
//    }
//}
