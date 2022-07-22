using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace PagamentosFuncionario.Entities
{
    class Funcionario
    {
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public int DiasDeTrabalho { get; set; }
        public double Salario { get; set; }
        public double Bonus { get; set; }

        public Funcionario()
        {
        }
        public Funcionario(string cpf, string nome, int diasDeTrabalho, double salario, double bonus)
        {
            Cpf = cpf;
            Nome = nome;
            DiasDeTrabalho = diasDeTrabalho;
            Salario = salario;
            Bonus = bonus;
        }
        public int Meses()
        {
            int meses = 0;
            int dias = DiasDeTrabalho;

            if (dias <= 31) meses = 1;
            if (dias > 31 && dias <= 59) meses = 2;
            if (dias > 59 && dias <= 90) meses = 3;
            if (dias > 90 && dias <= 120) meses = 4;
            if (dias > 120 && dias <= 151) meses = 5;
            if (dias > 151 && dias <= 181) meses = 6;
            if (dias > 181 && dias <= 212) meses = 7;
            if (dias > 212 && dias <= 243) meses = 8;
            if (dias > 243 && dias <= 273) meses = 9;
            if (dias > 273 && dias <= 304) meses = 10;
            if (dias > 304 && dias <= 334) meses = 11;
            if (dias > 334 && dias <= 365) meses = 11;

            return meses;
        }

        public double Anos()
        {
            double anos = DiasDeTrabalho / 365.0;
            return anos;
        }

        public double Inss(double aliquota)
        {
            aliquota = 0;
            if (Salario <= 1100) aliquota = 0.075; //7,5%
            if (Salario > 1212 && Salario < 2427) aliquota = 0.09; //9%
            if (Salario > 2203 && Salario < 3305) aliquota = 0.12; //12%
            if (Salario > 3305 && Salario < 6433) aliquota = 0.14; //14%

            return aliquota;
        }
        public double PagamentoMensal()
        {
            double pagamento = Salario - ((Salario * 0.06) + (Salario * Inss(Salario)));
            return pagamento;
        }

        public double BonusAcumulado()
        {
            double bonusMensal = 89;
            Bonus = bonusMensal * Meses();
            return Bonus;
        }
    }
}
