namespace PWO
{
    /// <summary>
    /// Klasa reprezentująca dane w bazie danych z modułu 2
    /// </summary>
    public class RejestrData
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public string Typ { get; set; }
        public string Opis { get; set; }
        public decimal Kwota { get; set; }

        /// <summary>
        /// Funckja porównująca dwa obiekty typu <see cref="RejestrData"/>RejestrData
        /// </summary>
        /// <param name="obj">Obiekt typu <see cref="RejestrData"/>RejestrData do porównania</param>
        /// <returns>Wartość bool określająca czy porównywane obiekty mają te same wartości</returns>
        public override bool Equals(object? obj)
        {
            return obj is RejestrData data &&
                   Id == data.Id &&
                   Data.Date == data.Data.Date &&
                   Typ == data.Typ &&
                   Opis == data.Opis &&
                   Kwota == data.Kwota;
        }
    }
}
