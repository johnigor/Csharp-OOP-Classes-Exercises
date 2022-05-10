using System;
using System.Collections.Generic;

namespace Listas_List_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //criação da lista + instanciação
            List<string> list = new List<string>();

            //add operação para adicionar um elemento à lista 
            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Anna");
            list.Insert(2, "Marco");

            //imprime os elementos da lista
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            //mostra a quantidade de elementos na lista
            Console.WriteLine("List count: " + list.Count);

            //encontra o primeiro elemento com a letra A
            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("First 'A': " + s1);
            //encontra o ultimo elemento com a letra A
            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Last 'A': " + s2);

            //mostra a posicao do primeiro elemento com a letra A
            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("First position 'A': " + pos1);
            //mostra a posicao do ultimo elemento com a letra A
            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Last position 'A': " + pos2);

            //criando um filtro - mostrar apenas nomes com 5 caracteres
            List<string> list2 = list.FindAll(x => x.Length == 5);
            Console.WriteLine("----------------------");
            foreach (string obj in list2)
            {
                Console.WriteLine(obj);
            }

            //removendo elementos da lista
            list.Remove("Alex");
            Console.WriteLine("----------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            //removendo todos que contem um filtro especifico
            list.RemoveAll(x => x[0] == 'M');
            Console.WriteLine("----------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            //remove a partir do index
            list.RemoveAt(2);

            //remove uma determinada quantidade a partir de uma referencia de inicio
            list.RemoveRange(2, 2);
        }
    }
}
