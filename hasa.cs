using System;


namespace inheritance
{
    public class Address
    {
        public string addressline, state, city;

        public Address(string addressline, string state, string city)
        {
            this.addressline = addressline;
            this.state = state;
            this.city = city;
        }
    }

    public class Employee
    {
        public int id;
        public string name;
        public Address address;

        public Employee(int id, string name, Address address)
        {
            this.id = id;
            this.name = name;
            this.address = address;
        }
        public void display()
        {
            Console.WriteLine(id + " " + name + " " +
                 address.addressline + " " + address.city + " " + address.state);
        }
    }

    public class abc
    {
        static void Main()
        {
            Address a1 = new Address("G-13, Sec-3", "Noida", "UP");
            Employee e1 = new Employee(1, "KRunal", a1);

            e1.display();

        }
    }
}
