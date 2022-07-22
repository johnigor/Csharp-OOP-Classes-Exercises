using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
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
                    double bonus = 0;

                    Console.Write("Informe o salário do funcionário: ");
                    double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.WriteLine();

                    Funcionario funcionario = new Funcionario()
                    {
                        Cpf = cpf,
                        Nome = nome,
                        DiasDeTrabalho = diasDeTrabalho,
                        Salario = salario,
                        Bonus = bonus
                    };
                    funcionarios.Add(funcionario);

                    Console.WriteLine("Deseja cadastrar outro funcionário? y/n: ");
                    resposta = Console.ReadLine();
                    Console.WriteLine();
                }
                while (resposta.ToUpper().Equals("Y"));

                Console.WriteLine();

                Console.Write("Deseja fazer consultas para algum funcionário? y/n: ");
                Console.WriteLine();
                resposta = Console.ReadLine();

                if (resposta.ToUpper().Equals("Y"))
                {
                    Console.Write("Digite o Cpf do funcionário a ser consultado: ");
                    string cpf = Console.ReadLine();
                    var consultado = funcionarios.Find(x => x.Cpf.Contains(cpf));
                    Console.WriteLine();

                    Console.WriteLine("Selecione a opção de consulta que deseja fazer: (1/2/3) ");
                    Console.WriteLine();

                    Console.WriteLine(" 1. Dias trabalhados: ");
                    Console.WriteLine(" 2. Salário");
                    Console.WriteLine(" 3. Bônus acumulado");
                    Console.WriteLine();

                    resposta = Console.ReadLine();

                    //Funcionario consulta = funcionarios.Find(x => x.Cpf);
                    try
                    {
                        if (resposta == "1")
                        {
                            Console.WriteLine("O funcionário " + consultado.Nome + " tem " + consultado.DiasDeTrabalho + " dias trabalhados.");
                        }

                        if (resposta == "2")
                        {
                            Console.WriteLine("O funcionário "
                                + consultado.Nome
                                + " recebe R$"
                                + consultado.Salario.ToString(), CultureInfo.InvariantCulture
                                + " bruto por mês.");

                            Console.WriteLine("Salário líquido: " + consultado.PagamentoMensal());
                        }
                        if (resposta == "3")
                        {
                            Console.WriteLine("O funcionário "
                                + consultado.Nome + " possui R$"
                                + consultado.BonusAcumulado().ToString(), CultureInfo.InvariantCulture
                                + " em bônus para ser resgatado.");
                        }
                    }
                    catch (Exception)
                    {
                        throw new Exception("Você deve inserir \"y\" ou \"n\" para prosseguir.");                            
                    }

                }
            }
        }
    }
}
