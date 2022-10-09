using System;

namespace ClassObject
{
    class Laptop
    {
        string? ssd;

        static void Main(string[] args)
        {

            // create Laptop object 
            Laptop dell = new Laptop();

            // set ssd for dell
            dell.ssd = "Samsung";
            Console.WriteLine("SSD for Dell: " + dell.ssd);

            // create second object of Laptop
            Laptop asus = new Laptop();

            // set ssd for Asus
            asus.ssd = "Seagate";
            Console.WriteLine("SSD for Asus: " + asus.ssd);

            //Console.ReadLine();
        }
    }
}
