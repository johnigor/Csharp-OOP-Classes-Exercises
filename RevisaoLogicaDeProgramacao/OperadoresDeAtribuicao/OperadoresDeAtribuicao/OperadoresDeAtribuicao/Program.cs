using System;

namespace OperadoresDeAtribuicao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            Console.WriteLine(a);

            //Variável "a" recebe 2
            a += 2;
            Console.WriteLine(a);

            //Variável "a" é multiplicada por 3
            a *= 3;
            Console.WriteLine(a);
            //Essas operações podem ser usadas com "/", "-", "%"

            //+= funciona com string
            string s = "ABC";
            Console.WriteLine(s);

            s += "DEF";
            Console.WriteLine(s);


            //Operador ++ ->(a = a + 1) e -- ->(a = a - 1)
            a = 10;
            a++;
            Console.WriteLine(a);
            a--;
            Console.WriteLine(a);

            //Atribuindo a outra variável (++a) <-- "++" vai antes da variável
            int b = ++a;
            Console.WriteLine(a);

        }
    }
}
