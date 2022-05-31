using System;
using System.Collections.Generic;

namespace HashSet_e_SortedSet
{
    class Program
    {
        static void Main(string[] args)
        {
            //exemplo da aula anterior (217)

            /*HashSet<string> set = new HashSet<string>();

            set.Add("TV");
            set.Add("Notebook");
            set.Add("Tablet");

            Console.WriteLine(set.Contains("Notebook")); -> Verifica se o objeto está ou não na lista
            foreach (string str in set)
            {
                Console.WriteLine(str);
            }
            */

            SortedSet<int> a = new SortedSet<int>() { 0, 2, 4, 5, 6, 8, 10 };
            SortedSet<int> b = new SortedSet<int>() { 5, 6, 7, 8, 9, 10 };

            //union - união entre conjuntos
            SortedSet<int> c = new SortedSet<int>(a);
            c.UnionWith(b); //uniao de C com B (insere os elementos de B que não estejam em C)
            PrintCollection(c);

            //intersection - interseção
            SortedSet<int> d = new SortedSet<int>(a);
            d.IntersectWith(b); //elementos que existem nos dois conjuntos
            PrintCollection(d);

            //difference - diferença entre conjuntos
            SortedSet<int> e = new SortedSet<int>(a);
            e.ExceptWith(b); //remove do conjunto os elementos contidos em outro
            PrintCollection(e);

        }

        //Criando uma funcao auxiliar para imprimir o conjunto
        //a coleção que receber como argumento, é uma coleção do tipo T que implementa o IEnumerable
        static void PrintCollection<T>(IEnumerable<T> collection) //IEnumerator: um padrão de projeto para percorrer coleções de forma padronizada
        {
            foreach (T obj in collection)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();
        }
    }
}
