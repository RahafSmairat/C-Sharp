using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
    internal class Program
    {
        //Public Class
        public class PublicClass
        {
            public int Id; 
            public string Name;

            public void PublicMethod()
            {
                Console.WriteLine("I am a public class :)");
            }
        }

        //Private Class
        private class PrivateClass
        {
            private int Id;
            private string Name;

            private void PrivateMethod()
            {
                Console.WriteLine("I am a private class :)");
            }
        }

        //Inheritance
        class Electronics
        {
            public string Type { get; set; }
            public int SerialNumber { get; set; }
            public int WarrantyYear { get; set; }

            public void Warranty()
            {
                Console.WriteLine($"This {Type} is guaranteed until {WarrantyYear}");
            }

        }

        class Phone : Electronics
        {
            public void Notification()
            {
                Console.WriteLine("The phone is ringing");
            }
        }

        class Speaker : Electronics
        {
            public int Volum { set; get; }
            private const int minVolum = 0;
            private const int maxVolum = 100;
            public void VolumDown()
            {
                if (Volum == minVolum)
                {
                    Console.WriteLine("Minimum Volum 0");
                }
                else
                {
                    Volum--;
                    Console.WriteLine("Volum Down");
                }
            }

            public void VolumUp()
            {
                if (Volum == maxVolum) {
                    Console.WriteLine("Maximum Volum 100");
                }
                else
                {
                    Volum++;
                    Console.WriteLine("Volum Up");
                }
            }
        }
        static void Main(string[] args)
        {
            Phone phone = new Phone();
            phone.Type = "Phone";
            phone.SerialNumber = 123;
            phone.WarrantyYear = 5;
            phone.Warranty();
            phone.Notification();
            
            Console.WriteLine();

            Speaker speaker = new Speaker();
            speaker.Type = "Speaker";
            speaker.SerialNumber = 456;
            speaker.WarrantyYear = 3;
            speaker.Warranty();
            speaker.Volum = 2;
            speaker.VolumUp();
            speaker.VolumDown();
        }
    }
}
