using System.Text.Json;

namespace PWO
{
    /// <summary>
    /// Klasa obsługująca pobieranie i przetwarzanie danych do modułu 1
    /// </summary>
    public class ExchangeRateClient
    {
        private readonly NbpClient _client;

        /// <summary>
        /// Konstruktor klasy
        /// </summary>
        public ExchangeRateClient()
        {
            _client = new();
        }

        /// <summary>
        /// Asynchroniczna funkcja pobierająca dane w postaci JSON i przetwarzająca je na tabice obiektów <see cref="Rate"/>Rate
        /// </summary>
        /// <returns>Zadanie reprezentujące asynchroniczne pobranie i przetwarzanie danych.
        /// Resultat zawiera tablicę obiektów <see cref="Rate"/>Rate
        /// </returns>
        public async Task<Rate[]?> GetData()
        {
            var data = await _client.GetExchangeRateResponseAsync();
            Rate[]? ratesArray = null;
            var result = await JsonSerializer.DeserializeAsync<ExchangeRateData[]>(await data.Content.ReadAsStreamAsync());
            if (result != null)
                ratesArray = result[0].rates;
            return ratesArray;
        }
    }
}
