using System;

namespace LastExercise_For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valorrepticoes;
            do
            {
                Console.Write("Digite um valor maior do que 1 e menor do que 1000 : ");
                valorrepticoes = Convert.ToInt32(Console.ReadLine());
            } while (!(valorrepticoes >= 1 && valorrepticoes <= 1000));

            for(int i = 0; i < valorrepticoes; i++)
            {
                if (i % 2 == 1)
                    Console.WriteLine(i);
            }
        }
    }
}
