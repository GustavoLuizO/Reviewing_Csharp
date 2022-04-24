using System;

namespace Exercicio2
{
    internal class Program
    {
        static void Main()
        {
            //Exercicio 2 
            //Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro
            //casas decimais conforme exemplos.

            double raio = Double.Parse(Console.ReadLine());
            double area = 3.14159 * (Math.Pow(raio, 2));
            Console.WriteLine(Math.Round(area, 4));
        }
    }
}
