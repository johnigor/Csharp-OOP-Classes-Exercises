using System;
using Heranca.Entities;

namespace Heranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Herança: 
            - É um tipo de associação que permite que uma classe herde dados e comportamentos de outra
            
            Definições importantes:
            - Vantagens
                Reuso
                Polimorfismo
            
            - Sintaxe
                : (estende)
                base (referência para a superclasse)

            - Relação "é-um"
            - Generalização / Especialização
            - Superclasse (classe base) / subclasse (classe derivada)
            - Herança / Extensão
            - Herança é uma associação entre classes e não entre objetos
            */

            BusinessAccount account = new BusinessAccount(8010, "Bob Brown", 100.0, 500.0);

            Console.WriteLine(account.Balance);
        }
    }
}
