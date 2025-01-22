using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    internal class Program
    {
        class Vehicle
        {
            public string Brand { get; set; }
            public string Model { get; set; }
            public void Start () {
                Console.WriteLine("Vehicle is starting.");
            }
        }

        class Car: Vehicle
        {
            public int NumberOfDoors { get; set; }
        }
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Brand = "BMW";
            car.Model = "2024";
            car.NumberOfDoors = 4;
            car.Start ();

            //Constructor is a special method executed once we create an object to initialize some values
            //Encapsulation, Abstract, polymorphism and inheritance
            //Encapsulation is one of the OOP principles and it means to hide what is supposed to be hidden and only show what is necessery
            //A seald class can be a child but not a parent
            //Inheritance allows us to create new classes that inherit characteristics from existing classes.
        }
    }
}
