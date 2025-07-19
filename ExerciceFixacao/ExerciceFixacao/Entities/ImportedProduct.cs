using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceFixacao.Entities
{
    internal class ImportedProduct : Product
    {
        public double CustomsFree { get; set; }

        public ImportedProduct() { }

        public ImportedProduct(string name, double price, double customsFree) : base(name, price)
        {
            CustomsFree = customsFree;
        }

        public override string PriceTag()
        {
            return $"{Name} $ {(Price + CustomsFree).ToString("F2",CultureInfo.InvariantCulture)} (Customsfee: $ {CustomsFree.ToString("F2", CultureInfo.InvariantCulture)})";
        }
    }
}
