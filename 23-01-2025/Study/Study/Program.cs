using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
    class Shape
    {
        // Overloading: Same method name but different parameters
        public void Draw()
        {
            Console.WriteLine("Drawing a shape");
        }

        public void Draw(string shapeName)
        {
            Console.WriteLine($"Drawing a {shapeName}");
        }

        // Overriding: Defined in parent, replaced in child
        public virtual void Display()
        {
            Console.WriteLine("This is a generic shape.");
        }
    }

    class Circle : Shape
    {
        public override void Display()
        {
            Console.WriteLine("This is a circle.");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
