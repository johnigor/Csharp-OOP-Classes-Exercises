using System;
using Delegates.Services;

namespace Delegates
{
    internal class Program
    {
        //declarando o delegate
        delegate double BinaryNumericOperation(double n1, double n2); //delegate que recebe dois numeros double e retorna um numero double

        static void Main(string[] args)
        {
            /*
            Delegates: 
            - É uma referencia (com type safety) para um ou mais métodos
                - É um tipo referencia
            - Usos comuns:
                - Comunicacao entre objetos de forma flexivel e extensivel (eventos/callbacks)
                - Parametrizacao de operacoes por metodos (programacao funcional)

            Delegates pre-definidos

            - Action
            - Func
            - Predicate
            */

            //Demo

            double a = 10;
            double b = 12;

            BinaryNumericOperation op = CalculationService.Sum;

            /* 
            Sintaxe alternativa:
            
            BinaryNumericOperation op = new BinaryNumericOperation(CalculationService.Sum);
            */

            double result = op(a, b);
            Console.WriteLine(result);
        }
    }
}
