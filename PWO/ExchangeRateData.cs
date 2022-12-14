using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PWO
{
    /// <summary>
    /// Klasa reprezentująca format danych, do których serializowane są dane w postaci JSON
    /// </summary>
    public class ExchangeRateData
    {
        public Rate[] rates { get; set; }
    }

    /// <summary>
    /// Klasa reprezentująca pojedyńczy obiekt w tablicy obiektów klasy <see cref="ExchangeRateData"/> ExchangeRateData
    /// </summary>
    public class Rate
    {
        public string currency { get; set; }
        public string code { get; set; }
        public float mid { get; set; }
    }

}
