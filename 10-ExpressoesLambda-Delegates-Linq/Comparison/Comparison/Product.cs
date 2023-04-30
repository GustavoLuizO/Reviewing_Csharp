using System.Net.Http.Headers;

namespace Comparison
{
    public class Product
    {
        public string Nome { get; }
        public float Priece { get; }

        public Product(string nome, float priece)
        {
            Nome = nome;
            Priece = priece;
        }

        public override string ToString()
        {
            return "Nome: " + Nome + " | " + "Priece: " + Priece;
        }
    }
}
