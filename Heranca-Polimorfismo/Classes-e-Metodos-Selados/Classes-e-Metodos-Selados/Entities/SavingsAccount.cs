namespace Classes_e_Metodos_Selados.Entities
{
    //Não pode ser herdada
    sealed class SavingsAccount : Account
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
        
        //significa que essa operação não pode ser sobrescrita novamente em outra subclasse
        public sealed override void Withdraw(double amount)
        {
            base.Withdraw(amount);
            Balance -= 2.0;
        }
    }
}
