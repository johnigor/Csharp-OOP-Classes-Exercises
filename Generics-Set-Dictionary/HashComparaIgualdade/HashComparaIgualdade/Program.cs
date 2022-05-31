using System;
using System.Globalization;
using HashComparaIgualdade.Entities;
using System.Collections.Generic;

namespace HashComparaIgualdade
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Product> a = new HashSet<Product>();
            a.Add(new Product("TV", 900.0));
            a.Add(new Product("Notebook", 1200.0));

            HashSet<Point> b = new HashSet<Point>();
            b.Add(new Point(3, 4));
            b.Add(new Point(5, 10));

            Product prod = new Product("Notebook", 1200.0); //outro objeto, diferente do conjunto acima
            Console.WriteLine(a.Contains(prod));

            Point p = new Point(5, 10);
            Console.WriteLine(b.Contains(p)); //quando o tipo é struct, ele compara por conteúdo
        }
    }
}
