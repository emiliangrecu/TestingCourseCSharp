using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class TestClass1
    {
        private int i = 0;

        public void SetValue(int value)
        {
            i = value;
        }

        public void GetValue()
        {
            Console.WriteLine("Value of i: " + i);
        }

        public void TestCase1(string result)
        {
            Console.WriteLine("This is test case 1: " + result);
        }

        public void TestCase2(string result)
        {
            Console.WriteLine("This is test case 2: " + result);
        }
    }
}
