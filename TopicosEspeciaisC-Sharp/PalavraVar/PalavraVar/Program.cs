using System;

namespace PalavraVar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //O tipo var indefine um tipo, reconhe apenas quando ele é atribuido, como pode ver nos casos a seguir
            var x = 10;
            var y = 20.0;
            var z = "Maria";

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
        }
    }
}
