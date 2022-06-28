using System;
using System.Collections.Generic;
using System.Text;

namespace LastExercise_ContaBancaria
{
    public class ContaBancaria
    {
        public int NumeroConta {get ; private set;}
        public string TitularConta { get ; private set;}
        public double Saldo { get; private set;}

        public ContaBancaria(int numeroConta, string titularConta)
        {
            NumeroConta = numeroConta;
            TitularConta = titularConta;
        }

        public override string ToString()
        {
            return "Dados da conta atualizados:\nConta " + NumeroConta + ", Titular: " + TitularConta + ", Saldo: $ " + Saldo.ToString("0.00");
        }

        public void Deposito(double valor)
        {
            Saldo += valor;
        }

        public void Saque (double valor)
        {
            double taxa = 5;
            double valorTotalRetiradoSaldo = valor + taxa;
            Saldo -= valorTotalRetiradoSaldo;
        }
    }
}
