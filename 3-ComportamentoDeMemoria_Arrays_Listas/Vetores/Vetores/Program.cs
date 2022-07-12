using System;

namespace Vetores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RegistroHospedagem[] quartosRegistro = new RegistroHospedagem[10];
            
            Console.WriteLine("Quantos quartos serão alugados ?");
            int qtdQuartos = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < qtdQuartos; i++)
            {
                string nomeHospede = Console.ReadLine();
                string emailHospede = Console.ReadLine();
                int quartoEscolhido = Convert.ToInt32(Console.ReadLine());

                quartosRegistro[quartoEscolhido] = new RegistroHospedagem { NameHospede = nomeHospede, EmailHospede = emailHospede };
            }
            
            for (int i = 0; i < quartosRegistro.Length; i++)
            {
                if (quartosRegistro[i] != null)
                {
                    Console.WriteLine(i + ": " + quartosRegistro[i].NameHospede + " , " + quartosRegistro[i].EmailHospede);
                }
            }
        }
    }
}
