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

        public void Add(double num1, double num2)
        {
            double result = num1 + num2;
            Console.WriteLine("Add method with parameters: " + result);
        }

        public int Add(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }

        public  void UnaryOperators(int number, bool flag)
        {
            int result;

            result = +number;
            Console.WriteLine("+number = " + result);

            result = -number;
            Console.WriteLine("-number = " + result);

            result = ++number;
            Console.WriteLine("++number = " + result);

            result = --number;
            Console.WriteLine("--number = " + result);

            Console.WriteLine("!flag = " + (!flag));
        }

        public void TernaryOperator(int number)
        {
            string result = (number % 3 == 0)? "divisible by 3" : "not divisible by 3";
            Console.WriteLine("{0} is {1}", number, result);
        }

        public void OperatorPrecedence(int a, int b, int c)
        {
            int result = ++a + b / --c;
            Console.WriteLine("{0} + {1} / {2} = {3}", a, b, c, result);
        }
    }
}
