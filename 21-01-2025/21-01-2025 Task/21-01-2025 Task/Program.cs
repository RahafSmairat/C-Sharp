using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_01_2025_Task
{
    //Exercise 1
    class Student
    {
        /*Here I created private feilds to do encapsulation*/
        private string name;
        private int age;
        private int studentId;
        private const int minAge = 18;
        private const int maxAge = 40;

        /*Constant Variables with only get as we cannot change their values*/
        public int MinAge { get; }
        public int MaxAge { get; }

        //Auto Preority
        public string Email { get; set; }

        //Preoriteis
        public string Name { get { return name; } set { name = value; } }
        public int StudentId { get { return studentId; } set { studentId = value; } }
        public int Age { get { return age; } set { age = value; } } 

        //Method to get the data
        public void GetDetails()
        {
            Console.WriteLine($"Student Details\nName: {name}\nAge: {age}\nID: {studentId}");
        }

        //Constructor with parameters
        public Student(string name, int age, int studentId) {
            //Check the age between 18 and 40
            if (age < minAge)
            {
                Console.WriteLine("Age Should Be More Than 18");
                age = minAge;
            }
            else if (age > maxAge) {
                Console.WriteLine("Age Should Be At Maximum 40");
                age = maxAge;
            }
            else
            {
                this.age = age;
            }
                this.name = name;
                this.studentId = studentId;
            
        }

        //Constructor without parameters
        public Student()
        {
            name = "";
            age = minAge;
            studentId = 0;
        }

        //Destructor
        ~Student()
        {
            Console.WriteLine($"{name} Left");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create an object using the empty constructor
            Student ahmad = new Student();
            ahmad.Name = "Ahmad";
            ahmad.Age = 22;
            ahmad.StudentId = 1001;
            ahmad.GetDetails();
            Console.WriteLine();

            //Create an object using the parameters constructor
            Student rahaf = new Student("Rahaf", 26, 912);
            rahaf.GetDetails();
            Console.WriteLine();

            //Create an object with age<18
            Student rafeef = new Student("Rafeef", 17, 156);
            Console.WriteLine();


            //1- A class is a template or blueprint we use it to make the code more organized
            //2- An object is an instance of the class to spacify values to the class properties
            //3- An object is an instance of the class (Part Of It)
            //4- Encapsulation, Abstract, polymorphism and inheritance
            //5- A property is a way to encabsulate the class feild so we can print or modify the feilds without a direct access to it
            //6- A feild is a normal variable declared inside a class.
            //7- A Constructor is a special method to initialize the object feilds and it will be executed automatically when we create an object
            //8- Encapsulation is one of the OOP principles and it means to hide what is supposed to be hidden and only show what is necessery
        }
    }
}
