using System;

namespace Exercicio3_FuncionarioImposto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario f = new Funcionario();
            Console.Write("Nome : ");
            f.Nome1 = Console.ReadLine();
            Console.Write("Salário bruto : ");
            f.SalarioBruto1 = double.Parse(Console.ReadLine());
            Console.Write("Imposto : ");
            f.Imposto1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Funcionario : " + f.ToString());
            Console.Write("Digite a porcentagem para aumentar o salário : ");
            double porcentagem = double.Parse(Console.ReadLine());
            f.AumentarSalario(porcentagem);
            Console.WriteLine("Dados atualizados :" + f.ToString());
        }
    }
}
