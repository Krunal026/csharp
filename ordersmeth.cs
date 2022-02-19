//using System;

//namespace orders
//{
//    class odr
//    {
//        int odrid, custid,date,reqdate,shipdate,storeid,staffid;
//        string status;
        


//        //without parameter
//        public void getdata()
//        {
//            odrid = 1;
//            custid = 2;
//            date = 12 / 2 / 20;
//            reqdate = 14 / 2 / 20;
//            shipdate = 13 / 2 / 20;
//            storeid = 3;
//            staffid = 4;
//            status = "pending";
//        }

//        //with parameter

//        public void getdata(int orderid, int custid, int date,int reqdate,int shipdate,int storeid,int staffid,string status)
//        {
//            this.odrid = orderid;
//            this.custid = custid;
//            this.date = date;
//            this.reqdate = reqdate;
//            this.shipdate = shipdate;
//            this.storeid = storeid;
//            this.staffid = staffid;
//            this.status = status;
//        }

//        public void showdata()
//        {
//            Console.WriteLine("Order is = " + odrid);
//            Console.WriteLine("Cust is = " + custid);
//            Console.WriteLine("date is = " + date);
//            Console.WriteLine("Require date is = " + reqdate);
//            Console.WriteLine("shipping date is = " + shipdate);
//            Console.WriteLine("store id is = " + storeid);
//            Console.WriteLine("staff id is = " + staffid);
//            Console.WriteLine("Order status is = " +status);
//        }

//    }

//    class order
//    {
//        static void Main()
//        {
//            odr abc = new odr();
//            abc.getdata();
//            abc.showdata();

//            Console.WriteLine("--------------------------------------------------------");


//            odr abc1 = new odr();
//            abc1.getdata(111,2,15/3/22,18/3/22,16/3/22,333,432,"Shipped");
//            abc1.showdata();


//        }
//    }
//}
