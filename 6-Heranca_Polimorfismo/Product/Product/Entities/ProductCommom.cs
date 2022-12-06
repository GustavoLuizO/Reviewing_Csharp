using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Entities
{
    public class ProductCommom
    {
        protected string Name { get; set; }
        protected double Price { get; set; }

        public ProductCommom(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual string priceTag()
        {
            return Name + " $ " + Price.ToString("0.00");
        }
    }
}
