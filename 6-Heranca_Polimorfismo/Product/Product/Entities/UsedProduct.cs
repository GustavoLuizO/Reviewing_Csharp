using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Entities
{
    public class UsedProduct : ProductCommom
    {
        private DateTime ManufactureDate { get; set; }

        public UsedProduct(DateTime manufactureDate, string name, double price) : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string priceTag()
        {
            return Name + " (used) $ " + Price + " (" + ManufactureDate + ")";
        }
    }
}
