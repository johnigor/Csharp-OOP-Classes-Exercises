using System;
using Func.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Func
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Func (System)
            
            Representa um método que recebe zero ou mais argumentos, e retorna um valor

            public delegate TResult Func<out TResult>();

            public delegate TResult Func<in T, out TResult>(T obj);

            public delegate TResult Func<in T1, in T2, out TResult>(T1 arg1, T2 arg2);
            
            public delegate TResult Func<in T1, in T2, in T3, out TResult>(T1 arg1, T2 arg2, T3 arg3);         
             
            ...(16 sobrecargas)
            */

            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            //Func<Product, string> func = p => p.Name.ToUpper(); <- expressao lambda: recebe um produto p e retorna um name com toupper

            //expressao lambda in-line            
            List<string> result = list.Select(p => p.Name.ToUpper()).ToList();

            foreach (string s in result)
            {
                Console.WriteLine(s);
            }

        }

        /*  Exemplo sem funcao lambda
        static string NameUpper(Product p)
        {
            return p.Name.ToUpper();
        }
        */
    }
}
