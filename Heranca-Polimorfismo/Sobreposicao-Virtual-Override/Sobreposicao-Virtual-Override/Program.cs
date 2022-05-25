using System;
using Sobreposicao_Virtual_Override.Entities;

namespace Sobreposicao_Virtual_Override
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Sobreposição ou sobrescrita

            - É a implementação de um método de uma superclasse na subclasse
            - Para que um método comum (não abstrato) possa ser sobreposto, deve ser incluído nele o prefixo "virtual"
            - Ao sobrescrever um método, devemos incluir nele o prefixo "override"

            Significado da palavra Base:

            É possível chamar a implementação da superclasse usando a palavra base.
            Exemplo: suponha que a regra para saque para conta poupança seja realizar o saque normalmente da superclasse
            (Account), e depois descontar mais 2.0.

            public override WithDraw(double amount) 
            {
                base.Withdraw(amount);
                Balance -= 2.0;
            }
            */

            Account acc1 = new Account(1001, "Alex", 500.0);
            Account acc2 = new SavingsAccount(1002, "Anna", 500.0, 0.01);

            acc1.Withdraw(10);
            acc2.Withdraw(10);

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);
        }
    }
}
