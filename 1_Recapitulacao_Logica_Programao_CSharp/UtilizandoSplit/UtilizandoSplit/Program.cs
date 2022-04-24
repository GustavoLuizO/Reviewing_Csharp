using System;

namespace UtilizandoSplit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string []Repartido = Console.ReadLine().Split(' ');
            string fruta1 = Repartido[0];
            string fruta2 = Repartido[1];
            string fruta3 = Repartido[2];
            Console.WriteLine(fruta1 + "\n" + fruta2 + '\n' + fruta3);
        }
    }
}
