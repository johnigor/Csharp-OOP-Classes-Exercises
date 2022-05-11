using System;
using System.Globalization;

namespace Ep40_Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercício: Fazer um programa para ler nome e salário de dois funcionários. Depois, mostrar o salário médio dos funcionários.

            //Atribuindo e instanciando na mesma linha
            Funcionario x = new Funcionario();
            Funcionario y = new Funcionario();

            //Dados do primeiro funcionário
            Console.WriteLine("Dados do primeiro funcionário:");
            Console.Write("Nome: ");
            x.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            x.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Dados do segundo funcionário
            Console.WriteLine("Dados do segundo funcionário:");
            Console.Write("Nome: ");
            y.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            y.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salarioMedio = (x.Salario + y.Salario) / 2.0;

            Console.WriteLine("Salário médio = " + salarioMedio.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
