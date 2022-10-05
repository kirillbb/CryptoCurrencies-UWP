using Newtonsoft.Json;

namespace СryptoСurrency.Models
{
    public class CoinList
    {
        [JsonProperty("data")]
        public Coin[] Coins { get; set; }
    }
}
