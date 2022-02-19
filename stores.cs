////calling another method from one method

//using System;

//namespace stores
//{
//    class store
//    {
//        int id, zip;
//        string name, email, street, city, state;
//        long phone;

//        public void getdata()
//        {
//            id = 1;
//            name = "general store";
//            email = "abcgenralstore@gmail.com";
//            phone = 7219713843;
//            street = "shantinagar";
//            city = "nagpur";
//            state = "maharashtra";
//            zip = 440002;
//        }

//        public void getdata(int id)
//        {
//            this.id = id;
//            getdata(id, "abc");
//        }
//        public void getdata(int id, string name)
//        {
//            this.id = id;
//            this.name = name;
//            getdata(id,name, "abcgenralstore@gmail.com");
//        }
//        public void getdata(int id, string name,string email)
//        {
//            this.id = id;
//            this.name = name;
//            this.email = email;
//            getdata(id,name,email,9422839453);
//        }
//        public void getdata(int id, string name, string email,long phone)
//        {
//            this.id = id;
//            this.name = name;
//            this.email = email;
//            this.phone = phone;
//            getdata(id, name, email, phone,"tulsingar");
//        }
//        public void getdata(int id, string name, string email, long phone, string street)
//        {
//            this.id = id;
//            this.name = name;
//            this.email = email;
//            this.phone = phone;
//            this.street = street;
//            getdata(id, name,email, phone,street,"pune");
//        }
//        public void getdata(int id, string name, string email, long phone, string street,string city)
//        {
//            this.id = id;
//            this.name = name;
//            this.email = email;
//            this.phone = phone;
//            this.street = street;
//            this.city = city;
//            getdata(id, name,email,phone,street,city,"maharashtra");
//        }
//        public void getdata(int id, string name, string email, long phone, string street,string city,string state)
//        {
//            this.id = id;
//            this.name = name;
//            this.email = email;
//            this.phone = phone;
//            this.street = street;
//            this.city = city;
//            this.state = state;
//            getdata(id, name, email, phone, street, city,state,440003);
//        }
//        public void getdata(int id, string name, string email, long phone, string street, string city, string state,int zip)
//        {
//            this.id = id;
//            this.name = name;
//            this.email = email;
//            this.phone = phone;
//            this.street = street;
//            this.city = city;
//            this.state = state;
//            this.zip = zip;
            
//        }
//        public void showdata()
//        {
//            Console.WriteLine(" id is = " + id);
//            Console.WriteLine(" name is = " +name);
//            Console.WriteLine(" email is = " + email);
//            Console.WriteLine(" phone is = " + phone);
//            Console.WriteLine(" street is = " +street);
//            Console.WriteLine(" city is = " + city);
//            Console.WriteLine(" state is = " + state);
//            Console.WriteLine(" zip is = " + zip);

//        }
//    }
//    class storee
//    {
//        static void Main()
//        {
//            store str = new store();
//            str.getdata(9);
//            str.showdata();

//            Console.ReadLine();
//        }
//    }
//}
