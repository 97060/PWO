

namespace PWO.TESTS
{
    public class Module2Tests
    {
        private readonly Db _db = new();

        [Test]
        public async Task AddDbEntry()
        {
            RejestrData expected = new()
            {
                Id = 0,
                Data = DateTime.Now.Date,
                Kwota = 1000m,
                Typ = "WPŁYW",
                Opis = "test"
            };
            expected.Id = await _db.AddDataAsync("WPŁYW", "test", 1000m);
            var actual = await _db.GetEntryAsync(expected.Id);
            Assert.That(expected, Is.EqualTo(actual));

        }

        [Test]
        public async Task EditDbEntry()
        {
            RejestrData expected = new()
            {
                Id = 0,
                Data = DateTime.Now.Date,
                Kwota = 2000m,
                Typ = "WYDATEK",
                Opis = "test2"
            };
            expected.Id = await _db.AddDataAsync("WPŁYW", "test", 1000m);
            await _db.EditDataAsync(expected.Id, "WYDATEK", "test2", 2000m);

            var actual = await _db.GetEntryAsync(expected.Id);
            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public async Task DeleteDbEntry()
        {
            RejestrData expected = new()
            {
                Id = 0,
                Data = DateTime.Now.Date,
                Kwota = 1000m,
                Typ = "WPŁYW",
                Opis = "test"
            };
            expected.Id = await _db.AddDataAsync("WPŁYW", "test", 1000m);
            await _db.DeleteDataAsync(expected.Id);
            var entry = await _db.GetEntryAsync(expected.Id);
            Assert.That(entry, Is.Null);
        }
    }

}