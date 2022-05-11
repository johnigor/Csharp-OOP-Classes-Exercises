using System;
using System.Globalization;

namespace ExercicioProdutosEmEstoque
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declarando e instanciando a variável com os atributos da classe Produto
            Produto p = new Produto();

            Console.WriteLine("Entre os dados do produto:");
            
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();

            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade em estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do produto: " + p);
        }
    }
}
