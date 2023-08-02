using Tariff_Comparison_Verivox.Models;

namespace Tariff_Comparison_Verivox.Services
{
    public class TariffComparisonService
    {
        private List<Product> _products; 

        public TariffComparisonService(List<Product> products)
        {
            _products = products;
        }

        public List<CalculationResult> CompareTariffs(double consumptionKwh)
        {
            var results = new List<CalculationResult>();
            foreach (var product in _products)
            {
                double annualCost = CalculateAnnualCost(product, consumptionKwh);
                results.Add(new CalculationResult { TariffName = product.Name, AnnualCosts = annualCost });
            }

            return results.OrderBy(r => r.AnnualCosts).ToList();
        }

        private double CalculateAnnualCost(Product product, double consumptionKwh)
        {
            double annualCost = 0;

            if (product.Type == 1)
            {
                annualCost = (product.BaseCost * 12) + (consumptionKwh * product.AdditionalKwhCost);
            }
            else if (product.Type == 2)
            {
                annualCost = product.BaseCost;

                if (consumptionKwh > product.IncludedKwh)
                {
                    double additionalKwh = consumptionKwh - product.IncludedKwh;
                    annualCost += additionalKwh * product.AdditionalKwhCost;
                }
            }

            return annualCost;
        }
    }

    public class CalculationResult
    {
        public string TariffName { get; set; }
        public double AnnualCosts { get; set; }
    }
}

