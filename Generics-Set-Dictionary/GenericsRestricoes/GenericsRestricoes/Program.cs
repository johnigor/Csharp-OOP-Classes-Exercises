using System;
using System.Globalization;
using System.Collections.Generic;
using GenericsRestricoes.Entities;
using GenericsRestricoes.Services;

namespace GenericsRestricoes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.Write("Enter N: ");
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                string[] vect = Console.ReadLine().Split(',');
                string name = vect[0];
                double price = double.Parse(vect[1], CultureInfo.InvariantCulture);
                list.Add(new Product(name, price));
            }

            CalculationService calculationService = new CalculationService();

            Product max = calculationService.Max(list);

            Console.WriteLine("Most expensive:");
            Console.WriteLine(max);
        }
    }
}

/*
 Restrições possíveis

- where T: struct
- where T: class
- where T: unmanaged
- where T: new()
- where T: <base type name>
- where T: U
 */ 
