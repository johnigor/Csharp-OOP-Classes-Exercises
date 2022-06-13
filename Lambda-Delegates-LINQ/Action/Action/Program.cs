using System;
using Action.Entities;
using System.Globalization;
using System.Collections.Generic;

namespace Action
{
    class Program
    {
        static void Main(string[] args)
        {
            //Action (System)

            //Representa um método void que recebe zero ou mais argumentos

            /*
            public delegate void Action();

            public delegate void Action<in T>(T obj);

            public delegate void Action<in T1, in T2>(T1 arg1, T2 arg2);

            public delegate void Action<in T1, in T2, in T3>(T1 arg1, T2 arg2, T3 arg3);
            
            ...(16 sobrecargas)
            */

            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            /*       usando delegate Action
            Action<Product> act = UpdatePrice;
            list.ForEach(act);
            */

            //usando expressao lambda
            Action<Product> act = p => { p.Price += p.Price * 0.1; };

            //inline
            list.ForEach(p => { p.Price += p.Price * 0.1; });

            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }

        }
        static void UpdatePrice(Product p) 
        {
            p.Price += p.Price * 0.1;
        }
    }
}
