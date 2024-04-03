using Npgsql;

namespace Practice_2._5;

public static class DatabaseService
{
    private static NpgsqlConnection? _connection;
    private static string GetConnectionString()
    {
        //Тут вводим данные от своей БД
        return @"Host=localhost;Port=5432;Database=postgres;Username=postgres;Password=900440";
    }
    public static NpgsqlConnection GetSqlConnection()
    {
        if (_connection is null)
        {
            _connection = new NpgsqlConnection(GetConnectionString());
            _connection.Open();
        }
        
        return _connection;
    }
}