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

string connectionString = @"Server=.;Trusted_Connection=True;TrustServerCertificate=True;";

SqlConnection connection = new SqlConnection(connectionString);
connection.Open();

using (connection)
{
    UseDB(connection, "MinionsDB");

    
}