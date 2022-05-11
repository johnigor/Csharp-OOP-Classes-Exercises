using System;

namespace OperadoresLogicos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Operadores lógicos e seus significados:
            && -> E
            || -> OU
            !  -> NÃO

            Precedência: ! > && > ||

            Pode usar parêntesis à vontade
            */

            bool c1 = 2 > 3 || 4 != 5;      //True
            bool c2 = !(2 > 3) && 4 != 5;   //True

            Console.WriteLine(c1);
            Console.WriteLine(c2);

            Console.WriteLine("-------------------");

            bool c3 = 10 < 5;               //False
            bool c4 = c1 || c2 && c3;       //True

            Console.WriteLine(c3);
            Console.WriteLine(c4);
        }
    }
}
