// Data/Services/IExchangeRateService.cs
public interface IExchangeRateService
{
    Task<ExchangeRateResponse> GetRatesAsync(string baseCurrency);
}
