namespace ActionWithForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            products.Add(new Product("TV", 900.00));
            products.Add(new Product("Notebook", 1200.00));
            products.Add(new Product("America", 450.00));

            products.ForEach(UpdatePriece);

            foreach (Product product in products)
                Console.WriteLine(product);
            
        }
        
        static void UpdatePriece(Product product)
        {
            product.Priece += product.Priece * 0.1;
        }
    }
}
