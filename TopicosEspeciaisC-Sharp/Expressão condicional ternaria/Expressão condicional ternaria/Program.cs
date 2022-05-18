using System;
using System.Globalization;

namespace Expressão_condicional_ternaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Expressão condicional ternária:
            //Estrutura opcional ao if-else quando se deseja decidir um VALOR com base em uma condição

            //Sintaxe: (condição) ? valor_se_verdadeiro : valor_se_falso

            /*Exemplos 
            (2 > 4) ? 50 : 80 -> resultado será 80, por que a condição é falsa. Então o resultado será o ultimo elemento
            (10 != 3) ? "Maria" : "Alex" -> resultado será "Maria", pois a condição é verdadeira, logo ela irá adotar o primeiro valor 
            */


            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Calculando desconto com if-else
            double desconto; 
            if (preco < 20.0)
            {
                desconto = preco * 0.1;
            }
            else
            {
                desconto = preco * 0.05;
            }
            Console.WriteLine(desconto);

            //Utilizando Expressão condicional ternária
            desconto = (preco < 20.0) ? preco * 0.1 : preco * 0.05;
            Console.WriteLine(desconto);
        }
    }
}
