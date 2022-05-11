using System;

namespace ConversaoImplicitaECasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Conversão implícita de float para double
            float x = 4.5f;

            double y = x;

            Console.WriteLine(y);

            //Conversão com Casting (forma explícita)

            double a;
            int b;
            float c;

            a = 5.1;
            b = (int)a;
            c = (float)a;

            Console.WriteLine(b);
            Console.WriteLine(c);

            //Exemplo com divisão
            int d = 5;
            int e = 2;

            double resultado = (double) d / e;

            Console.WriteLine(resultado);
        }
    }
}
