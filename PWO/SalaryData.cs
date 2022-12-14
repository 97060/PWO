namespace PWO
{
    /// <summary>
    /// Klasa reprezentująca rezultat obliczeń z modułu 3
    /// </summary>
    public class SalaryData
    {
        public decimal Netto { get; set; }
        public decimal SkladkaEmerytalna { get; set; }
        public decimal SkladkaRentowna { get; set; }
        public decimal SkladkaChorobowa { get; set; }
        public decimal SkladkiSpoleczne
        {
            get
            {
                return SkladkaEmerytalna + SkladkaRentowna + SkladkaChorobowa;
            }
        }
        public decimal SkladkaZdrowotna { get; set; }
        public decimal Tax { get; set; }

        /// <summary>
        /// Funckja porównująca dwa obiekty typu <see cref="SalaryData"/>SalaryData
        /// </summary>
        /// <param name="obj">Obiekt typu <see cref="SalaryData"/>SalaryData do porównania</param>
        /// <returns>Wartość bool określająca czy porównywane obiekty mają te same wartości</returns>
        public override bool Equals(object? obj)
        {
            if (obj == null)
            {
                return false;
            }
            else
            {
                SalaryData sd = (SalaryData)obj;
                return (Netto == sd.Netto) &&
                    (SkladkaEmerytalna == sd.SkladkaEmerytalna) &&
                    (SkladkaRentowna == sd.SkladkaRentowna) &&
                    (SkladkaChorobowa == sd.SkladkaChorobowa) &&
                    (SkladkiSpoleczne == sd.SkladkiSpoleczne) &&
                    (SkladkaZdrowotna == sd.SkladkaZdrowotna) &&
                    (Tax == sd.Tax);
            }
        }
    }
}
