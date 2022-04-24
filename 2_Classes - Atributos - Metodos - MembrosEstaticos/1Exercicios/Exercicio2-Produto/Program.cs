using System;

namespace Exercicio2_Produto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto p1 = new Produto();
            Console.WriteLine("Entre com os dados do produto : ");
            Console.Write("Nome : ");
            p1.Nome1 = Console.ReadLine();
            Console.Write("Preco : ");
            p1.Preco1 = double.Parse(Console.ReadLine());
            Console.Write("Quantidade no estoque : ");
            p1.Quantidade1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do produto : " + p1.ToString());

            Console.Write("Digite o número de produtos a ser adicionado ao estoque :");
            int numestocar = int.Parse(Console.ReadLine());
            p1.AdicionarProduto(numestocar);
            Console.WriteLine("Dados atualizados : " + p1.ToString()); 

            Console.Write("Digite o número de produtos a ser removido do estoque : ");
            int numremover = int.Parse(Console.ReadLine());
            p1.RemoverProduto(numremover);
            Console.WriteLine("Dados Atualizados : " + p1.ToString());

        }
    }
}
