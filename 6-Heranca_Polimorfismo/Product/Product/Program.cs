using System;
using Product.Entities;

namespace Product
{
    public class Program
    {
        static void Main(string[] args)
        {
            ImportedProduct importedProduct = new ImportedProduct(customsFree: 20.00, name: "Tablet", price: 260.00);
            ProductCommom product = new ProductCommom(name: "Notebook", price:1100.00);
            UsedProduct usedProduct = new UsedProduct(manufactureDate: DateTime.Now, name: "Iphone", price: 400.00);

            Console.WriteLine(product.priceTag());
            Console.WriteLine(usedProduct.priceTag());
            Console.WriteLine(importedProduct.priceTag());
        }
    }
}
