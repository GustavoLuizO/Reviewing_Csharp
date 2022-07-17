using System;

namespace Matrix_Fixacao
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many lines does the vector has ? ");
            int linhas = Convert.ToInt32(Console.ReadLine());
            Console.Write("How many colums does the vector has ? ");
            int colunas = Convert.ToInt32(Console.ReadLine());

            string[] values = new string[colunas];
            int [,]vector = new  int[linhas, colunas];

            for (int i = 0; i < linhas; i++)
            {
                values = Console.ReadLine().Split(' ');
                for (int j = 0; j < colunas; j++)
                {
                    vector[i,j] = Convert.ToInt32(values[j]);
                }
            }

            Console.Write("What value do you want verified ? ");
            int value = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    if( vector[i,j] == value)
                    {
                        Console.WriteLine("Position : " + i + " , " + j);
                        if (j > 0)
                        {
                            Console.WriteLine("Left: " + vector[i, j - 1]);
                        }
                        if (i > 0)
                        {
                            Console.WriteLine("Up: " + vector[i - 1, j]);
                        }

                        //Not used correctly
                        //if (j < linhas - 1 )
                        //{
                        //    Console.WriteLine("Right: " + vector[i, j + 1]);
                        //}
                        //if (i < colunas - 1 && i != 1)
                        //{
                        //    Console.WriteLine("Down: " + vector[i + 1, j]);
                        //}
                    }
                }
                Console.WriteLine();
            }

        }
    }
}
