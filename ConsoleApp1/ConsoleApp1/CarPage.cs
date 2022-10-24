using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Models;

namespace ConsoleApp1
{
    public class CarPage
    {
        public string CarOwner(string name)
        {
            return name;
        }

        public Car GetCarDetails()
        {
            return new Car();
        }
    }
}
