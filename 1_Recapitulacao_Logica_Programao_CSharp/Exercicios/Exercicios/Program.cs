using System;

namespace Exercicios
{
    internal class Program
    {
        static void Main()
        {
            //Exercicio 1 = Entre com 2 valores e some eles
            for (int i = 0; i < 3; i++)
            {
                int num1 = Convert.ToInt32(Console.ReadLine());
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Soma = " + (num1 + num2));
            }

            

        }
    }
}
