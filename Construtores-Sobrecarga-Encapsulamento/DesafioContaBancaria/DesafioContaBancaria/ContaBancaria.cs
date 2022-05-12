using System;

namespace DesafioContaBancaria
{
    internal class ContaBancaria
    {
        private int _numeroConta;
        public string Titular { get; private set; }
        public double Saldo { get; private set; }         
        
        public ContaBancaria(int numeroConta, string titular)
        {
            _numeroConta = numeroConta;
            Titular = titular;
            Saldo = 0;
        }

        public ContaBancaria(int numeroConta, string titular, double saldo) : this(numeroConta, titular)
        {
            Saldo = saldo;
        }

        public void DepositoInicial(double deposito)
        {
            Saldo += deposito;
        }

        public void Deposito(double deposito)
        {
            Saldo += deposito;
        }

        public void Saque(double saque)
        {
            if (Saldo > saque)
            {
                Saldo -= saque + 5.0;
            }
        }

        public override string ToString()
        {
            return "Conta " 
                + _numeroConta
                + ", Titular: "
                + Titular
                + ", Saldo: $"
                + Saldo.ToString("F2");
        }
    }
}
