using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_01_2025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1- Write a C# program that accepts a double input and converts it into an int. Display both values.
            Console.WriteLine("** Exercise 1 **");
            Console.Write("Please Enter A Double Number: ");
            double number1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Double number: " + number1 + "\nConverted Int: " + (int)number1);
            Console.WriteLine();

            //2- Write a program that uses a Convert.ToString() method to convert a number into a string and concatenate it with a sentence.
            Console.WriteLine("** Exercise 2 **");
            Console.Write("Please Enter A Number: ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your Number Is: " + Convert.ToString(number2));
            Console.WriteLine();

            //3- Create a string with a sentence. Use ToUpper() and ToLower() to display the uppercase and lowercase versions of the string.
            Console.WriteLine("** Exercise 3 **");
            Console.Write("Please Enter A String: ");
            string stringVar1 = Console.ReadLine();
            Console.WriteLine("Uppercase: " + stringVar1.ToUpper() + "\nLowercase: " + stringVar1.ToLower());
            Console.WriteLine();

            //4- Write a program that takes a user's full name as input and prints fname lname and length of the full name
            Console.WriteLine("** Exercise 4 **");
            Console.Write("Please Enter Your Full Name: ");
            string name = Console.ReadLine();
            string firstName = name.Substring(0,name.IndexOf(" "));
            string lastName = name.Substring(name.IndexOf(" ")+1);
            Console.WriteLine(firstName);
            Console.WriteLine(lastName);
            Console.WriteLine(firstName.Length + lastName.Length);
            Console.WriteLine();

            //5- Write a program that accepts two integers and prints the smaller of the two.
            Console.WriteLine("** Exercise 5 **");
            Console.WriteLine("Enter two numbers to get the larger:") ;
            string x = Console.ReadLine();
            string y = Console.ReadLine();

            int num1 = int.Parse(x);
            int num2 = int.Parse(y);

            if (num1 > num2)
                Console.WriteLine($"{num1} is larger than {num2}");
            else if (num2 > num1)
                Console.WriteLine($"{num2} is larger than {num1}");
            else
                Console.WriteLine("Numbers are equal");
            Console.WriteLine();


            //6- Write a method that converts kilometers per hour to miles per hour. Use this method in a program to
            //convert and display the result.
            Console.WriteLine("** Exercise 6 **");
            Console.Write("Please Enter The Distance In Km: ");
            double distance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(convertToMiles(distance));
            Console.WriteLine();

            //7- Write a method that takes hours and minutes as input and returns the total number of minutes.
            Console.WriteLine("** Exercise 7 **");
            Console.WriteLine("Please Enter The Hours Then Minutes: ");
            int hours = Convert.ToInt32(Console.ReadLine());
            int minutes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Total Minutes = "+getMinutes(hours, minutes));
            Console.WriteLine();

            //8- Write a method that accepts minutes as input and calculates the total number of hours and minutes.
            Console.WriteLine("** Exercise 8 **");
            Console.Write("Please Enter The Time In Minutes: ");
            int timeMinutes = Convert.ToInt32(Console.ReadLine());
            getTime(timeMinutes);
            Console.WriteLine();

            //9- Compare Two Numbers Write a program that prints:
            Console.WriteLine("** Exercise 9 **");
            Console.WriteLine("Enter Two Numbers:");

            int num3 = int.Parse(Console.ReadLine());
            int num4 = int.Parse(Console.ReadLine());

            string result = num3 > num4 ? "First Number is Greater" : num3 < num4 ? "First Number is Smaller" : "Equal";
            Console.WriteLine(result);
            Console.WriteLine();

            //Write a program that calculates the sum of the digits of a number using arithmetic operators and loops (no conditionals).
            Console.WriteLine("** Exercise 9 **");
            Console.Write("Enter a Number to Sum the Digits:");
            string num6 = Console.ReadLine();
            int sum = 0;
            for (int i = 0; i < num6.Length; i++)
            {
                sum += int.Parse(num6[i].ToString());
            }
            Console.WriteLine("Sum of digits is: " + sum);
            Console.WriteLine();

            //10- Write a program that reverses a number using arithmetic operators and loops.
            Console.WriteLine("** Exercise 10 **");
            Console.WriteLine("Please Enter a Number To Reverse It: ");
            int num7 = int.Parse(Console.ReadLine());
            Console.WriteLine("Reversed is: " + reverseNumber(num7));
            Console.WriteLine();

            //11- Write a program to check if a number is divisible by another number using logical and arithmetic operators.
            //Return a message "Divisible" or "Not Divisible".
            Console.WriteLine("** Exercise 11 **");
            Console.WriteLine("Please Enter Two Numbers To Check If Divisible: ");
            int num8 = int.Parse(Console.ReadLine());
            int num9 = int.Parse(Console.ReadLine());
            string result2 = num8 % num9 == 0 ? "Divisible" : "Not Divisible";
            Console.WriteLine(result2);
            Console.WriteLine();


            //12- Write a program to find the middle value of three numbers using arithmetic and comparison operators.
            Console.WriteLine("** Exercise 12 **");
            Console.WriteLine("Please Enter Three Numbers To Find The Middle One: ");
            int num10 = int.Parse(Console.ReadLine());
            int num11 = int.Parse(Console.ReadLine());
            int num12 = int.Parse(Console.ReadLine());

            Console.WriteLine("Middle Number is: " + middleValue(num10, num11, num12));
            Console.WriteLine();

        }

        static double convertToMiles(double kilometers)
        {
            return kilometers * 0.621371;
        }

        static int getMinutes(int hours, int minutes)
        {
            return (hours * 60) + minutes;
        }

        static void getTime(int minutes)
        {
            int hours = minutes / 60;
            int min = minutes % 60;
            Console.WriteLine("Time is "+ hours + ":" + min);
        }

        static int reverseNumber(int num)
        {
            int reversedNum = 0;
            while(num != 0){
                int last = num % 10;
                reversedNum = (reversedNum * 10) + last;
                num /= 10;
            }
            return reversedNum;
        }

        static int middleValue(int num1, int num2, int num3) {
            int avg = (num1 + num2 + num3)/3;
            int diff1 = num1 > avg ? num1 - avg : avg - num1;
            int diff2 = num2 > avg ? num2 - avg : avg - num2;
            int diff3 = num3 > avg ? num3 - avg : avg - num3;

            if (diff1 < diff2 && diff1 < diff3)
                return num1;
            else if (diff2 < diff1 && diff2 < diff3)
                return num2;

            return num3;
        }
    }
}
