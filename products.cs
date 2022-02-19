using System;

namespace product
{
    class product
    {
        int prid,brid,catid,year,price;
        string prname;

        public product()
        {
            prid = 1;
            brid = 2;
            catid = 3;
            year = 2022;
            price = 15000;
            prname = "krunal";
        }

        public void display()
        {
            Console.WriteLine("product id = " + prid);
            Console.WriteLine("brand id = " + brid);
            Console.WriteLine("category id = " + catid);
            Console.WriteLine("year = " + year);
            Console.WriteLine("Price = " + price);
            Console.WriteLine("PRoduct name = " + prname);
        }


    }

    class pro
    {
        static void Main()
        {
            product pr = new product();

            pr.display();

            Console.ReadLine();
        }
    }
}
