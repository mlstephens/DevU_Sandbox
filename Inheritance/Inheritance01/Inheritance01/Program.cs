using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance01
{

    class Program
    {
        static void Main(string[] args)
        {
            var auto = new Automobile
            {
                Make = "Toyota",
                Model = "4Runner",
                Year = 2017

            };

            auto.Drive();

            var truck = new Truck()
            {
                Make = "Toyota",
                Model = "Tundra",
                Year = 2016,
                TowingCapacity = 1000
            };

            truck.Drive();
            truck.Tow();            

            Console.WriteLine("==========================");

            DoDrive(auto);
            DoDrive(truck);

            Console.ReadLine();
        }

        private static void DoDrive(Automobile auto)
        {
            auto.Drive();
        }
    }

    class Automobile
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public virtual void Drive()
        {
            Console.WriteLine($"The {Year} {Make} {Model} is driving.");
        }
    }

    class Truck : Automobile
    {
        public int TowingCapacity { get; set; }
        public int CargoSize { get; set; }

        public override void Drive()
        {
            Console.WriteLine($"The Truck {Year} {Make} {Model} is driving.");
        }

        public void Tow()
        {
            Console.WriteLine($"Now we're towing {TowingCapacity} pounds!");
        }
    }
}
