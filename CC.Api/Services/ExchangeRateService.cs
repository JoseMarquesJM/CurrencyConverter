using CC.Api.Models.Entities;
using System.Text.Json;

namespace CC.Api.Services
{
    public class ExchangeRateService
    {
        private readonly HttpClient _httpClient;

        public ExchangeRateService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<ExchangeRateResponseAPI> GetExchangeRatesAsync(string origem, string destino, decimal quantidade)
        {
            // URL da API (use sua chave de API real aqui)
            string apiKey = "3b599e83c623b59f0ba3b55f";
            string url = $"https://v6.exchangerate-api.com/v6/{apiKey}/pair/{origem}/{destino}/{quantidade}";

            var response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();

            // Deserializar a resposta
            return JsonSerializer.Deserialize<ExchangeRateResponseAPI>(await response.Content.ReadAsStringAsync());
        }
    }
}
