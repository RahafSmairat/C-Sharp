using System;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace _16_01_2025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1- Create console application that read string from user and print the same string
            Console.WriteLine("**Exercise 1**\n");
            Console.WriteLine("Kindly Type your Name: ");
            string name = Console.ReadLine();
            Console.WriteLine(name + "\n");

            //2- Define variables with kind of
            Console.WriteLine("**Exercise 2**\n");
            double doubleVariable = 5.5;
            string stringVariable = "Rahaf";
            char charVariable = 'R';
            bool boolVariable = true;
            int intVariable = 12;
            const int constVariable = 9;

            Console.WriteLine("Double Variable: " + doubleVariable + "\nString Variable: " + stringVariable +
                "\nCharachter Variable: " + charVariable + "\nBool Variable: " + boolVariable + "\nInt Variabel" + intVariable +
                "\nConstant Variable: " + constVariable +"\n");

            //3-	Define array with name car that hold more than 3 kinds on cars, then print all the cars with the array length.
            Console.WriteLine("**Exercise 3**\n");
            string[] cars = { "PM", "Tesla", "Mercedes", "Kia", "Hondai" };
            foreach (string car in cars) { 
            Console.WriteLine(car);
            }
            Console.WriteLine("Cars Count: " + cars.Length + "\n");

            //4- Write a program in C that reads a first name, Lastname and year of birth and display the names and the year one after another sequentially. Go to the editor
            //•	Input your firstname: Sami
            //•	Input your lastname: Ali
            //•	Input your year of birth: 1999
            //•	Sami Ali 1999
            Console.WriteLine("**Exercise 4**\n");
            Console.Write("Please Enter Your First Name: ");
            string firstName = Console.ReadLine();
            Console.Write("Please Enter Your Last Name: ");
            string lastName = Console.ReadLine();
            Console.Write("Please Enter Your Year Of Birth: ");
            string birthYear = Console.ReadLine();
            Console.Write(firstName + " " + lastName + " was born in " + birthYear +"\n\n");


            //5- Write a program in C # to store elements in an array and print it. 
            //•	Test Data :	
            //•	Input 10 elements in the array :
            //•	element - 0 : 1
            //•	element - 1 : 1
            //•	element - 2 : 2
            //•	.......
            //•	Expected Output :
            //•	Elements in array are: 1 1 2 3 4 5 6 7 8 9

            Console.WriteLine("**Exercise 5**\n");
            string[] array = new string[10];

            Console.WriteLine("Input 10 elements in the array: ");

            for (int i = 0; i < array.Length; i++) {
                Console.Write("Element " + (i+1) +": ");
                array[i] = Console.ReadLine();
            }

            for (int i = 0; i < array.Length; i++) {
                Console.Write(array[i] +  " ");
            }

            Console.WriteLine();
        }
    }
}