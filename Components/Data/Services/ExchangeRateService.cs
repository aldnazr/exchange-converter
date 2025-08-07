public class ExchangeRateService : IExchangeRateService
{
    private readonly HttpClient _http;
    private readonly string _apiKey = "c852387238b61bc198965dbd";

    public ExchangeRateService(HttpClient http)
    {
        _http = http;
    }

    public async Task<ExchangeRateResponse> GetRatesAsync(string baseCurrency)
    {
        var url = $"https://v6.exchangerate-api.com/v6/{_apiKey}/latest/{baseCurrency}";
        var response = await _http.GetFromJsonAsync<ExchangeRateResponse>(url);
        return response;
    }
}
