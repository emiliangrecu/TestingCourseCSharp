using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class Car
    {
        public string Brand { get; set; } = "BMW";
        public string Body { get; set; } = "SUV";
        public string Type { get; set; } = "diesel";
        public string Colour { get; set; } = "black";
        public int Price { get; set; } = 50000;
        public List<string> extras { get; set; } = new() { "Winter Pack", "Parking Pack" };
    }
}
