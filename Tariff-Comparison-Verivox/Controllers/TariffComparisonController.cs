using Microsoft.AspNetCore.Mvc;
using Tariff_Comparison_Verivox.Services;

namespace Tariff_Comparison_Verivox.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class TariffComparisonController : ControllerBase
    {
        private TariffComparisonService _tariffComparisonService;

        public TariffComparisonController(TariffComparisonService tariffComparisonService)
        {
            _tariffComparisonService = tariffComparisonService;
        }

        [HttpGet]
        public ActionResult<List<CalculationResult>> GetTariffComparison(double consumptionKwh)
        {
            var results = _tariffComparisonService.CompareTariffs(consumptionKwh);
            return results;
        }
    }
}
