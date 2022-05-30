namespace Ex_Interfaces.Services
{
    class PaypalService : IOnlinePaymentService
    {
        private const double FeePercentagem = 0.02; // Taxa de pagamento (2%)
        private const double MonthlyInterest = 0.01; //juros simples (1% por parcela)

        public double Interest(double amount, int months) //interest rate = taxa de juros
        {
            return amount * MonthlyInterest * months;
        }

        public double PaymentFee(double amount)
        {
            return amount * FeePercentagem;
        }
    }
}
