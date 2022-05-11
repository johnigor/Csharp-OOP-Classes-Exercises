using System;
using System.Globalization;

namespace saidaDeDados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade = 32;
            double saldo = 10.35784;
            string nome = "Maria";

            //Método placeholder
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome, idade, saldo);

            //Método interpolação
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais");

            //Concatenação de string
            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais");

            //Exercício de fixação
            Console.WriteLine();

            //Atribuindo as variáveis
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            idade = 30; //Apenas atribui outro valor à variável idade pois ela já foi instanciada no escopo
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            //Saída de dados
            Console.WriteLine("Produtos:");
            Console.WriteLine(produto1 + ", cujo preço é $ " + preco1);
            Console.WriteLine(produto2 + ", cujo preço é $ " + preco2);
            Console.WriteLine();

            Console.WriteLine("Registro: " + idade + " anos de idade, código " + codigo + " e gênero: " + genero);
            Console.WriteLine();

            Console.WriteLine("Medida com oito casas decimais: " + medida);
            Console.WriteLine("Arredondando (três casas decimais): " + medida.ToString("F3"));
            Console.WriteLine("Separador decimal invariant culture: " + medida.ToString("F3", CultureInfo.InvariantCulture));

        }
    }
}
