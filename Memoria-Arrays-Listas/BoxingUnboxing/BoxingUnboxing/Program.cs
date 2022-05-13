using System;

namespace BoxingUnboxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Boxing é o processo de conversao de um objeto tipo valor para um objeto tipo referencia compativel

            //Unboxing é o processo de conversao de um objeto tipo referencia para um objeto tipo valor compativel

            int x = 20; //Fica armazenada na memória stack

            Object obj = x; //Fica armazenada na memória heap (Maior custo de processamento)

            int y = (int)obj; //Fica armazenada na memória stack

        }
    }
}
