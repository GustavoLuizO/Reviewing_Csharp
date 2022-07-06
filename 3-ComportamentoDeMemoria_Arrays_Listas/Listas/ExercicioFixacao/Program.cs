using System;
using System.Collections.Generic;

namespace ExercicioFixacao
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool possuiIdList = false;
            List<Funcionario> lista = new List<Funcionario>();
            Funcionario func;
            int idfunc;
            Console.Write("Digite a quantidade de funcionarios que irão ser cadastrados : ");
            int qtdFunc = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < qtdFunc; i++)
            {
                Console.Clear();
                do {
                    if (possuiIdList)
                        Console.WriteLine("Esse Id já está sendo usado");

                    Console.Write("Id : ");
                    idfunc = Convert.ToInt32(Console.ReadLine());
                } while (lista.Exists(x => x.Id == idfunc) ? possuiIdList = true : possuiIdList = false);

                Console.Write("Nome : ");
                string nome = Console.ReadLine();

                Console.Write("Salario : ");
                double salario = Convert.ToDouble(Console.ReadLine());

                func = new Funcionario(idfunc, nome, salario);
                lista.Add(func);
            }
            Console.Clear();
            Console.Write("Digite o Id do funcionario que irá receber o aumento : ");
            int idFuncionarioPremiado = Convert.ToInt32(Console.ReadLine());

            if (lista.Exists(x => x.Id == idFuncionarioPremiado))
            {
                Console.Write("Porcentagem : ");
                double porcentagem = Convert.ToDouble(Console.ReadLine());
                porcentagem = porcentagem / 100;
                lista.Find(item => item.Id == idFuncionarioPremiado).AumentoSalario(porcentagem);
            }
            else
                Console.WriteLine("Não existe esse funcionario ");

            Console.Clear ();
            foreach (var item in lista)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
