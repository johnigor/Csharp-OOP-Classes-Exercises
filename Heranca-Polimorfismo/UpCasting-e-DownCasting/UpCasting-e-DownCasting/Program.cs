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
            //Usar só quando necessário, testar se a variável é do tipo que você quer
            BusinessAccount acc4 = (BusinessAccount)acc2;
            acc4.Loan(100.0);
            // acc2.Loan(100.0); Sem o downcasting vai dar falha na compilação

            //BusinessAccount acc5 = (BusinessAccount)acc3; //acc3 é "savingsaccount", o compilador só percebe na hora de debugar

            if (acc3 is BusinessAccount) //false
            {
                //BusinessAccount acc5 = (BusinessAccount)acc3;
                BusinessAccount acc5 = acc3 as BusinessAccount; //Outra forma de fazer o casting
            }

            if (acc3 is SavingsAccount) //true
            {
                //SavingsAccount acc5 = (SavingsAccount)acc3;
                SavingsAccount acc5 = acc3 as SavingsAccount;
                acc5.UpdateBalance();
                Console.WriteLine("Update!");
            }
        }
    }
}
