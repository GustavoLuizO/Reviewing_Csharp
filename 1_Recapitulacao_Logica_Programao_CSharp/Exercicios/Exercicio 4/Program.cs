using System;

namespace Exercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercicio 4 - Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por
            //hora e calcula o salário desse funcionário.A seguir, mostre o número e o salário do funcionário, com duas casas
            //decimais.
            for (int i = 0; i < 3; i++)
            {
                int number = Convert.ToInt32(Console.ReadLine());
                int horas = Convert.ToInt32(Console.ReadLine());
                double valorPorHora = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("NUMBER = " + number);
                Console.WriteLine("SALARY = " + " U$ " + (horas * valorPorHora).ToString("0.00"));
            }
        }
    }
}
