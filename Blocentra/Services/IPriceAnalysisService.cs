using Blocentra.Models;

namespace Blocentra.Services
{
    public interface IPriceAnalysisService
    {
        CryptoCurrency GetLowerPrice(IEnumerable<CryptoResult> results);
        CryptoCurrency GetHighestPrice(IEnumerable<CryptoResult> results);
    }
}
