using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace selfStudy
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             Casting Type: Casting is the process of converting a value from one data type to another.

             1- Implicit Casting: Automatically casting if there is no risk (int => float)
             2- Explicit Casting Spacify the type to convert to (double => int)

             Convert.ToInt32()
             Convert.ToDouble()
             Convert.ToString()

            Casting is direct and faster but riskier if the conversion is incompatible.
            Conversion methods are safer but slightly slower as they handle exceptions and edge cases.
            */

            //Implicit Casting
            int smallNumber = 42; // int (4 bytes)
            double largeNumber = smallNumber; // Implicit casting to double (8 bytes)

            // Explicit casting
            int num = 42;
            double convertedNum = (double)num; 
            Console.WriteLine(convertedNum);
            Console.WriteLine();

            // Using a conversion method
            string str = "123";
            int convertedInt = Convert.ToInt32(str); 
            Console.WriteLine(convertedInt + 10);
            Console.WriteLine();

            //This will throw an exception as the number is too large for int
            //Console.WriteLine(Convert.ToInt32(1.23E+308));


            /*
             - String is a sequence of characters or text. It is a type used to represent words, sentences, or any other form of textual information.
             - Concatenation is the process of joining two or more strings together to form a single string using + operator.
             
             ToUpper(): convert the letters to the upper case
             ToLower(): convert the letters to the lower case

             - When you try to add a number to a string, the number is automatically converted into a string, 
             and they are concatenated together as a single string.

             - String interpolation is a way of embedding expressions (like variables or calculations) inside a string, 
             making it easier to include dynamic values within a string.

             - To access individual characters of a string, you can use an index, starting from 0 for the first character.

             - Special Characters in Strings: 
               \n new line
               \\ backslash
               \t tab
               \b backspace
            */

            //Concatenation
            string firstName = "Rahaf";
            string lastName = "Alsmairat";
            string fullName = firstName + " " + lastName; 
            Console.WriteLine(fullName);
            Console.WriteLine();

            //ToUpper, ToLower
            string message = "hello";
            Console.WriteLine(message.ToUpper());
            Console.WriteLine();

            string anotherMessage = "WORLD";
            Console.WriteLine(anotherMessage.ToLower());
            Console.WriteLine();

            //Adding Number and String
            int age = 26;
            string message1 = "Age is: " + age;
            Console.WriteLine(message1);
            Console.WriteLine();

            //String Interpolation
            string name = "Rahaf";
            int score = 100;
            string result = $"Hello, {name}. Your score is {score}.";
            Console.WriteLine(result);
            Console.WriteLine();

            //Access String
            string message2 = "Welcome";
            char firstLetter = message2[0]; 
            Console.WriteLine(firstLetter);
            Console.WriteLine(firstLetter.GetType());
            Console.WriteLine();

            //Special Characters in Strings
            string newLineExample = "Hello\nWorld";
            Console.WriteLine(newLineExample);
            Console.WriteLine();

            string tabExample = "Name:\tJohn"; 
            Console.WriteLine(tabExample);
            Console.WriteLine();

            /*
            - Arithmetic operations are used to perform basic mathematical calculations => (+,-,*,/,%)
            - Logical operations are used to combine multiple conditions or check truth values (true/false) => (&&, ||, !)
            - Comparison operations are used to compare two values to determine their relationship => (==, !=, >, <, >=, <=)
            */

            //Arithmetic operations
            int a = 10, b = 5;
            Console.WriteLine("a + b = "+ (a + b));  // Output: 15 (Addition)
            Console.WriteLine("a - b = " + (a - b));  // Output: 5 (Subtraction)
            Console.WriteLine("a * b = " + (a * b));  // Output: 50 (Multiplication)
            Console.WriteLine("a / b = " + (a / b));  // Output: 2 (Division)
            Console.WriteLine("a % b = " + (a % b));  // Output: 0 (Modulus)
            Console.WriteLine();

            //Logical operations
            bool x = true, y = false;

            Console.WriteLine("x && y = " + (x && y));  // Output: False (both must be true for AND)
            Console.WriteLine("x || t = " + (x || y));  // Output: True (at least one must be true for OR)
            Console.WriteLine("!x = " + (!x));      // Output: False (NOT reverses the value)
            Console.WriteLine();

            //Comparison operations
            int c = 10, d = 20;

            Console.WriteLine("c == d ? " + (c == d));  // Output: False (Equal to)
            Console.WriteLine("c != d ? " +  (c != d));  // Output: True (Not equal to)
            Console.WriteLine("c > d ? " + (c > d));   // Output: False (Greater than)
            Console.WriteLine("c < d ? " + (c < d));   // Output: True (Less than)
            Console.WriteLine("c >= d ? " + (c >= d));  // Output: False (Greater than or equal to)
            Console.WriteLine("c <= d ? " + (c <= d));  // Output: True (Less than or equal to)
            Console.WriteLine();

            /*
            - A method contains a series of instructions that perform a certain action, and you can call that method whenever you need to do that action. 
              Methods can have inputs (called parameters) and outputs (called return values). 

            - Access modifier (public, private)
            - Return type/ void 
            - Method name
            - Parameters

            - Types of methods: Void Method, Return Method, Parameter Method
            */

            DisplayMessage();  

            int result2 = Multiply(4, 3);  
            Console.WriteLine(result2);
            Console.WriteLine();

            //Methode Overloading: defining multiple methods with the same name but different parameters.
            PrintMessage("Hello!"); 
            PrintMessage(10);
            Console.WriteLine();

            //Static method belongs to the class itself and can be called without creating an instance of the class.
        }

        //Void
        public static void DisplayMessage()
        {
            Console.WriteLine("Welcome to C#!");
        }

        //Return, Parameter
        public static int Multiply(int a, int b)
        {
            return a * b;
        }

        //Overloading
        public static void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }

        public static void PrintMessage(int number)
        {
            Console.WriteLine("Number: " + number);
        }
    }

}
