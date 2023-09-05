using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PWO
{
    /// <summary>
    /// Klasa obsługująca połączenie z interfejcem API NBP
    /// </summary>
    public class NbpClient
    {
        private static readonly HttpClient _httpClient = new();

        /// <summary>
        /// Asynchroniczna funkcja pobierająca dane o kursach walut z API NBP
        /// </summary>
        /// <returns>Zadanie reprezentujące asynchroniczne pobranie danych z API NBP.<br></br>
        /// Resultat zawiera obiekt <see cref="HttpResponseMessage"/> HttpResponseMessage
        /// </returns>
        public async Task<HttpResponseMessage> GetExchangeRateResponseAsync()
        {
            return await _httpClient.GetAsync(@"https://api.nbp.pl/api/exchangerates/tables/a/?format=json");
        }
    }
}
