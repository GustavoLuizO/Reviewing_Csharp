using System;

namespace Exercicio3
{
    internal class Program
    {
        static void Main()
        {
            //Exercicio 3 - Fazer um programa para ler quatro valores inteiros A, B, C e D em um vet. DIFERENCA = (A * B - C * D).
            int[] vet = new int[4];
            for (int i = 0; i <= 3; i++)
            {
                vet[i] = Convert.ToInt32(Console.ReadLine());
            }
            int diferenca = (vet[0] * vet[1]) - (vet[2] * vet[3]);
            Console.WriteLine("DIFERENCA = " + diferenca);


        }
    }
}
