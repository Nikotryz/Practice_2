using System;
using Npgsql;

namespace DailyPlanner;

public static class DatabaseRequests
{
    //Метод добавления новой задачи в БД
    public static void AddTaskQuery(string name, string description, DateTime deadline)
    {
        var querySql = $"INSERT INTO task(name, description, deadline) VALUES ('{name}', '{description}', '{deadline}')";
        using var cmd = new NpgsqlCommand(querySql, DatabaseService.GetSqlConnection());
        cmd.ExecuteNonQuery();
    }
    
    //Метод удаления задачи из БД
    public static void DeleteTaskQuery(int id)
    {
        var querySql = $"DELETE FROM task WHERE id = {id}";
        using var cmd = new NpgsqlCommand(querySql, DatabaseService.GetSqlConnection());
        cmd.ExecuteNonQuery();
    }
    
    //Метод изменения названия задачи в БД
    public static void EditTaskNameQuery(int id, string name)
    {
        var querySql = $"UPDATE task SET name = '{name}' WHERE id = {id}";
        using var cmd = new NpgsqlCommand(querySql, DatabaseService.GetSqlConnection());
        cmd.ExecuteNonQuery();
    }
    
    //Метод изменения описания задачи в БД
    public static void EditTaskDescriptionQuery(int id, string description)
    {
        var querySql = $"UPDATE task SET description = '{description}' WHERE id = {id}";
        using var cmd = new NpgsqlCommand(querySql, DatabaseService.GetSqlConnection());
        cmd.ExecuteNonQuery();
    }
    
    //Метод изменения дедлайна задачи в БД
    public static void EditTaskDeadlineQuery(int id, DateTime date)
    {
        var querySql = $"UPDATE task SET deadline = '{date}' WHERE id = {id}";
        using var cmd = new NpgsqlCommand(querySql, DatabaseService.GetSqlConnection());
        cmd.ExecuteNonQuery();
    }
    
    //Метод получения всех задач из БД
    public static void GetAllTasksQuery()
    {
        var querySql = "SELECT * FROM task";
        using var cmd = new NpgsqlCommand(querySql, DatabaseService.GetSqlConnection());
        using var reader = cmd.ExecuteReader();

        while (reader.Read())
        {
            Console.WriteLine($"| ID: {reader[0]} | Название: {reader[1]} | Описание: {reader[2]} | Дедлайн: {reader[3]} |");
        }
    }
    
    //Метод получения прошедших задач из БД
    public static void GetPastTasksQuery()
    {
        var querySql = $"SELECT * FROM task " +
                       $"WHERE deadline < '{DateTime.Now}'";
        using var cmd = new NpgsqlCommand(querySql, DatabaseService.GetSqlConnection());
        using var reader = cmd.ExecuteReader();

        while (reader.Read())
        {
            Console.WriteLine($"| ID: {reader[0]} | Название: {reader[1]} | Описание: {reader[2]} | Дедлайн: {reader[3]} |");
        }
    }
    
    //Метод получения предстоящих задач из БД
    public static void GetUpcomingTasksQuery()
    {
        var querySql = $"SELECT * FROM task " +
                       $"WHERE deadline > '{DateTime.Now}'";
        using var cmd = new NpgsqlCommand(querySql, DatabaseService.GetSqlConnection());
        using var reader = cmd.ExecuteReader();

        while (reader.Read())
        {
            Console.WriteLine($"| ID: {reader[0]} | Название: {reader[1]} | Описание: {reader[2]} | Дедлайн: {reader[3]} |");
        }
    }
    
    //Метод получения задач на сегодня из БД
    public static void GetTodayTasksQuery()
    {
        var querySql = $"SELECT * FROM task " +
                       $"WHERE deadline = '{DateTime.Today}'";
        using var cmd = new NpgsqlCommand(querySql, DatabaseService.GetSqlConnection());
        using var reader = cmd.ExecuteReader();

        while (reader.Read())
        {
            Console.WriteLine($"| ID: {reader[0]} | Название: {reader[1]} | Описание: {reader[2]} | Дедлайн: {reader[3]} |");
        }
    }
    
    //Метод получения задач на завтра из БД
    public static void GetTomorrowTasksQuery()
    {
        var querySql = $"SELECT * FROM task " +
                       $"WHERE deadline = '{DateTime.Today.AddDays(1)}'";
        using var cmd = new NpgsqlCommand(querySql, DatabaseService.GetSqlConnection());
        using var reader = cmd.ExecuteReader();

        while (reader.Read())
        {
            Console.WriteLine($"| ID: {reader[0]} | Название: {reader[1]} | Описание: {reader[2]} | Дедлайн: {reader[3]} |");
        }
    }
    
    //Метод получения задач на неделю из БД
    public static void GetWeekTasksQuery()
    {
        var querySql = $"SELECT * FROM task " +
                       $"WHERE deadline >= '{DateTime.Today}' and deadline <= '{DateTime.Today.AddDays(7)}'";
        using var cmd = new NpgsqlCommand(querySql, DatabaseService.GetSqlConnection());
        using var reader = cmd.ExecuteReader();

        while (reader.Read())
        {
            Console.WriteLine($"| ID: {reader[0]} | Название: {reader[1]} | Описание: {reader[2]} | Дедлайн: {reader[3]} |");
        }
    }
}