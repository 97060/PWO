using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PWO
{
    /// <summary>
    /// Klasa zawierająca kalkulator do danych z modułu 3
    /// </summary>
    public static class SalaryCalculator
    {
        /// <summary>
        /// Funkcja obliczająca szczegółowe dane dotyczące pensji po wszystkich składkach i podatku
        /// </summary>
        /// <param name="brutto">Kwota brutto</param>
        /// <param name="pit0">Czy pit zerowy</param>
        /// <returns>Obiekt typu <see cref="SalaryData"/>SalaryData zawierający obliczone wartości</returns>
        public static SalaryData CalculateSalary(decimal brutto, bool pit0)
        {
            if (brutto <= 0)
            {
                throw new AmountLessThanOrEqualZeroException();
            }
            SalaryData data = new()
            {
                SkladkaEmerytalna = brutto * (decimal)0.0976,
                SkladkaRentowna = brutto * (decimal)0.015,
                SkladkaChorobowa = brutto * (decimal)0.0245
            };
            decimal skladkiSpoleczne = data.SkladkaEmerytalna + data.SkladkaRentowna + data.SkladkaChorobowa;
            data.SkladkaZdrowotna = Math.Round((brutto - skladkiSpoleczne) * (decimal)0.09, 2, MidpointRounding.ToPositiveInfinity);
            data.Tax = pit0 ? 0 : Math.Max(Math.Round((Math.Round(brutto - skladkiSpoleczne - 250) * (decimal)0.12) - 300), 0);
            data.Netto = brutto - skladkiSpoleczne - data.SkladkaZdrowotna - data.Tax;

            return data;
        }
    }
}
