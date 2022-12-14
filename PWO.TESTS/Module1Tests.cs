namespace PWO.TESTS
{
    public class Module1Tests
    {

        [Test] 
        public async Task Response_StatusCode_Is_200()
        {
            NbpClient _nbpClient = new();
            var actual = await _nbpClient.GetExchangeRateResponseAsync();
            Assert.That(actual.IsSuccessStatusCode);
        }

        [Test]
        public async Task Response_Is_JSON()
        {
            NbpClient _nbpClient = new();
            var actual = await _nbpClient.GetExchangeRateResponseAsync();
            Assert.That(actual.Content.Headers.ContentType, Is.Not.Null);
            Assert.That(actual.Content.Headers.ContentType.MediaType, Is.EqualTo("application/json"));
        }

        [Test]
        public async Task Response_Data_Not_Empty()
        {
            ExchangeRateClient _exchangeRate = new();
            var actual = await _exchangeRate.GetData();
            Assert.That(actual, Is.Not.Null);
            Assert.That(actual.Count, Is.GreaterThan(0));
        }

    }
}
