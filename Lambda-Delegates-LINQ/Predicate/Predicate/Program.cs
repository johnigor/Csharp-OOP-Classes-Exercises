using System;
using Predicate.Entities;
using System.Collections.Generic;

namespace Predicate
{
    class Program
    {
        static void Main(string[] args)
        {
            //Predicate (System)

            //Representa um método que recebe um objeto d tipo T e retorna um valor booleano

            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            //list.RemoveAll(p => p.Price >= 100.0); funcao lambda
            list.RemoveAll(ProductTest); //referencia para a funcao auxiliar

            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
        }

        //funcao auxiliar que testa o produto
        public static bool ProductTest(Product p)
        {
            return p.Price >= 100.00;
        }
    }
}
