using Microsoft.Data.Sqlite;
namespace PWO
{
    /// <summary>
    /// Klasa zawierająca metody do komunikacji z bazą danych dla modułu 2
    /// </summary>
    public class Db : IDisposable
    {
        private SqliteConnection _connection;

        /// <summary>
        /// Klasa obsługująca komunikacje z bazą danych dla modułu 2
        /// </summary>
        public Db()
        {
            CreateConenction();
            InitializeDb();
        }

        /// <summary>
        /// Funkcja inicjalizująca połączenie do bazy danych
        /// </summary>
        private void CreateConenction()
        {
            _connection = new SqliteConnection("Data Source=database.db;");
            _connection.Open();
        }

        /// <summary>
        /// Funkcja tworząca w bazie odpowiednią tabele
        /// </summary>
        private void InitializeDb()
        {
            string cmd = @"CREATE TABLE IF NOT EXISTS Rejestr
                            (id INTEGER PRIMARY KEY AUTOINCREMENT,
                            data TIMESTAMP DEFAULT (DATETIME('NOW')),
                            typ TEXT NOT NULL,
                            opis TEXT NOT NULL,
                            kwota REAL NOT NULL
                            )";
            using (var command = new SqliteCommand(cmd, _connection))
            {
                command.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Asynchroniczna funkcja dodająca nowy wpis do bazy danych
        /// </summary>
        /// <param name="typ">Typ tranzakcji (wydatek lub wpływ)</param>
        /// <param name="opis">Opis tranzakcji</param>
        /// <param name="kwota">Kwota tranzakcji</param>
        /// <returns>Zadanie reprezentujące asynchroniczne dodane nowego wpisu do bazy danych.
        /// Resultat zawiera id nowo dodanego wpisu
        /// </returns>
        public async Task<int> AddDataAsync(string typ, string opis, decimal kwota)
        {
            string cmd = @"INSERT INTO Rejestr (typ, opis, kwota)
                            VALUES(@typ, @opis, @kwota)
                            RETURNING id;";
            using (var command = new SqliteCommand(cmd, _connection))
            {
                command.Parameters.AddWithValue("@typ", typ);
                command.Parameters.AddWithValue("@opis", opis);
                command.Parameters.AddWithValue("@kwota", typ == "WYDATEK" ? -kwota : kwota);
                return (Convert.ToInt32(await command.ExecuteScalarAsync()));
            }
        }

        /// <summary>
        /// Asynchroniczna funkcja usuwająca wpis.
        /// </summary>
        /// <param name="id">Id wpisu do usunięcia</param>
        /// <returns>Zadanie reprezentujące asynchroniczne usunięcie wpisu z bazy.</returns>
        public async Task DeleteDataAsync(int id)
        {
            string cmd = @"DELETE FROM Rejestr
                            WHERE id = @id;";
            using (var command = new SqliteCommand(cmd, _connection))
            {
                command.Parameters.AddWithValue("@id", id);
                await command.ExecuteNonQueryAsync();
            }
        }

        /// <summary>
        /// Asynchriniczna funkcja modyfikująca instiejący wpis w bazie
        /// </summary>
        /// <param name="id">Id wpisu do edycji</param>
        /// <param name="typ">Typ tranzakcji (wydatek lub wpływ)</param>
        /// <param name="opis">Opis tranzakcji</param>
        /// <param name="kwota">Kwota tranzakcji</param>
        /// <returns>Zadanie reprezentujące asynchroniczną edycje wpisu w bazie.</returns>
        public async Task EditDataAsync(int id, string typ, string opis, decimal kwota)
        {
            string cmd = @"UPDATE Rejestr
                            SET typ = @typ,
                                opis = @opis,
                                kwota = @kwota
                            WHERE id = @id;";
            using (var command = new SqliteCommand(cmd, _connection))
            {
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@typ", typ);
                command.Parameters.AddWithValue("@opis", opis);
                command.Parameters.AddWithValue("@kwota", kwota);
                await command.ExecuteNonQueryAsync();
            }
        }

        /// <summary>
        /// Asynchroniczna funkcja pobierająca dane z bazy dla danego id
        /// </summary>
        /// <param name="id">Id wpisu</param>
        /// <returns>Zadanie reprezentujące asynchroniczne pobranie wpisu z bazy danych.
        /// Resultat zawiera obiekt <see cref="RejestrData"/> RejestrData
        /// </returns>
        public async Task<RejestrData?> GetEntryAsync(int id)
        {
            string cmd = @"SELECT * FROM Rejestr
                            WHERE id = @id;";
            RejestrData? result = null;
            using (var command = new SqliteCommand(cmd, _connection))
            {
                command.Parameters.AddWithValue("@id", id);
                using (var dataReader = await command.ExecuteReaderAsync())
                {
                    if (dataReader.Read())
                    {
                        result = new()
                        {
                            Id = dataReader.GetInt32(0),
                            Data = dataReader.GetDateTime(1),
                            Typ = dataReader.GetString(2),
                            Opis = dataReader.GetString(3),
                            Kwota = Convert.ToDecimal(dataReader.GetFloat(4))
                        };
                    }
                }
            }
            return result;
        }

        /// <summary>
        /// Asynchroniczna funkcja pobierająca wszystkie dane z bazy
        /// </summary>
        /// <returns>Zadanie reprezentujące asynchroniczne pobranie wszystkich danych z bazy danych.
        /// Resultat zawiera liste obiektów <see cref="RejestrData"/> RejestrData
        /// </returns>
        public async Task<List<RejestrData>> GetDataAsync()
        {
            List<RejestrData> data = new();

            string cmd = @"SELECT * FROM Rejestr
                            ORDER BY id ASC;";
            using (var command = new SqliteCommand(cmd, _connection))
            {
                using (var dataReader = await command.ExecuteReaderAsync())
                {
                    while (dataReader.Read())
                    {
                        data.Add(new RejestrData
                        {
                            Id = dataReader.GetInt32(0),
                            Data = dataReader.GetDateTime(1),
                            Typ = dataReader.GetString(2),
                            Opis = dataReader.GetString(3),
                            Kwota = Convert.ToDecimal(dataReader.GetFloat(4))
                        });
                    }
                }
            }
            return data;
        }

        /// <summary>
        /// Funkcja zamykająca i utylizująca połączenie z bazą
        /// </summary>
        public void Dispose()
        {
            _connection.Close();
            _connection.Dispose();
        }
    }
}
