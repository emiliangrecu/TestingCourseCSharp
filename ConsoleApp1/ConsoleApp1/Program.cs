using ConsoleApp1;
using System;
using System.Runtime.ConstrainedExecution;
using System.Security.AccessControl;

namespace ClassObject
{
    class Program
    {
        string brand;
        int price;
        string colour;
        string type;
        string body;

        Program(string theBrand, int thePrice, string theColour, string theType, string theBody)
        {
            brand = theBrand;
            price = thePrice;
            colour = theColour;
            type = theType;
            body = theBody;
        }

        static void Main(string[] args)
        {
            TestClass1 testClass = new TestClass1();

            testClass.Add();
            testClass.Add(3, 5);

            int sum = testClass.Add(1, 2, 3);
            Console.WriteLine("Add method with return: " + sum + "\n");

            Program car1 = new("BMW", 50000, "black", "diesel", "SUV");
            Console.WriteLine("Car -- Brand: " + car1.brand + "\nPrice: " + car1.price + " EUR \nColour: " + car1.colour + "\nType: " + car1.type + "\nBody: " + car1.body + "\n");

            Employee e1 = new Employee();
            Employee e2 = new Employee();
            e1.name = "John";
            e2.name = "Mike";
            Console.WriteLine("Name: " + e1.name);
            e1.work("Coding");
            Console.WriteLine("Name: " + e2.name);
            e2.work("Testing");

            Console.Read();
        }
    }
}
