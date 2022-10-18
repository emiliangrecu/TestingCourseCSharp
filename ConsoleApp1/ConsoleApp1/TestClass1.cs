using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class TestClass1
    {
        public void Add()
        {
            Console.WriteLine("Empty Add method");
        }

        public void Add(int num1, int num2)
        {
            int result = num1 + num2;
            Console.WriteLine("Add method with parameters: " + result + "\n");
        }

        public int Add(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }
    }

    class Employee
    {
        public string name;

        public void work(string work)
        {
            Console.WriteLine("Work: " + work);
        }
    }
}
