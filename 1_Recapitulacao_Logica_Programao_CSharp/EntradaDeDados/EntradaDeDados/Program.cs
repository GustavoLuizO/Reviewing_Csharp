using System;
using System.Globalization;

namespace EntradaDeDados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //char sexo = Convert.ToChar(Console.ReadLine());
            //double num2 = Double.Parse(Console.ReadLine());
            //string  []vetor = Console.ReadLine().Split(' ');
            //string x = vetor[0];
            //char x1 = Convert.ToChar(vetor[1]);
            //int x2 = Convert.ToInt32(vetor[2]);
            //double x3 = Double.Parse(vetor[3]);
            //Console.WriteLine(num1+"\n"+sexo+"\n"+num2+"\n"+x+"\n"+x1+"\n"+x2+"\n"+x3);


            //Exercicio de fixação 
            Console.WriteLine("Entre com seu nome : ");
            string nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa ? ");
            int qtdquartos = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto : ");
            double valor = Double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            string[] vetorAti = Console.ReadLine().Split(" ");
            string at1 = vetorAti[0];
            int at2 = Convert.ToInt32(vetorAti[1]);
            double at3 = Double.Parse(vetorAti[2]);
            Console.Clear();
            Console.WriteLine(nome+"\n"+qtdquartos+"\n"+valor+"\n"+at1+"\n"+at2+"\n"+at3);

        }
    }
}
