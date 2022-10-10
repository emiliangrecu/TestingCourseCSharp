using ConsoleApp1;
using System;

namespace ClassObject
{
    class Program
    {
        static void Main(string[] args)
        {
            TestClass1 class1 = new TestClass1();

            class1.TestCase1("a b c");
            class1.SetValue(123);
            class1.GetValue();

            TestClass1 class2 = new TestClass1();

            class2.TestCase2("qwerty");
            class2.SetValue(321);
            class2.GetValue();

            Console.Read();
        }
    }
}
