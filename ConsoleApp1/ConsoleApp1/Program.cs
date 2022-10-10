using ConsoleApp1;
using System;

namespace ClassObject
{
    class Program
    {
        static void Main(string[] args)
        {
            TestClass1 testClass = new TestClass1();

            testClass.Add();
            testClass.Add(3, 5);


            Console.Read();
        }
    }
}
