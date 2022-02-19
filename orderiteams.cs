//using System;

//namespace order
//{
//    class orderiteams
//    {
//        int odrid, itemid, prdid, qty, price, dis;

//        public void getdata()
//        {
//            odrid = 1;
//            itemid = 22;
//            prdid = 333;
//            qty = 5;
//            price = 10;
//            dis = 20;
//        }

//        public void getdata(int odrid)
//        {
//            this.odrid = odrid;
//            getdata(odrid, 33);
//        }
//        public void getdata(int odrid,int itemid)
//        {
//            this.odrid = odrid;
//            this.itemid = itemid;
//            getdata(odrid, itemid,444);
//        }
//        public void getdata(int odrid, int itemid,int prdid)
//        {
//            this.odrid = odrid;
//            this.itemid = itemid;
//            this.prdid = prdid;
//            getdata(odrid, itemid, prdid,10);
//        }
//        public void getdata(int odrid, int itemid, int prdid,int qty)
//        {
//            this.odrid = odrid;
//            this.itemid = itemid;
//            this.prdid = prdid;
//            this.qty = qty;
//            getdata(odrid, itemid, prdid, qty,5000);
//        }
//        public void getdata(int odrid, int itemid, int prdid, int qty,int price)
//        {
//            this.odrid = odrid;
//            this.itemid = itemid;
//            this.prdid = prdid;
//            this.qty = qty;
//            this.price = price;
//            getdata(odrid, itemid, prdid, qty, price,200);
//        }
//        public void getdata(int odrid, int itemid, int prdid, int qty, int price,int dis)
//        {
//            this.odrid = odrid;
//            this.itemid = itemid;
//            this.prdid = prdid;
//            this.qty = qty;
//            this.price = price;
//            this.dis = dis;
            
//        }

//        public void showdata()
//        {
//            Console.WriteLine("order id is = " + odrid);
//            Console.WriteLine("iteam id is = " +itemid);
//            Console.WriteLine("product id is = " +prdid);
//            Console.WriteLine("qty is = " + qty);
//            Console.WriteLine("price is = " +price);
//            Console.WriteLine("discont is = " +dis);
//        }
//    }

//    class abc
//    {
//        static void Main()
//        {
//            orderiteams ord = new orderiteams();
//            ord.getdata(3,55);
//            ord.showdata();


//            Console.ReadLine();
//        }
//    }
//}
