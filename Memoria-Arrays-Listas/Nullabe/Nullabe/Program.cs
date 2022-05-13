using System;

namespace Nullabe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //para indicar que a variável é opcional (Nullable), deve-se usar "?" após o tipo
            double? x = null;
            double? y = 10.0;

            //Pega o valor do X ou se o valor não existir pega o valor padrão da variavel x (0)
            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            //Vai dizer se dentro da variavel existe ou não um valor
            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);

            //Pega o valor diretamente do x ou y (apenas se ele não for null)
            if (x.HasValue)
            {
                Console.WriteLine(x.Value);
            }
            else
            {
                Console.WriteLine("X is null");
            }
            if(y.HasValue)
            {
                Console.WriteLine(y.Value);
            }
            else
            {
                Console.WriteLine("Y is null");
            }

            //Operador de coalescência nula
            // "??" Se o valor de Z for null, ele atribui o valor que tiver à direita
            double? z = null;
            double? w = z ?? 0.0;
        }
    }
}
