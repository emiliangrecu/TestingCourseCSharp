using ConsoleApp1;
using ConsoleApp1.Models;

namespace ClassObject
{
    class Program
    {
        static void Main(string[] args)
        {
            TestClass1 testClass = new TestClass1();

            testClass.Add();
            testClass.Add(3, 5);

            int sum = testClass.Add(1, 2, 3);
            Console.WriteLine("Add method with return: " + sum + "\n");

            Car carModel = new();
            Console.WriteLine("Brand: " + carModel.Brand + "\nBody: " + carModel.Body + "\nType: " + carModel.Type + "\nColour: " + carModel.Colour + "\nPrice: " + carModel.Price + " EUR \n");

            EmployeePage e1 = new EmployeePage();
            EmployeePage e2 = new EmployeePage();
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
