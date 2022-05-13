using System;
using System.Globalization;

namespace VetoresParte1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Fazer um programa para ler um número inteiro N e a altura de N pessoas. Armazene as N alturas em um vetor. Em seguida, mostrar a altura média dessas pessoas

            int n = int.Parse(Console.ReadLine());

            double[] vet = new double[n];
            double media = 0.0;
            for (int i = 0; i < n; i++)
            {
                vet[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                media += vet[i];
            }

            media = media / n;
            Console.WriteLine("AVERAGE HEIGHT = " + media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
