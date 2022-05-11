using System;
using System.Globalization;

namespace EstruturaWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Estrutura para digitar os números e encontrar a raiz deles, porém se for negativo sai da estrutura
            while (x >= 0)
            {
                double raiz = Math.Sqrt(x);
                Console.WriteLine(raiz.ToString("F2", CultureInfo.InvariantCulture));
                Console.Write("Digite outro número: ");
                x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            //Quando falhar imprime a mensagem que o número digitado é negativo
            Console.WriteLine("Número negativo!");

        }
    }
}
