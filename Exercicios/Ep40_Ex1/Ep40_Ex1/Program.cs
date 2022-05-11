using System;

namespace Ep40_Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Exercício: Fazer um programa para ler os dados de duas pessoas, depois mostrar o nome da pessoa mais velha.

            //Declarando a variável
            Pessoas x, y;
            //Instanciando
            x = new Pessoas();
            y = new Pessoas();

            //Inserindo os dados da primeira pessoa
            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome: ");
            x.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            x.Idade = int.Parse(Console.ReadLine());

            //Inserindo os dados da segunda pessoa
            Console.WriteLine("Dados da segunda pessoa:");
            Console.Write("Nome: ");
            y.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            y.Idade = int.Parse(Console.ReadLine());

            //Imprimindo a pessoa mais velha entre as duas
            if (x.Idade > y.Idade)
            {
                Console.WriteLine("Pessoa mais velha: " + x.Nome);
            }
            else
            {
                Console.WriteLine("Pessoa mais velha: " + y.Nome);
            }
        }
    }
}
