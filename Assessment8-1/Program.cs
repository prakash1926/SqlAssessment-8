using System;
using System.Data.SqlClient;


class Program
{
    static void Main()
    {
        string connectionString = "server=LAPTOP-CG4A8NUA;database=Assessment8;trusted_connection=true;"; 

        try
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT TOP 5 PId, PName, PPrice, ExpDate, MnfDate FROM Products ORDER BY PName DESC";
                SqlCommand command = new SqlCommand(query, connection);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    Console.WriteLine("Top 5 Products in Descending Order of PName:");
                    Console.WriteLine("-----------------------------------------------------");
                    Console.WriteLine("ID\t| PName\t\t| Price\t| Expiry Date\t| Manufacturing Date");
                    Console.WriteLine("-----------------------------------------------------");

                    while (reader.Read())
                    {
                        int productId = reader.GetInt32(0);
                        string productName = reader.GetString(1);
                        int productPrice = reader.GetInt32(2);
                        DateTime expiryDate = reader.GetDateTime(3);
                        DateTime manufacturingDate = reader.GetDateTime(4);

                        Console.WriteLine($"{productId}\t| {productName}\t| {productPrice:C}\t| {expiryDate.ToShortDateString()}\t| {manufacturingDate.ToShortDateString()}");
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }

        Console.ReadLine(); // Keep console window open
    }
}
