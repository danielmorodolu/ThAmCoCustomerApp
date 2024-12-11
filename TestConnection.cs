using System;
using Microsoft.Data.SqlClient;

partial class Program
{
    static void TestDatabaseConnection()
    {
        string connectionString = "Server=tcp:ThAmCoDatabaseServer.database.windows.net,1433;Database=ThAmCoDB;User ID=CloudSAe15c0eca;Password=Daniel2023.;Encrypt=True;";

        using (var connection = new SqlConnection(connectionString))
        {
            try
            {
                connection.Open();
                Console.WriteLine("Connection successful!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Connection failed: {ex.Message}");
            }
        }
    }
}
