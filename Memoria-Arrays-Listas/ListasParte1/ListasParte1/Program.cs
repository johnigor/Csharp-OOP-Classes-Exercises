using System;
using System.Collections.Generic;

namespace ListasParte1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Listas:

            Lista é uma estrutura de dados:
            - Homogenea (dados do mesmo tipo)
            - Ordenada (elementos acessados por meio de posições)
            - Inicia vazia, e seus elementos são alocados sob demanda
            - Cada elemento ocupa um "nó" (ou nodo) da lista
            
            Classe: List
            Namespace: System.Collections.Generic

            Vantagens:
            - Tamanho variável
            - Facilidade para se realizar inserções e deleções

            Desvantagens:
            - Acesso sequencial aos elementos *
             */

            //A instanciação cria uma lista vazia
            List<string> list = new List<string>();

            //C# Permite criar uma lista, instanciar e já adicionar elementos a ela
            List<string> list2 = new List<string> { "Maria", "Alex", "Bob"};
        }
    }
}
