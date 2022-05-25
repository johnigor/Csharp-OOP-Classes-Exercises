using System;
using System.Collections.Generic;
using System.Text;

namespace Sobreposicao_Virtual_Override.Entities
{
    class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount()
        {
        }

        public SavingsAccount(int number, string holder, double balance, double interestRate)
            : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance(double interestRate)
        {
            Balance += Balance * interestRate;
        }

        //a palavra override singifca que está sobrescrevendo um método herdado
        public override void Withdraw(double amount)
        {
            base.Withdraw(amount);
            Balance -= 2.0;
        }
    }
}
