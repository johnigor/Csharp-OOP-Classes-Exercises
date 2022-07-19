using System;
using System.Collections.Generic;
using System.Globalization;
using PagamentosFuncionario.Entities;

namespace PagamentosFuncionario
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> funcionarios = new List<Funcionario>();

            Console.WriteLine("Bem vindo, John!");
            Console.WriteLine();
            Console.Write("Deseja cadastrar um funcionário? y/n: ");
            string resposta = Console.ReadLine();
            Console.WriteLine();

            if (resposta.ToUpper().Equals("Y"))
            {
                do
                {
                    Console.Write("Digite o CPF do funcionário: ");
                    string cpf = Console.ReadLine();

                    Console.Write("Qual o nome do funcionário? ");
                    string nome = Console.ReadLine();

                    int diasDeTrabalho = 0;

                    Console.Write("Informe o salário do funcionário: ");
                    double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.WriteLine();

                    Funcionario funcionario = new Funcionario()
                    {
                        Cpf = cpf,
                        Nome = nome,
                        DiasDeTrabalho = diasDeTrabalho,
                        Salario = salario
                    };
                    funcionarios.Add(funcionario);

                    Console.WriteLine("Deseja cadastrar outro funcionário? y/n: ");
                    resposta = Console.ReadLine();
                    Console.WriteLine();
                }
                while (resposta.ToUpper().Equals("Y"));

                Console.WriteLine();

                Console.Write("Deseja fazer consultas para algum funcionário? y/n: ");

                resposta = Console.ReadLine();

                if (resposta.ToUpper().Equals("Y"))
                {
                    Console.Write("Digite o Cpf do funcionário a ser consultado: ");
                    string cpf = Console.ReadLine();
                    Console.WriteLine("Selecione a consulta que deseja fazer: ");
                    Console.WriteLine();

                    Console.WriteLine("Dias trabalhados: ");
                    Console.WriteLine("Salário ");
                    Console.WriteLine();
                }

            }
        }
    }
}
