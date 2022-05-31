using System;
using System.Collections.Generic;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintService<int> printService = new PrintService<int>();

            Console.Write("How many values? ");
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                int number = int.Parse(Console.ReadLine());
                printService.AddValue(number);
            }

            printService.Print();
            Console.WriteLine("First: " + printService.First());
        }
    }
}
