namespace Comparison
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            products.Add(new Product("TV", 900));
            products.Add(new Product("Notebook", 1200));
            products.Add(new Product("America", 450));

            //products.Sort(CompareProductsForName);
            products.Sort(CompareProductsForPriece);

            foreach (Product product in products)
            {
                Console.WriteLine(product);
            }
        }

        static int CompareProductsForName(Product product1, Product product2)
        {
            return product1.Nome.ToUpper().CompareTo(product2.Nome.ToUpper());
        }

        static int CompareProductsForPriece(Product product1, Product product2)
        {
            return product1.Priece.CompareTo(product2.Priece);
        }
    }
}
