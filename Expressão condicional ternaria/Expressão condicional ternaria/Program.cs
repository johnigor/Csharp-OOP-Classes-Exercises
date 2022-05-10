using System;
using System.Globalization;

namespace Expressão_condicional_ternaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //aula 87

            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double desconto = (preco < 20.0) ? preco * 0.1 : preco * 0.05;

            Console.WriteLine(desconto);
        }
    }
}
