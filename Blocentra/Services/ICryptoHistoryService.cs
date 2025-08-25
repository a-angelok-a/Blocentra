using Blocentra.Models;

namespace Blocentra.Services
{
    public interface ICryptoHistoryService
    {
        List<CryptoData> LoadHistory();
        void SaveHistory(List<CryptoData> history);
    }
}