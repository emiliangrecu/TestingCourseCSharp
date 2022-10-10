using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class TestClass1
    {
        public void Add()
        {
            Console.WriteLine("Adunare fara parametri");
        }

        public void Add(int num1, int num2)
        {
            int result = num1 + num2;
            Console.WriteLine("rezultatul adunarii cu parametri este " + result);
        }
    }
}
