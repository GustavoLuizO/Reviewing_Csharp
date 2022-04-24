using System;

namespace Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int horainicial = int.Parse(Console.ReadLine());
            int horafinal = int.Parse(Console.ReadLine());
            if (horafinal <= horainicial)
                Console.WriteLine("O JOGO DUROU  " + (24 - horainicial + horafinal));
            else
                Console.WriteLine("O jogo durou " + (horafinal - horainicial));

    
        }
    }
}
