using Blocentra.Models;

namespace Blocentra.Services
{
    public interface ITimeSeriesPredictionService
    {
        void TrainModel(IEnumerable<CryptoData> historicalData, int horizon);
        float[] Forecast(int horizon);
    }
}
