using System;

namespace MyApplication
{
    class Car
    {
    private string model = "Mustang";
    }

    class Program
    {
    static void Main(string[] args)
    {
        Car myObj = new Car();
        Console.WriteLine(myObj.model);
    }
}