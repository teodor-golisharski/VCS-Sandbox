using Microsoft.Data.SqlClient;

void CreateDB(SqlConnection connection, string name)
{
    SqlCommand cmd = new SqlCommand($"CREATE DATABASE {name}", connection);

    cmd.ExecuteNonQuery();
}

void UseDB(SqlConnection connection, string name)
{
    SqlCommand cmd = new SqlCommand($"USE {name}", connection);

    cmd.ExecuteNonQuery();
}

void InsertCountries(SqlConnection connection, string name)
{
    SqlCommand cmd = new SqlCommand("INSERT INTO Countries ([Name]) VALUES (@name)", connection);
    cmd.Parameters.AddWithValue("@name", name);

    cmd.ExecuteNonQuery();
}

void InsertTowns(SqlConnection connection, string name, int countryCode)
{
    SqlCommand cmd = new SqlCommand("INSERT INTO Towns ([Name], CountryCode) VALUES (@name, @countryCode)", connection);
    cmd.Parameters.AddWithValue("@name", name);
    cmd.Parameters.AddWithValue("@countryCode", countryCode);

    cmd.ExecuteNonQuery();
}

void VillianNames(SqlConnection connection)
{
    SqlCommand cmd = new SqlCommand(@"
        SELECT v.[Name], COUNT(mv.VillainId) AS MinionsCount 
        FROM Villains AS v 
        JOIN MinionsVillains AS mv ON v.Id = mv.VillainId 
        GROUP BY v.Id, v.[Name] 
        HAVING COUNT(mv.VillainId) > 3 
        ORDER BY COUNT(mv.VillainId);", connection);

    SqlDataReader reader = cmd.ExecuteReader();
    using (reader)
    {
        while (reader.Read())
        {
            Console.WriteLine($"{reader["Name"]} - {reader["MinionsCount"]}");
        }
    }
}


string connectionString = @"Server=.;Trusted_Connection=True;TrustServerCertificate=True;";

SqlConnection connection = new SqlConnection(connectionString);
connection.Open();

using (connection)
{
    UseDB(connection, "MinionsDB");

    VillianNames(connection);
}