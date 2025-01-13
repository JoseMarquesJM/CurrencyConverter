namespace CC.Api.Models.Entities
{
    public class ExchangeRateResponse
    {
        public string Origem { get; set; }
        public string Destino { get; set; }
        public decimal  Quantidade { get; set; } // Moeda e valor
    }
}
