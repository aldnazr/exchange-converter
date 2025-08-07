public class ExchangeRateResponse
{
    public string? Result { get; set; }
    public string? Time_Last_Update_Utc { get; set; }
    public Dictionary<string, decimal>? Conversion_Rates { get; set; }
}