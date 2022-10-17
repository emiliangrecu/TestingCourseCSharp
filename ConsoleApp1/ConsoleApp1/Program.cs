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


            Program car1 = new("BMW", 50000, "black", "diesel", "SUV");
            Console.WriteLine("Car: " + car1.brand + " " + car1.price + " " + car1.colour + " " + car1.type + " " + car1.body);

            Console.Read();
        }
    }
}
