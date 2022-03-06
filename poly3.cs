//Runtime Polymorphism can't be achieved by data members in C#. 

using System;
public class Animal
{
    public string color = "green";

}
public class Dog : Animal
{
    public string color = "yellow";
}
public class TestSealed
{
    public static void Main()
    {
        Animal d = new Dog();
        Console.WriteLine(d.color);

    }
}