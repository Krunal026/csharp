//using System;

//namespace customers
//{
//    class cust1
//    {
//        int custid, zip;
//        string fname, lname;
//        string email, street, city, state;
//        long phone;

//       // creating a constructor with no parameters
//        public cust1()
//        {
//            custid = 1;
//            fname = "Krunal";
//            lname = "jibhkate";
//            email = "Krunaljibhkate7@gmail.com";
//            phone = 7219713843;
//            street = "Shantinagar";
//            city = "Nagpur";
//            state = "Maharashtra";
//            zip = 440002;

//        }

//       // constructor with 9 parameters(parameterized constructor)

//        public cust1(int custid, int zip, string fname, string lname, string email, string street, string city, string state, long phone)
//        {
//            this.custid = custid;
//            this.fname = fname;
//            this.lname = lname;
//            this.email = email;
//            this.phone = phone;
//            this.street = street;
//            this.city = city;
//            this.state = state;
//            this.zip = zip;
//        }
//        public void displaydata()
//        {
//            Console.WriteLine("Customer id = " + custid);
//            Console.WriteLine("Customer first name = " + fname);
//            Console.WriteLine("Customer last name = " + lname);
//            Console.WriteLine("Customer email = " + email);
//            Console.WriteLine("Customer phone number = " + phone);
//            Console.WriteLine("Customer street = " + street);
//            Console.WriteLine("Customer city = " + city);
//            Console.WriteLine("Customer state = " + state);
//            Console.WriteLine("Customer zip = " + zip);

//        }

//    }

//    class custtt
//    {
//        static void Main()
//        {
//            cust1 abc = new cust1();
//            abc.displaydata();

//            Console.WriteLine("------------------------------------------------------");

//            cust1 abc1 = new cust1(2, 440002, "Vivek", "Jibhkate", "vivek@gmail.com", "tulsinagar", "nagpur", "maharashtra", 9422839453);
//            abc1.displaydata();

//            Console.ReadLine();
//        }
//    }
//}