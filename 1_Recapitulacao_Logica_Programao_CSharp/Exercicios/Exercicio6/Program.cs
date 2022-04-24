using System;

namespace Exercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercicio 6 
            string[] vet = Console.ReadLine().Split(" ");
            double A = Convert.ToDouble(vet[0]);
            double B = Convert.ToDouble(vet[1]);
            double C = Convert.ToDouble(vet[2]);
            Console.WriteLine("TRIANGULO  = " + ((A * C) / 2).ToString("0.000"));
            Console.WriteLine("CIRCULO = " + (Math.Pow(C, 2) * 3.14159).ToString("0.000"));
            Console.WriteLine("TRAPEZIO = " + (((A + B) * C) / 2).ToString("0.000"));
            Console.WriteLine("QUADRADRO = " + (Math.Pow(B, 2)).ToString("0.000"));
            Console.WriteLine("RETANGULO = " + (A * B).ToString("0.000"));
        }
    }
}
