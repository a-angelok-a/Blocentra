using Blocentra.Models;

namespace Blocentra.Services
{
    public interface ICryptoApiService
    {
        string ExchangeName { get; }
        Task<CryptoResult> GetCurrencyAsync(string symbol);
    }
}