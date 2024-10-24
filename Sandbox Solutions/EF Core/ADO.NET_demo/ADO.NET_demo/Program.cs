using Microsoft.Data.SqlClient;

namespace ADO.NET_demo
{
    internal class Program
    {
        public void Insert(SqlConnection connection)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Krum " + "(number, first_name, last_name) VALUES " +
                    "(@number, @first_name, @last_name)", connection);

            int number = int.Parse(Console.ReadLine()!);
            string first_name = Console.ReadLine()!;
            string last_name = Console.ReadLine()!;

            cmd.Parameters.AddWithValue("@number", number);
            cmd.Parameters.AddWithValue("@first_name", first_name);
            cmd.Parameters.AddWithValue("@last_name", last_name);

            cmd.ExecuteNonQuery();
        }

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
                    while (reader.Read())
                    {
                        int number = (int)reader["number"];
                        string name = (string)reader["first_name"];
                        string last_name = (string)reader["last_name"];

                        Console.WriteLine(number + " " + name + " " + last_name);
                    }
                }
            }
        }
    }
}
