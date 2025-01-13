using CC.Api.Models.Entities;
using CC.Api.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CC.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExchangeRateController : ControllerBase
    {
        private readonly ExchangeRateService _exchangeRateService;

        public ExchangeRateController(ExchangeRateService exchangeRateService)
        {
            _exchangeRateService = exchangeRateService;
        }

        [HttpPost]
        public async Task<IActionResult> GetRates(string origem, string destino, decimal quantidade)
        {
            try
            {
                var rates = await _exchangeRateService.GetExchangeRatesAsync(origem,destino,quantidade);
                return Ok(rates);
            }
            catch (Exception ex)
            {
                return BadRequest(new { Message = "Erro ao buscar taxas de câmbio", Error = ex.Message });
            }
        }
    }
}
