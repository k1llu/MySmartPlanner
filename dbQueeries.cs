using Microsoft.VisualBasic.ApplicationServices;
using System.Data.SQLite;
using System.IO;
using System.Security.Cryptography;
using System.Text;

public static class DatabaseQueries
{
    private static readonly byte[] encryptionKey = Encoding.UTF8.GetBytes("YourSecretKey123");
    private static readonly byte[] iv = Encoding.UTF8.GetBytes("1234567890123456");

    private static string pathToDB = Path.Combine(
        Path.GetDirectoryName(typeof(DatabaseQueries).Assembly.Location),
        "..\\..\\..\\Files",
        "smartplanner.db"
    );

    //Шифрування RSA - CBC
    private static string EncryptString(string plainText)
    {
        using (Aes aesAlg = Aes.Create())
        {
            aesAlg.Key = encryptionKey;
            aesAlg.IV = iv;
            aesAlg.Mode = CipherMode.CBC;

            ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

            using (var msEncrypt = new System.IO.MemoryStream())
            {
                using (var csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                {
                    byte[] plainTextBytes = Encoding.UTF8.GetBytes(plainText);
                    csEncrypt.Write(plainTextBytes, 0, plainTextBytes.Length);
                }
                return Convert.ToBase64String(msEncrypt.ToArray());
            }
        }
    }
    //Дешифрування RSA - CBC
    private static string DecryptString(string cipherText)
    {
        using (Aes aesAlg = Aes.Create())
        {
            aesAlg.Key = encryptionKey;
            aesAlg.IV = iv;
            aesAlg.Mode = CipherMode.CBC;

            ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

            using (var msDecrypt = new System.IO.MemoryStream(Convert.FromBase64String(cipherText)))
            using (var csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
            using (var srDecrypt = new System.IO.StreamReader(csDecrypt, Encoding.UTF8))
            {
                return srDecrypt.ReadToEnd();
            }
        }
    }

    //Підключеня
    public static void InitializeConnection()
    {
        if (!File.Exists(pathToDB))
        {
            SQLiteConnection.CreateFile(@"..\..\..\Files\smartplanner.db");
        }

    }
    //Реєстрація
    public static void RegisterUser(string email, string username, string hashPassword)
    {
        string query = "INSERT INTO User (email, username, password) VALUES (@username, @email, @password)";

        using (var connection = new SQLiteConnection($"Data Source={pathToDB};Version=3;"))
        {
            connection.Open();

            using (var command = new SQLiteCommand(query, connection))
            {
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@password", hashPassword);

                command.ExecuteNonQuery();
            }
        }
    }
    //Логін
    public static int LoginUser(string email, string password)
    {
        int userId = -1;

        using (SQLiteConnection connection = new SQLiteConnection($"Data Source={pathToDB};Version=3;"))
        {
            connection.Open();

            string query = "SELECT id FROM User WHERE Email = @Email AND Password = @Password";

            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Password", password);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        userId = reader.GetInt32(reader.GetOrdinal("id"));
                    }
                }
            }
            connection.Close();
        }
        return userId;
    }

    //Додати івент
    public static void AddEvent(string name, string description, DateTime date, int userId)
    {
        using (SQLiteConnection connection = new SQLiteConnection($"Data Source={pathToDB};Version=3;"))
        {
            connection.Open();

            string insertQuery = @"
            INSERT INTO Events (name, description, date, userid)
            VALUES (@name, @description, @date, @userid)";

            using (SQLiteCommand command = new SQLiteCommand(insertQuery, connection))
            {
                command.Parameters.AddWithValue("@name", EncryptString(name));
                command.Parameters.AddWithValue("@description", EncryptString(description));
                command.Parameters.AddWithValue("@date", EncryptString(date.ToString("yyyy-MM-dd HH:mm:ss")));
                command.Parameters.AddWithValue("@userid", userId);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    Console.WriteLine("Подію успішно додано.");
                }
                else
                {
                    Console.WriteLine("Не вдалося додати подію.");
                }
            }
        }
    }
    //Видалити івент за ід
    public static bool DeleteEvent(int idUser, int eventId)
    {
        using (SQLiteConnection connection = new SQLiteConnection($"Data Source={pathToDB};Version=3;"))
        {
            connection.Open();

            string checkQuery = "SELECT COUNT(*) FROM Events WHERE id = @eventId AND userid = @userId";
            using (SQLiteCommand checkCommand = new SQLiteCommand(checkQuery, connection))
            {
                checkCommand.Parameters.AddWithValue("@eventId", eventId);
                checkCommand.Parameters.AddWithValue("@userId", idUser);
                int count = Convert.ToInt32(checkCommand.ExecuteScalar());

                if (count == 0)
                {
                    Console.WriteLine($"Подію з id {eventId} не знайдено або вона не належить користувачу з id {idUser}.");
                    return false;
                }
            }

            string deleteQuery = "DELETE FROM Events WHERE id = @eventId AND userid = @userId";
            using (SQLiteCommand command = new SQLiteCommand(deleteQuery, connection))
            {
                command.Parameters.AddWithValue("@eventId", eventId);
                command.Parameters.AddWithValue("@userId", idUser);
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    Console.WriteLine($"Подію з id {eventId} успішно видалено.");
                    return true;
                }
                else
                {
                    Console.WriteLine($"Не вдалося видалити подію з id {eventId}.");
                    return false;
                }
            }
        }
    }

    //Отримати всі івенти за ід
    public static List<(int id, string name)> GetUserEvents(int userId)
    {
        var events = new List<(int id, string name)>();

        using (SQLiteConnection connection = new SQLiteConnection($"Data Source={pathToDB};Version=3;"))
        {
            connection.Open();

            string selectQuery = @"
            SELECT id, name
            FROM Events
            WHERE userid = @userid";

            using (SQLiteCommand command = new SQLiteCommand(selectQuery, connection))
            {
                command.Parameters.AddWithValue("@userid", userId);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string name = DecryptString(reader.GetString(1));

                        events.Add((id, name));
                    }
                }
            }
        }

        return events;
    }
    //Отримати дані івенту
    public static (string name, string description, DateTime date)? GetEvent(int eventId)
    {
        using (SQLiteConnection connection = new SQLiteConnection($"Data Source={pathToDB};Version=3;"))
        {
            connection.Open();
            string selectQuery = @"
            SELECT name, description, date
            FROM Events
            WHERE id = @eventId";

            using (SQLiteCommand command = new SQLiteCommand(selectQuery, connection))
            {
                command.Parameters.AddWithValue("@eventId", eventId);
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string name = DecryptString(reader.GetString(0));
                        string description = DecryptString(reader.IsDBNull(1) ? null : reader.GetString(1));
                        DateTime date = DateTime.Parse(DecryptString(reader.GetString(2)));
                        return (name, description, date);    
                    }
                }
            }
        }
        return null;
    }

    //Отримати ім'я користувача
    public static string GetUsername(int userId)
    {
        string username = null;

        using (SQLiteConnection connection = new SQLiteConnection($"Data Source={pathToDB};Version=3;"))
        {
            connection.Open();

            string query = "SELECT username FROM User WHERE id = @userId";
            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                command.Parameters.AddWithValue("@userId", userId);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        username = reader.GetString(reader.GetOrdinal("username"));
                    }
                }
            }
            connection.Close();
        }

        return username;
    }
    public static string GetUserEmail(int userId)
    {
        string email = null;

        using (SQLiteConnection connection = new SQLiteConnection($"Data Source={pathToDB};Version=3;"))
        {
            connection.Open();

            string selectQuery = "SELECT email FROM User WHERE id = @userId";

            using (SQLiteCommand command = new SQLiteCommand(selectQuery, connection))
            {
                command.Parameters.AddWithValue("@userId", userId);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        email = reader.GetString(0);
                    }
                }
            }
        }

        if (string.IsNullOrEmpty(email))
        {
            throw new Exception($"Користувача з id {userId} не знайдено або email не вказано.");
        }

        return email;
    }
}
