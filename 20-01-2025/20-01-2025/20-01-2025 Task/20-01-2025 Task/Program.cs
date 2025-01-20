using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace _20_01_2025_Task
{
    internal class Program
    {

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
        static void Main(string[] args)
        {
            Console.WriteLine("** Exercise 1 **");
            Console.Write("Enter A Number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine(EvenOrOdd(num1));
            Console.WriteLine();

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("** Exercise 2 **");
            int[] numbers = { 4, -3, 7, 2, 0 };
            Console.WriteLine(SecondSmallest(numbers));
            Console.WriteLine();

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("** Exercise 3 **");
            Console.Write("Enter A Number To Find The Factorial: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine(Factorial(num2));
            Console.WriteLine();

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("** Exercise 4 **");
            Console.WriteLine("Find Prime Numbers");
            Console.Write("Where To Start? ");
            int start = int.Parse(Console.ReadLine());
            Console.Write("Where To End? ");
            int end = int.Parse(Console.ReadLine());
            PrimesBetween(start, end);
            Console.WriteLine();

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("** Exercise 5 **");
            int[] numArray = { 3, 1, 4, 1, 5, 9 };
            Console.WriteLine("Largest Number is: " + FindLargest(numArray));
            Console.WriteLine();

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("** Exercise 6 **");
            Console.Write("Please Enter A Number To Draw A Pattern: ");
            Console.WriteLine();
            NumbersPattern(5);
            Console.WriteLine();

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("** Exercise 7 **");
            Console.Write("Please Enter A Number To Draw A Pyramid Of Stars: ");
            int stars = int.Parse(Console.ReadLine());
            PyramidStars(stars);
            Console.WriteLine();

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("** Exercise 8 **");
            int[] arrayOfNumbers = { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine("Sum Of Even Numbers = " + sumOfEvens(arrayOfNumbers));
            Console.WriteLine("Sum Of Odd Numbers = " + sumOfOdds(arrayOfNumbers));
            Console.WriteLine();

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("** Exercise 9 **");
            int[] array1 = { 1, 2, 3, 4 };
            int[] array2 = { 3, 4, 5, 6 };
            Console.WriteLine("Common Elements Are:");
            CommonElements(array1, array2);
            Console.WriteLine();


            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("** Exercise 10 **");
            Console.WriteLine();
            Room room1 = new Room();
            Room room2 = new Room();
            Console.WriteLine(Room.hotelName);
            Console.WriteLine("First Room");
            room1.set();

            Console.WriteLine("Second Room");
            room2.set();

            Console.WriteLine("--- Rooms Details ---");
            Console.WriteLine("First Room");
            room1.get();
            Console.WriteLine("Second Room");
            room2.get();
        }

        //Exercise 1
        static string EvenOrOdd(int number)
        {
            if (number % 2 == 0)
                return "Even";
            return "Odd";
        }

        //Exercise 2
        static int SecondSmallest(int [] numbers)
        {
            Array.Sort(numbers);
            return numbers[1];
        }

        //Exercise 3
        static int Factorial(int number)
        {
            int factorial = 1;
            for (int i = 1; i<=number; i++)
                factorial *= i;

            return factorial;
        }

        //Exercise 4
        static void PrimesBetween(int start, int end)
        {
            bool isPrime;

            for (int i = start; i <= end; i++)
            {
                isPrime = true;

                for (int j = i-1; j >1 ; j--)
                {
                    if(i%j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    Console.Write(i + " ");
                }

            }
        }

        //Exercise 5
        static int FindLargest(int [] numbers)
        {
            int largest = numbers[0];
            foreach (int number in numbers)
            {
                if( number>largest )
                    largest = number;
            }
            return largest;
        }

        //Exercise 6
        static void NumbersPattern(int number)
        {
            int num = 1;
            for (int i = 1; i <= number; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write(num + " ");
                    num++;
                }
                Console.WriteLine();
            }
        }

        //Exercise 7
        static void PyramidStars(int number)
        {
            for(int i = 1;i <= number; i++)
            {
                for (int j = 1;j <= number-i; j++)
                    Console.Write(" ");

                for(int k = 1;k <= i*2-1; k++)
                     Console.Write("*");

                Console.WriteLine();
            }
        }

        //Exercise 8
        static int sumOfEvens (int[] numbersArray)
        {
            int sum = 0;
            foreach (int number in numbersArray)
            {
                if (number % 2 == 0)
                    sum += number;
            }
            return sum;
        }
        static int sumOfOdds(int[] numbersArray)
        {
            int sum = 0;
            foreach (int number in numbersArray)
            {
                if (number % 2 != 0)
                    sum += number;
            }
            return sum;
        }

        //Exercise 9
        static void CommonElements(int[] array1,  int[] array2)
        {
            foreach (int number in array1)
            {
                foreach(int number2 in array2)
                {
                    if (number == number2)
                        Console.Write(number + " ");
                }
            }
        }
    }
}
