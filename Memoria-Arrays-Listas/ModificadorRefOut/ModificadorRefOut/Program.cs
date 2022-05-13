using System;

namespace ModificadorRefOut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ref
            int a = 10;
            Calculator.TripleRef(ref a);
            Console.WriteLine(a);

            //Out 
            int b = 10;
            int triple;
            Calculator.TripleOut(b, out triple);
            Console.WriteLine(triple);

            /*
            Considerações sobre ref e out:

            Diferença:
            - A variavel passada como parametro ref deve ter sido iniciada
            - A variavel passada como parametro out nao precisa ter sido iniciada

            Conclusao: ambos sao muito similares, mas ref é uma forma de fazer o compilador obrigar o usuario a iniciar a variavel

            Nota: ambos sao considerados "code smells" (design ruim) e devem ser evitados
             */
        }
    }
}
