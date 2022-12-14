namespace PWO.TESTS
{
    public class Module3Tests
    {
        [Test]
        public void CalculareSalaryData_Without_Pit0()
        {
            SalaryData expected = new()
            {
                Netto = 3738.19m,
                SkladkaChorobowa = 122.5m,
                SkladkaEmerytalna = 488m,
                SkladkaRentowna = 75m,
                SkladkaZdrowotna = 388.31m,
                Tax = 188m
            };
            var actual = SalaryCalculator.CalculateSalary(5000, false);
            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void CalculareSalaryData_With_Pit0()
        {
            SalaryData expected = new()
            {
                Netto = 3926.19m,
                SkladkaChorobowa = 122.5m,
                SkladkaEmerytalna = 488m,
                SkladkaRentowna = 75m,
                SkladkaZdrowotna = 388.31m,
                Tax = 0m
            };
            var actual = SalaryCalculator.CalculateSalary(5000, true);
            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void CalculareSalaryData_With_Amount_Zero()
        {
            Assert.Throws<AmountLessThanOrEqualZeroException>(() => SalaryCalculator.CalculateSalary(0, true));
        }

        [Test]
        public void CalculareSalaryData_With_Amount_Less_Than_Zero()
        {
            Assert.Throws<AmountLessThanOrEqualZeroException>(() => SalaryCalculator.CalculateSalary(-1000, true));
        }
    }

}