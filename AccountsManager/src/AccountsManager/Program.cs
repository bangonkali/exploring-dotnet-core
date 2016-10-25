using System;
using MySql.Data.MySqlClient;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MySqlConnection connection = new MySqlConnection
            {
                ConnectionString = "sslmode=none;server=192.168.254.100;user id=user;password=password;persistsecurityinfo=True;port=3306;database=hwapp"
            };

            connection.Open();
            MySqlCommand command = new MySqlCommand("SELECT * FROM users;", connection);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                System.Console.WriteLine("username");
                while (reader.Read())
                {
                    Console.WriteLine($"{reader.FieldCount}");
                    string row = $"{reader["username"]}";
                    System.Console.WriteLine(row);
                }
            }

            connection.Close();
        }
    }
}