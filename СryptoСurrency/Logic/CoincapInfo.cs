using System.Collections.Generic;
using СryptoСurrency.Models;

namespace СryptoСurrency.Logic
{
    public static class CoincapInfo
    {
        const string url = "https://api.coincap.io/v2/";

        public static CoinList GetCoins(int? limit = 10, int? offset = 0)
        {
            string urlParameters = $"assets?limit={limit}&offset={offset}";

            var response = APICall.RunAsync<CoinList>(url, urlParameters).GetAwaiter().GetResult();

            return response;
        }

        public static CoinList GetCoin(string id)
        {
            string urlParameters = $"assets?ids={id}";

            var response = APICall.RunAsync<CoinList>(url, urlParameters).GetAwaiter().GetResult();

            return response;
        }

        public static CoinList SearchCoin(string name)
        {
            string urlParameters = $"assets?search={name}";

            var response = APICall.RunAsync<CoinList>(url, urlParameters).GetAwaiter().GetResult();

            return response;
        }
    }
}
