using System;
using UpCasting_e_DownCasting.Entities;
namespace UpCasting_e_DownCasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Upcasting:
            - Casting da subclasse para superclasse
            - Uso comum: polimorfismo

            Downcasting:
            - Casting da superclasse para subclasse
            - Palavra as
            - Palavra is
            - Uso comum: métodos que recebem parâmetros genéricos (ex: Equals)
            */

            Account acc = new Account(1001, "Alex", 0.0);
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500);

            //UPCASTING
            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
            Account acc3 = new SavingsAccount(1004, "Ana", 0.0, 0.01);

            //DOWNCASTING
            BusinessAccount acc4 = (BusinessAccount)acc2;
            acc4.Loan(100.0);
            // acc2.Loan(100.0); Sem o downcasting vai dar falha na compilação

            BusinessAccount acc5 = (BusinessAccount)acc3;
        }
    }
}
