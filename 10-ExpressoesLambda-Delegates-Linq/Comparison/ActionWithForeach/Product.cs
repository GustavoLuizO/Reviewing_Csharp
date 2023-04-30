namespace ActionWithForeach
{
    public class Product
    {
        public string Nome { get; set; }
        public double Priece { get; set; }

        public Product(string nome, double priece)
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
