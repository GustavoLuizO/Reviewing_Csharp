using System;

namespace Exercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercicio 5 - Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o 
            //código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2.Calcule e mostre o valor a ser pago.
            string[] peca1 = Console.ReadLine().Split(" ");
            string[] peca2 = Console.ReadLine().Split(" ");
            int qtdpeca1 = Convert.ToInt32(peca1[1]);
            double precopeca1 = Convert.ToDouble(peca1[2]);
            int qtdpeca2 = Convert.ToInt32(peca2[1]);
            double precopeca2 = Convert.ToDouble(peca2[2]);
            double total = (qtdpeca1 * precopeca1) + (qtdpeca2 * precopeca2);
            Console.WriteLine("Valor total = " + total.ToString("0.00"));
        }
    }
}
