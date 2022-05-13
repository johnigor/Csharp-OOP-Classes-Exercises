using System;

namespace LacoForEach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Laço for each:
            - Sintaxe opcional e simplificada para percorrer colecoes
            Leitura: "para cada objeto 'obj' contido em vect, faça:"
             */

            string[] vect = new string[] { "Maria", "Bob", "Alex" };

            foreach(string obj in vect)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
