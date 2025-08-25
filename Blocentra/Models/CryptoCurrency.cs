namespace Blocentra.Models
{
    public class CryptoCurrency
    {
        public string Symbol { get; set; }

        public decimal BidPrice { get; set; }
        public decimal AskPrice { get; set; }

        public string ExchangeName { get; set; }

    }
}
