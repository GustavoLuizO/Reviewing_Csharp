using System;

namespace Matrizes
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Console.Write("How many places does the vector has ? ");
            int qtdVec = Convert.ToInt32(Console.ReadLine());
            int qtdNegativeValue = 0; 

            int [,]vect = new int[qtdVec, qtdVec];
            for (int i = 0; i < qtdVec; i++)
            {
                string []valores = Console.ReadLine().Split(' ');
                for (int j = 0; j < qtdVec; j++)
                {
                    if(int.Parse(valores[j]) < 0)
                        qtdNegativeValue++;
                    vect[i, j] = int.Parse(valores[j]);
                }
            }

            Console.Write("Diagonal : ");
            for (int i = 0; i < qtdVec; i++)
            {
                for (int j = 0; j < qtdVec; j++)
                {
                    if(i == j)
                        Console.Write(vect[i, j] + " ");
                }
            }
            Console.WriteLine("\nThe amount negative value : " + qtdNegativeValue);
        }
    }
}
