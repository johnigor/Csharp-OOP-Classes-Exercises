using System;

namespace MatrizProblemaExemplo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Fazer um programa para ler um numero inteiro N e uma matriz de ordem N contendo números inteiros.
            //Em seguida mostrar a diagonal principal e a quantidade de valores negativos da matriz

            int N = int.Parse(Console.ReadLine());

            int[,] matriz = new int[N, N];

            //Inserindo os dados da matriz
            for (int i = 0; i < N; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    matriz[i, j] = int.Parse(valores[j]);
                }
            }

            //Diagonal principal
            Console.WriteLine("Diagonal principal:");
            for (int i = 0; i < N; i++)
            {
                Console.Write(matriz[i, i] + " ");
            }
            Console.WriteLine();
            //Calculando os números negativos
            int negativos = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (matriz[i, j] < 0)
                    {
                        negativos++;
                    }
                }
            }
            Console.WriteLine("Números negativos: " + negativos);
        }
    }
}
