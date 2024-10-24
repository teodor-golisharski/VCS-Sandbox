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

string connectionString = @"Server=.;Trusted_Connection=True;TrustServerCertificate=True;";

SqlConnection connection = new SqlConnection(connectionString);
connection.Open();

using (connection)
{
    //CreateDB(connection, "MinionsDB");
    //UseDB(connection, "MinionsDB");

    //InsertCountries(connection, "Bulgaria");
    //InsertCountries(connection, "England");
    //InsertCountries(connection, "Cyprus");
    //InsertCountries(connection, "Germany");
    //InsertCountries(connection, "Norway");

    SqlCommand command = new SqlCommand("SELECT * FROM Countries", connection);
    command.ExecuteNonQuery();
}