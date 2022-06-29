using System;

namespace LastExercise_ContaBancaria
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Entre o número da conta:");
            int numeroConta = Convert.ToInt32(Console.ReadLine());
            Console.Write("Entre o titular da conta:");
            string titularConta = Console.ReadLine();
            ContaBancaria contaBancaria = new ContaBancaria(numeroConta, titularConta);
            Console.Write("Haverá depósito inicial (s/n)?");
            string opDepositoInicial = Console.ReadLine();
            if (opDepositoInicial == "s")
            {
                Console.Write("Entre o valor de depósito inicial : ");
                double depositoInicial = Convert.ToDouble(Console.ReadLine());
                contaBancaria.Deposito(depositoInicial);
            }
            Console.WriteLine("Dados da conta:\nConta " + contaBancaria.NumeroConta + ", Titular: " + contaBancaria.TitularConta + ", Saldo: $ " + contaBancaria.Saldo.ToString("0.00"));

            Console.Write("Entre um valor para depósito:");
            contaBancaria.Deposito(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine(contaBancaria.ToString());
            
            Console.Write("Entre um valor para saque:");
            contaBancaria.Saque(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine(contaBancaria.ToString());
        }
    }
}
