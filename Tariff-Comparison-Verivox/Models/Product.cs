namespace Tariff_Comparison_Verivox.Models
{
    public class Product
    {
        public string Name { get; set; }
        public int Type { get; set; }
        public double BaseCost { get; set; }
        public double AdditionalKwhCost { get; set; }
        public int IncludedKwh { get; set; }
    }
}

