using System;

//class Example
//{
//    // Field 
//    public string InstanceField = "I'm a field";

//    // Static field
//    public static int StaticField = 0;

//    // Constant
//    public const string ConstantField = "I'm a constant field";

//    public int add()
//    {
//        return ++StaticField;
//    }

//    public static int  staticAdd()
//    {
//        //InstanceField = "hello";
//        return ++StaticField;
//    }
//}

//class Cars
//{
//    public string color;
//    public string type;
//    public const int wheels = 3;
//    public static int carsCount;

//    public void changeColor (string color2)
//    {
//        color = color2;
//    }

//    public static int getCarsCount()
//    {
//        return carsCount;
//    }
//}
class Room
{
    public int roomNum;
    public string roomType;
    public double pricePerNight;
    public bool isBooked;
    public const string hotelName = "Grand Stay Hotel";

    public void set()
    {
        Console.WriteLine("=> Enter Room Data:");
        Console.WriteLine();

        Console.Write("Enter Room Number: ");
        roomNum = int.Parse(Console.ReadLine());

        Console.Write("Enter Room Type: ");
        roomType = Console.ReadLine();

        Console.Write("Enter Room Price: ");
        pricePerNight = double.Parse(Console.ReadLine());

        Console.WriteLine("Is The Room Booked? yes/no");
        string check = Console.ReadLine();
        isBooked = check == "yes" ? true : false;
        Console.WriteLine();
    }

    public void get()
    {
        Console.WriteLine("Room Data:");
        Console.WriteLine("Room Number: " + roomNum);

        Console.WriteLine("Room Type: " + roomType);

        Console.WriteLine("Room Price: " + pricePerNight);

        string booked = isBooked == true ? "Yes" : "No";
        Console.WriteLine("Is it bookes? " + booked);
        Console.WriteLine();
    }
}
class Program
{
    static void Main(string[] args)
    {
        Room room1 = new Room();
        Room room2 = new Room();

        room1.set();
        room2.set();

        room1.get();
        room2.get();
        //Cars car1 = new Cars();
        //Cars car2 = new Cars();

        //Cars.carsCount += 2;

        //Console.WriteLine("Cars Count: " + Cars.carsCount);

        //car1.color = "White";
        //car2.color = "Black";

        //car1.changeColor("Red");

        //Console.WriteLine("First Car Color: " + car1.color);
        //Console.WriteLine("First Car Color: " +   car2.color);

        //Example obj1 = new Example();
        //Example obj2 = new Example();

        //Console.WriteLine(obj1.InstanceField); 
        //Console.WriteLine(obj2.InstanceField); 

        //Console.WriteLine(Example.StaticField); 

        //Console.WriteLine(Example.ConstantField); 

        //Console.WriteLine(obj2.add());

        //Console.WriteLine(Example.staticAdd());
    }
}
