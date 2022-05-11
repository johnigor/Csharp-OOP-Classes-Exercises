using System;

namespace EstruturaFor
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Digitar um número N e depois N valores inteiros. Mostrar a soma dos N valores digitados.

            Console.Write("Quantos números inteiros você vai digitar? ");
            int n = int.Parse(Console.ReadLine());

            //Declarando variável para utilizar dentro da estrutura For
            int soma = 0;

            //Estrutura de repetição para inserir os dados e somá-los
            for (int i = 1; i <= n; i++)
            {
                Console.Write("Valor #{0}: ", i);
                int valor = int.Parse(Console.ReadLine());
                soma += valor;
            }
            //Imprimindo a soma
            Console.WriteLine("Soma = " + soma);
        }
    }
}
