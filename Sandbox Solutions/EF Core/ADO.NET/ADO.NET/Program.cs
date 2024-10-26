using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic;
using System.ComponentModel;
using System.Data;

async Task CreateDBAsync(SqlConnection connection, string name)
{
    SqlCommand cmd = new SqlCommand($"CREATE DATABASE {name}", connection);

    await cmd.ExecuteNonQueryAsync();
}
async Task UseDBAsync(SqlConnection connection, string name)
{
    SqlCommand cmd = new SqlCommand($"USE {name}", connection);

    await cmd.ExecuteNonQueryAsync();
}
async Task InsertCountriesAsync(SqlConnection connection, string name)
{
    SqlCommand cmd = new SqlCommand("INSERT INTO Countries ([Name]) VALUES (@name)", connection);
    cmd.Parameters.AddWithValue("@name", name);

    await cmd.ExecuteNonQueryAsync();
}
async Task InsertTownsAsync(SqlConnection connection, string name, int? countryCode)
{
    SqlCommand cmd;
    if (countryCode == null)
    {
        cmd = new SqlCommand("INSERT INTO Towns ([Name]) VALUES (@name)", connection);
    }
    else
    {
        cmd = new SqlCommand("INSERT INTO Towns ([Name], CountryCode) VALUES (@name, @countryCode)", connection);
        cmd.Parameters.AddWithValue("@countryCode", countryCode);
    }
    cmd.Parameters.AddWithValue("@name", name);

    await cmd.ExecuteNonQueryAsync();
}
async Task VillianNamesAsync(SqlConnection connection)
{
    SqlCommand cmd = new SqlCommand(@"
        SELECT v.[Name], COUNT(mv.VillainId) AS MinionsCount 
        FROM Villains AS v 
        JOIN MinionsVillains AS mv ON v.Id = mv.VillainId 
        GROUP BY v.Id, v.[Name] 
        HAVING COUNT(mv.VillainId) > 3 
        ORDER BY COUNT(mv.VillainId);", connection);

    SqlDataReader reader = await cmd.ExecuteReaderAsync();
    using (reader)
    {
        while (reader.Read())
        {
            Console.WriteLine($"{reader["Name"]} - {reader["MinionsCount"]}");
        }
    }
}
void MinionNamesAsync(SqlConnection connection, int id)
{
    SqlCommand cmdValidation = new SqlCommand("SELECT [Name] FROM Villains WHERE Id = @Id", connection);
    cmdValidation.Parameters.AddWithValue("@Id", id);

    SqlDataReader sqlDataReader = cmdValidation.ExecuteReader();

    string name = null;
    if (sqlDataReader.Read())
    {
        name = sqlDataReader.GetString(0);
    }
    sqlDataReader.Close();

    if (string.IsNullOrEmpty(name))
    {
        Console.WriteLine($"No villain with ID {id} exists in the database.");
    }
    else
    {
        SqlCommand cmd = new SqlCommand(@"
            SELECT ROW_NUMBER() OVER (ORDER BY m.Name) AS RowNum,
                                         m.Name, 
                                         m.Age
                                    FROM MinionsVillains AS mv
                                    JOIN Minions As m ON mv.MinionId = m.Id
                                   WHERE mv.VillainId = @Id
                                ORDER BY m.Name 
        ", connection);
        cmd.Parameters.AddWithValue("@Id", id);

        sqlDataReader = cmd.ExecuteReader();
        using (sqlDataReader)
        {
            Console.WriteLine($"Villian: {name}");
            while (sqlDataReader.Read())
            {
                Console.WriteLine($"{sqlDataReader["RowNum"]}. {sqlDataReader["Name"]} {sqlDataReader["Age"]}");
            }
        }
    }
}
async Task AddMinionAsync(SqlConnection connection)
{
    string[] input = Console.ReadLine().Split();
    string minionName = input[1];
    int age = int.Parse(input[2]);
    string townName = input[3];

    string villainName = Console.ReadLine().Substring(9);

    int townId = await EnsureTownExistsAsync(connection, townName);
    int villainId = await EnsureVillainExistsAsync(connection, villainName);

    await InsertMinionAsync(connection, minionName, age, townId);
    int minionId = (await GetMinionIdAsync(connection, minionName)).Value;

    await InsertMinionsVillainsAsync(connection, minionId, villainId);
    Console.WriteLine($"Successfully added {minionName} to be minion of {villainName}");
}
async Task ChangeTownNamesCasingAsync(SqlConnection connection)
{
    string countryName = Console.ReadLine()!;

    SqlCommand cmd = new SqlCommand(@"
        UPDATE Towns
        SET [Name] = UPPER(Name)
        WHERE CountryCode = (SELECT c.Id FROM Countries AS c WHERE c.[Name] = @countryName)",
        connection);
    cmd.Parameters.AddWithValue("@countryName", countryName);

    await cmd.ExecuteNonQueryAsync();

    SqlCommand cmd2 = new SqlCommand(@"
        SELECT [Name] FROM Towns
        WHERE CountryCode = (SELECT c.Id FROM Countries AS c WHERE c.[Name] = @countryName)",
        connection);
    cmd2.Parameters.AddWithValue("@countryName", countryName);

    List<string> names = new List<string>();

    SqlDataReader reader = await cmd2.ExecuteReaderAsync();
    using (reader)
    {
        while (await reader.ReadAsync())
        {
            names.Add(reader.GetString(0));
        }
    }
    if (names.Count == 0)
    {
        Console.WriteLine("No town names were affected.");
    }
    else
    {
        Console.WriteLine($"{names.Count} town names were affected");
        Console.WriteLine($"{string.Join(", ", names)}");
    }
}
async Task PrintAllMinionNamesAsync(SqlConnection connection)
{
    List<string> names = new List<string>();

    SqlCommand cmd = new SqlCommand(@"
        SELECT [Name] FROM Minions
        ", connection);

    SqlDataReader reader = await cmd.ExecuteReaderAsync();
    using (reader)
    {
        while (await reader.ReadAsync())
        {
            names.Add(reader.GetString(0));
        }
    }

    int start = 0;
    int end = names.Count - 1;

    while (start <= end)
    {
        if (start == end)
        {
            Console.WriteLine(names[start]);
        }
        else
        {
            Console.WriteLine(names[start]);
            Console.WriteLine(names[end]);
        }

        start++;
        end--;
    }

}
async Task IncreaseMinionAgeAsync(SqlConnection connection)
{
    List<int> indexes = Console.ReadLine()
        .Split()
        .Select(int.Parse)
        .ToList();

    SqlCommand cmd = new SqlCommand(@"
        UPDATE Minions
        SET [Name] = LOWER(LEFT(Name, 1)) + SUBSTRING(Name, 2, LEN(Name)), Age += 1
        WHERE Id = @id", connection);

    cmd.Parameters.Add("@id", SqlDbType.Int);

    foreach (int index in indexes)
    {
        cmd.Parameters["@id"].Value = index;
        await cmd.ExecuteNonQueryAsync();
    }

    cmd = new SqlCommand("SELECT [Name], Age FROM Minions", connection);

    SqlDataReader reader = await cmd.ExecuteReaderAsync();
    using (reader)
    {
        while (await reader.ReadAsync())
        {
            Console.WriteLine($"{reader["Name"]} {reader["Age"]}");
        }
    }
}

// Additional
async Task<int> EnsureTownExistsAsync(SqlConnection connection, string townName)
{
    int? townId = await GetTownIdAsync(connection, townName);
    if (townId == null)
    {
        await InsertTownsAsync(connection, townName, null);
        Console.WriteLine($"Town {townName} was added to the database.");
        townId = await GetTownIdAsync(connection, townName);
    }
    return townId.Value;
}
async Task<int> EnsureVillainExistsAsync(SqlConnection connection, string villainName)
{
    int? villainId = await GetVillainIdAsync(connection, villainName);
    if (villainId == null)
    {
        await InsertVillainAsync(connection, villainName);
        Console.WriteLine($"Villain {villainName} was added to the database.");
        villainId = await GetVillainIdAsync(connection, villainName);
    }
    return villainId.Value;
}
async Task InsertVillainAsync(SqlConnection connection, string villainName)
{
    using SqlCommand cmd = new SqlCommand("INSERT INTO Villains ([Name], EvilnessFactorId) VALUES (@villainName, 4)", connection);
    cmd.Parameters.AddWithValue("@villainName", villainName);
    await cmd.ExecuteNonQueryAsync();
}
async Task<int?> GetTownIdAsync(SqlConnection connection, string name)
{
    SqlCommand cmd = new SqlCommand("SELECT [id] FROM Towns WHERE [Name] = @name", connection);
    cmd.Parameters.AddWithValue("@name", name);

    return (int?)await cmd.ExecuteScalarAsync();
}
async Task<int?> GetVillainIdAsync(SqlConnection connection, string villainName)
{
    SqlCommand cmd = new SqlCommand("SELECT Id FROM Villains WHERE [Name] = @villainName", connection);
    cmd.Parameters.AddWithValue("@villainName", villainName);

    return (int?)await cmd.ExecuteScalarAsync();
}
async Task<int?> GetMinionIdAsync(SqlConnection connection, string name)
{
    SqlCommand cmd = new SqlCommand("SELECT Id FROM Minions WHERE [Name] = @name", connection);
    cmd.Parameters.AddWithValue("@name", name);

    return (int?)await cmd.ExecuteScalarAsync();
}
async Task InsertMinionAsync(SqlConnection connection, string name, int age, int townId)
{
    SqlCommand cmd = new SqlCommand("INSERT INTO Minions ([Name], Age, TownId) VALUES (@name, @age, @townId)", connection);
    cmd.Parameters.AddWithValue($"@name", name);
    cmd.Parameters.AddWithValue($"@age", age);
    cmd.Parameters.AddWithValue($"@townId", townId);

    await cmd.ExecuteNonQueryAsync();
}
async Task InsertMinionsVillainsAsync(SqlConnection connection, int minionId, int villainId)
{
    SqlCommand cmd = new SqlCommand("INSERT INTO MinionsVillains (MinionId, VillainId) VALUES (@minionId, @villainId)", connection);
    cmd.Parameters.AddWithValue("@minionId", minionId);
    cmd.Parameters.AddWithValue("@villainId", villainId);

    await cmd.ExecuteNonQueryAsync();
}


async Task MainAsync()
{
    string connectionString = @"Server=.;Database=MinionsDB;Trusted_Connection=True;TrustServerCertificate=True;";

    SqlConnection connection = new SqlConnection(connectionString);
    await connection.OpenAsync();

    using (connection)
    {
        await IncreaseMinionAgeAsync(connection);
    }
}

await MainAsync();