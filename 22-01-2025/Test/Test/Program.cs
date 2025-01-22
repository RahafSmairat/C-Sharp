using System;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int num = 1;
            //int rows = 5;

            //for (int i = 1; i <= rows; i++)
            //{
            //    for (int j = 1; j <= rows - i; j++)
            //    {
            //        Console.Write("   ");
            //    }

            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write($"{num:D2} ");
            //        num++;
            //    }
            //    Console.WriteLine();
            //}


            int num = 1;
            int rows = 5;

            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= rows - i; j++)
                {
                    Console.Write("   ");
                }

                for (int j = 1; j <= i; j++)
                {
                    if(num < 10)
                    {
                        Console.Write(" " + num +  " ");
                    }
                    else
                    {
                        Console.Write(num + " ");
                    }
                    num++;
                }
                Console.WriteLine();
            }

            //int num = int.Parse(Console.ReadLine());
            //int sum = 0;
            //while (num != 0) {
            //    sum += num % 10;
            //    num /= 10;
            //}
            //Console.WriteLine(sum);


            //string num2 = Console.ReadLine();
            //for (int i = num2.Length - 1; i >= 0; i--)
            //{
            //    Console.Write(num2[i]);
            //}
        }
    }
}

