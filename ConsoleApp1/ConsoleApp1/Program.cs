using ConsoleApp1;
using ConsoleApp1.Models;

namespace ClassObject
{
    class Program : EmployeePage
    {
        static void Main(string[] args)
        {
            TestClass1 testClass = new TestClass1();

            testClass.Add();
            testClass.Add(3, 5);

            int sum = testClass.Add(1, 2, 3);
            Console.WriteLine("Add method with return: " + sum + "\n");

            Program e1 = new Program();
            Program e2 = new Program();
            e1.name = "John";
            e2.name = "Mike";
            Console.WriteLine("Name: " + e1.name);
            e1.work("Coding");
            Console.WriteLine("Name: " + e2.name);
            e2.work("Testing\n");

            CarPage owner = new CarPage();
            Console.WriteLine("Car owner: " + owner.CarOwner("Bob"));

            Car carModel = new();
            Console.WriteLine("Brand: " + carModel.Brand + "\nBody: " + carModel.Body + "\nType: " + carModel.Type + "\nColour: " + carModel.Colour + "\nPrice: " + carModel.Price + " EUR");
            for (int i = 0; i < carModel.extras.Count; i++)
            {
                Console.WriteLine("Extras: " + carModel.extras[i]);
            }

            var carDetails = owner.GetCarDetails();
            var det = owner.CarDetails();
            Console.WriteLine(det[0]);

            Console.Read();
        }
    }
}
