using System;

namespace EstruturaCondicional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Estruturas if-else / else if

            //Demo#1

            Console.WriteLine("Entre com um número inteiro: ");
            int x = int.Parse(Console.ReadLine());

            if (x % 2 == 0)
            {
                Console.WriteLine("Par!");
            }
            else
            {
                Console.WriteLine("Ímpar!");
            }

            //Demo#2 - Com encadeamento

            Console.WriteLine("Que horas são?");
            int horas = int.Parse(Console.ReadLine());

            if (horas < 12)
            {
                Console.WriteLine("Bom dia!");
            }
            else if (horas < 18) 
            {
                Console.WriteLine("Boa tarde!");
            }
            else
            {
                Console.WriteLine("Boa noite!");
            }

        }
    }
}
