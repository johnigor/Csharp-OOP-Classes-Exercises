using System.Globalization;

namespace Desafio_Polimorfismo.Entities
{
    class ImportedProduct : Product
    {
        public double CustomFee { get; set; }

        public ImportedProduct()
        {
        }

        public ImportedProduct(string name, double price, double customFee)
            : base(name, price)
        {
            CustomFee = customFee;
        }

        public double TotalPrice()
        {
            return Price + CustomFee;
        }

        public override string PriceTag()
        {
            return Name
                + " $"
                + TotalPrice().ToString("F2", CultureInfo.InvariantCulture)
                + " (Custom fee: $"
                + CustomFee.ToString("F2", CultureInfo.InvariantCulture)
                + ")";
        }
    }
}
