using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio2_Produto
{
    public class Produto
    {
        private string Nome;
        private double Preco;
        private int Quantidade;

        public string Nome1 { get => Nome; set => Nome = value; }
        public double Preco1 { get => Preco; set => Preco = value; }
        public int Quantidade1 { get => Quantidade; set => Quantidade = value; }

        public double ValorTotalEmEstoque()
        {
            return (Preco * Quantidade);
        }
        public void AdicionarProduto(int quantity)
        {
            Quantidade += quantity;
        }
        public void RemoverProduto(int quantity)
        {
            Quantidade -= quantity;
        }
        public override string ToString()
        {
            return Nome + ", $ "+Preco.ToString("0.00") + ", "+Quantidade + " unidades, Total : $ " + ValorTotalEmEstoque().ToString("0.00");
        }
    }
}
