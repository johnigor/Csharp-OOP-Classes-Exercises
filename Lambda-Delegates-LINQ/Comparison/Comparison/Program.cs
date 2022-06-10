using System;
using Comparison.Entities;
using System.Globalization;
using System.Collections.Generic;

namespace Comparison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Comparison<T> (System) --- o Comparison<T> é um delegate
            
            declaração:

            public delegate in Comparison<in T>(T x, T y) //recebe dois objetos do tipo T retornando inteiro
            */

            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Notebook", 1200.00));
            list.Add(new Product("Tablet", 450.00));

            //   Pode ser feito assim também: com declaração de fução lambda
            //Comparison<Product> comp = (p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper()); //declaração de função anônima

            //a função pode ser declarada diretamente no parametro do sort
            list.Sort((p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper()));

            //delegate: uma referência para a função auxiliar (com typesafety)
            //list.Sort(CompareProducts);

            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
        }

        //função auxiliar
        /* 
        static int CompareProducts(Product p1, Product p2)
        {
            return p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
        }
        */
    }
}
