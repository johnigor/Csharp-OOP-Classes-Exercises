using System;
using System.Globalization;
using ClassesAbstratas.Entities;
using System.Collections.Generic;

namespace ClassesAbstratas
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Classes abstratas: 
            - São classes que não podem ser instanciadas
            - É uma forma de garantir herança total: somente subclasses não abstratas podem ser instanciadas,
            mas nunca a superclasse abstrata
            */

            List<Account> list = new List<Account>();

            list.Add(new SavingsAccount(1001, "Alex", 500, 0.01));
            list.Add(new BusinessAccount(1002, "Maria", 500, 400));
            list.Add(new SavingsAccount(1003, "Bob", 500, 0.01));
            list.Add(new BusinessAccount(1004, "Anna", 500, 500));

            double sum = 0.0;
            foreach (Account acc in list)
            {
                sum += acc.Balance;
            }

            Console.WriteLine("Total balance: " + sum.ToString("F2", CultureInfo.InvariantCulture));
        
            foreach (Account acc in list)
            {
                acc.Withdraw(10.0);
            }

            foreach(Account acc in list)
            {
                Console.WriteLine("Updated balance for account " 
                    + acc.Number
                    + ": "
                    + acc.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
