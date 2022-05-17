
using System;

namespace Matrizes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Matrizes:
            Em programação "matriz" é o nome dado a arranjos bidimensionas
            Arranjo é uma estrutura de dados:
            - Homogenea (dados do mesmo tipo)
            - Ordenada (elementos acessados por meio de posicoes)
            - Alocada de uma vez só, em um bloco contíguo de memoria

            Vantagens:
            - Acesso imediato aos elementos pela sua posicao

            Desvantagens:
            - Tamanho fixo
            - Dificuldade para se realizar insercoes e delecoes

            mat.Lenght: Tamanho da matriz, por ex (3 colunas e 3 linhas = 9 casas)
            mat.Rank: qtd de Linhas
            
             */

            double[,] matriz = new double[2,3];

            //Imprime os elementos da matriz no total
            Console.WriteLine(matriz.Length);
            //Imprime a primeira dimensão da matriz
            Console.WriteLine(matriz.Rank);
            //A dimensão 0 da matriz (como no exemplo) tem tamanho 2
            Console.WriteLine(matriz.GetLength(0));
            //A matriz na segunda dimensão, tem tamanho 3, como no exemplo abaixo
            Console.WriteLine(matriz.GetLength(1));
        }
    }
}
