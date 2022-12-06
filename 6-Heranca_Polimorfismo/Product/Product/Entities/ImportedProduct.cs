using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Entities
{
    public class ImportedProduct : ProductCommom
    {
        private double CustomsFee { get; set; }

        public ImportedProduct(double customsFee, string name, double price) : base(name, price)
        {
            CustomsFee = customsFee;
        }

        public override string priceTag()
        {
            return Name + "$ " + (Price + CustomsFee).ToString("0.00") + " (Cumtons Free : " + CustomsFee.ToString("#.##") + ")";
        }
    }
}