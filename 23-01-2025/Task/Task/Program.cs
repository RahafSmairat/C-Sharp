using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    class Calculator
    {
        //Overloading
        public int add(int number1, int number2)
        {
            return number1 + number2;
        }
        public int add(int number1, int number2, int number3)
        {
            return number1 + number2 + number3;
        }
        public double add(double number1, double number2)
        {
            return number1 + number2;
        }
    }

    //Overriding
    class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Draw a shape");
        }
    }
    class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a circle");
        }
    }
    class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a rectangle ");
        }
    }
    //Abstract Class
    abstract class Animal
    {
        public abstract void makeSound();
        public void sleep()
        {
            Console.WriteLine("Animal is sleeping");
        }
    }
    class Dog : Animal
    {
        public override void makeSound()
        {
            Console.WriteLine("Dog barks");
        }
    }
    class Cat : Animal
    {
        public override void makeSound()
        {
            Console.WriteLine("Cat meows");
        }
    }
    //Interface
    public interface Playable
    {
        void Play();
    }
    class Guitar : Playable
    {
        public void Play()
        {
            Console.WriteLine("Playing the guitar");
        }
    }
    class Piano  : Playable
    {
        public void Play()
        {
            Console.WriteLine("Playing the piano");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Overloading
            Calculator calculator = new Calculator();
            Console.WriteLine("=>> Overloading <<=");
            Console.WriteLine("Two Integer Parameters: " + calculator.add(3, 2));
            Console.WriteLine("Three Integer Parameters: " + calculator.add(4, 3, 5));
            Console.WriteLine("Two Double Parameters: " + calculator.add(2.5, 4.6));
            Console.WriteLine();

            //Overriding
            Console.WriteLine("=>> Overloading <<=");
            Circle circle = new Circle();
            circle.Draw();
            Rectangle rectangle = new Rectangle();
            rectangle.Draw();
            Console.WriteLine();

            //Abstract Class
            Dog dog = new Dog();
            Cat cat = new Cat();
            Console.WriteLine("=>> Abstract <<=");
            dog.makeSound();
            cat.makeSound();
            Console.WriteLine();

            //Interface
            Guitar guitar = new Guitar();
            Piano piano = new Piano();
            Console.WriteLine("=>> Interface <<=");
            guitar.Play();
            piano.Play();
            Console.WriteLine();
        }
    }
}