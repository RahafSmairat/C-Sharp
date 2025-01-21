using System;

namespace Study
{

    //Constructor and Destructor
    class LibraryBook
    {
        public string Title;
        public string Author;
        public LibraryBook(string title, string author)
        {
            Title = title;
            Author = author;
            Console.WriteLine($"Book '{Title}' by {Author} has been issued.");
        }
        ~LibraryBook()
        {
            Console.WriteLine($"Book '{Title}' by {Author} has been returned.");
        }
    }

    //Properties
    class BankAccount
    {
        private double _balance; 

        
        public double Balance
        {
            get { return _balance; } 
            set
            {
                if (value >= 0)
                { 
                    _balance = value;
                }
                else
                {
                    Console.WriteLine("Balance cannot be negative!");
                }
            }
        }
    }

    // Auto-property
    class BankAccountt
    {
        public double Balance { get; set; }
    }

    // 1. Encapsulation
    class Vehicle
    {
        private string engine;  // private field
        public void StartEngine()
        {
            engine = "Engine started";
            Console.WriteLine(engine);
        }
        public void StopEngine()
        {
            engine = "Engine stopped";
            Console.WriteLine(engine);
        }
    }

    // 2. Abstraction
    abstract class VehicleAbstract
    {
        public abstract void Move();  // Abstract method
    }

    class Carr : VehicleAbstract
    {
        public override void Move()
        {
            Console.WriteLine("Car is moving.");
        }
    }

    class Truck : VehicleAbstract
    {
        public override void Move()
        {
            Console.WriteLine("Truck is moving.");
        }
    }

    // 3. Inheritance
    class Car : Vehicle
    {
        public void Honk()
        {
            Console.WriteLine("Car is honking!");
        }
    }

    class Room
    {
        public int RoomNumber { get; set; }
        public string RoomType { get; set; }
        public int PricePerNight { get; set; }
        public bool IsBooked { get; set; }

        public const string hotelName = "Grand Stay Hotel";
        public string HotelName {
            get {  return hotelName; }
        }


        public Room(int roomNum, string roomType, int price, bool isBooked)
        {
            RoomNumber = roomNum;
            RoomType = roomType;
            PricePerNight = price;
            IsBooked = isBooked;
            Console.WriteLine($"Room {RoomNumber} Check In");
        }

        public Room()
        {
            RoomNumber = 0;
            RoomType = "";
            PricePerNight = 0;
            IsBooked = false;
        }

        ~Room()
        {
            Console.WriteLine();
            Console.WriteLine($"Room {RoomNumber} Check Out");
        }
    }
        internal class Program
    {
        static void Main(string[] args)
        {

            Room room = new Room(12, "Single", 250, true);
            Console.WriteLine();

            /*
            A constructor is a special method in a class that is automatically called when you create an object of that class.
            The purpose is to initialize the properties of the object or set up any needed starting values.

            A destructor is also a special method that is automatically called when an object is about to be destroyed or no longer used.
            The purposeis to clean up resources, like closing files, freeing memory, or disconnecting from databases.

            You don’t call these methods manually, they happen behind the scenes.
            */

            LibraryBook book = new LibraryBook("1984", "George Orwell");

            /*
             Properties are special methods in a class that allow you to access and control the values of private fields safely.
             Get: Reads the value of the property.
             Set: Updates the value of the property.

            Auto-properties are a simpler and shorter way to define properties.
            Instead of explicitly writing out a private field and property, you let C# automatically handle the private storage.

            Standard Properties:
            - Require you to define a separate private field to hold the value of the property.
            - You write the logic in the get and set blocks explicitly, allowing you to control how values are retrieved or assigned.
            - Suitable when you need custom logic or conditions during property access.
            Use when (Need validation before setting a value, Custom behavior in get or set)

            Auto-Properties:
            - Do not require a separate private field. C# automatically creates a hidden backing field to store the value.
            - You simply declare the property, and C# takes care of the rest.
            - Best for simple properties that don’t need extra validation.
            Use when (No custom logic, just need a field-like property, Want concise and readable code)
            */

            BankAccount account = new BankAccount();

            account.Balance = 1000;
            Console.WriteLine($"Balance: {account.Balance}");

            //Auto
            BankAccountt accountt = new BankAccountt();

            accountt.Balance = 1000;
            Console.WriteLine($"Balance: {accountt.Balance}");

            /*
             The four fundamental principles of OOP are: Encapsulation/ Abstraction/ Inheritance/ Polymorphism

             ** Encapsulation **
             It means hiding the internal working of an object (class) and only exposing what’s necessary to interact with it.
             In a class, we can keep some information private (e.g., balance in a bank account) but provide public methods 
             (like deposit or withdraw) to control how the data is accessed or updated.

            ** Abstraction **
            It allows you to focus on the key features of an object and ignore the complicated behind-the-scenes workings.
            An abstract class can define methods that must be implemented by subclasses. You don’t need to know exactly
            how each method works in the details, only that they exist.

            ** Inheritance **
            It allows us to create new classes that inherit characteristics from existing classes.
            If you have a class Vehicle, then you can create new classes such as Car and Truck that inherit features like speed, 
            fuel, and drive.

            ** Polymorphism **
            It allows different classes to have methods with the same name, but they can behave differently based on the object 
            that is calling the method.
            You could have a method Drive in both the Car and Truck class. Even though they both have the same Drive method, 
            the way they drive can be different for each class.
            */

            // Using Encapsulation (Can interact with Vehicle without accessing its internals)
            Vehicle myVehicle = new Vehicle();
            myVehicle.StartEngine();

            // Using Inheritance (Car inherits from Vehicle)
            Car myCar = new Car();
            myCar.Honk(); 
            myCar.StartEngine();

            // Using Polymorphism (Different classes behave the same way, but differently)
            VehicleAbstract myVehicle1 = new Carr(); 
            VehicleAbstract myVehicle2 = new Truck();

            myVehicle1.Move();
            myVehicle2.Move();
        }
    }
}
