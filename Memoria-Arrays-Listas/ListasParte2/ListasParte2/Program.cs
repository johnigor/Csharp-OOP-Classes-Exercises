using System;
using System.Collections.Generic;

namespace ListasParte2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Demonstração prática das listas 
            - Inserir elemento na lista: Add, Insert
            - Tamanho da lista: Count
            - Encontrar primeiro ou ultimo elemento da lista que satisfaca um predicado: list.Find, list.FindLast
            - Encontrar primeira ou ultima posicao de elemento da lista que satisfaca um predicado: list.FindIndex, list.FindLastIndex
            - Filtrar a lista com base em um predicado: list.FindAll
            - Remover elementos da lista: Remove, RemoveAll, RemoveAt, RemoveRange
             */

            List<string> list = new List<string>();

            //Adicionando elementos
            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Anna");            

            //Insert pode escolher em qual posição adicionar o elemento
            list.Insert(2, "Marco");

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            //Mostrar o tamanho da lista
            Console.WriteLine("List count: " + list.Count);

            //Primeiro ou ultimo elemento da lista que satisfaca um predicado
            //Encontrando o primeiro nome que começa com a letra "A"
            string s1 = list.Find(x => x[0] == 'A'); //Expressão lambda: "Eu quero o X, tal que X na posição 0 = A (começa com A)
            Console.WriteLine("First 'A': " + s1);
            
            string s2 = list.FindLast(x => x[0] == 'A'); //Último elemento que inicie com a letra 'A'
            Console.WriteLine("Last 'A': " + s2);

            int pos1 = list.FindIndex(x => x[0] == 'A'); //Encontra a posição do primeiro elemento da lista que inicia com a letra 'A'
            Console.WriteLine("First position 'A': " + pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'A'); //Encontra a posição do ultimo elemento da lista que inicia com a letra 'A'
            Console.WriteLine("Last position 'A': " + pos2);

            //Cria uma nova lista apenas com os elementos que satisfacam o predicado
            List<string> list2 = list.FindAll(x => x.Length == 5); //Cria uma lista apenas com elementos com 5 caracteres
            Console.WriteLine("--------------------------");
            foreach (string obj in list2)
            {
                Console.WriteLine(obj);
            }

            list.Remove("Alex");
            Console.WriteLine("--------------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            list.RemoveRange(2, 2); //Indica a posicao de onde vai começar a remover, e o outro numero apos a virgula indica quantas casas apos a primeira posicao serao removidas
            Console.WriteLine("--------------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            list.RemoveAll(x => x[0] == 'M');
            Console.WriteLine("--------------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            
        }
    }
}
