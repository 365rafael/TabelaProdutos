

namespace TabelaProdutos.Entities
{
    internal class UsedProduct : Produto
    {
        public DateTime ManufatureDate { get; set; }

        public UsedProduct()
        {
        }

        public UsedProduct(DateTime manufatureDate, string name, double price) : base(name, price)
        {
            ManufatureDate = manufatureDate;
        }

        public override string PriceTag()
        {
            return Name + $" (used) $ {Price}" + $" (Manufature date: " + ManufatureDate.ToString("dd/MM/yyyy") + ")";
        }
    }
}
