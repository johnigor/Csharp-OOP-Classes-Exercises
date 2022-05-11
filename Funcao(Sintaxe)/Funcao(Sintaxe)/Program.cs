using System;

namespace Funcao_Sintaxe_
{
    internal class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Digite três números: ");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            //Chamando a função
            double resultado = Maior(n1, n2, n3);

            Console.WriteLine("Maior = " + resultado);

        }

        //Calculando o maior número entre três usuários utilizando função
        static int Maior(int a, int b, int c)
        {
            int m;
            //Verificando se "a" é o maior 
            if (a > b && a > c)
            {
                m = a;
            }
            //Verificando se "b" é o maior
            else if (b > c)
            {
                m = b;
            }
            //Por eliminatória se chegar no else, o "c" será o maior
            else
            {
                m = c;
            }
            return m;
        }
    }
}
