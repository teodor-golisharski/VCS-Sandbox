using Microsoft.Data.SqlClient;

namespace ADO.NET_demo
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            string connectionString = "Server=.;Database=Demo;Trusted_Connection=True;TrustServerCertificate=True;";
            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();

            using (connection)
            {
                SqlCommand command = new SqlCommand("SELECT * FROM Krum;", connection);
                SqlDataReader reader = await command.ExecuteReaderAsync();

                using (reader)
                {
                    reader.Read();
                    string name = (string)reader["first_name"];
                    string last_name = (string)reader["last_name"];

                    Console.WriteLine(name+" "+last_name);
                }

                
            }
        }
    }
}
