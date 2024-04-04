namespace DailyPlanner;

public static class Command
{
    //Функция добавления новой задачи
    public static void AddTask()
    {
        try
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("ВВЕДИТЕ НАЗВАНИЕ ЗАДАЧИ: ");
            string name = Console.ReadLine();
            Console.Write("ВВЕДИТЕ ОПИСАНИЕ ЗАДАЧИ (можете оставить поле пустым): ");
            string description = Console.ReadLine();
            Console.Write("ВВЕДИТЕ ДЕДЛАЙН ЗАДАЧИ (YYYY.MM.DD): ");
            string deadline = Console.ReadLine();
            
            DatabaseRequests.AddTaskQuery(name, description, DateTime.Parse(deadline));
            
            Console.WriteLine("\nЗАДАЧА УСПЕШНО ДОБАВЛЕНА");
        }
        catch (FormatException)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("ОШИБКА. НЕПРАВИЛЬНЫЙ ФОРМАТ ВВОДА");
        }
    }
    
    //Функция удаления задачи
    public static void DeleteTask()
    {
        try
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("ВВЕДИТЕ ID ЗАДАЧИ: ");
            int id = int.Parse(Console.ReadLine());
            
            DatabaseRequests.DeleteTaskQuery(id);
            
            Console.WriteLine("\nЗАДАЧА УСПЕШНО УДАЛЕНА");
        }
        catch (FormatException)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("ОШИБКА. НЕПРАВИЛЬНЫЙ ФОРМАТ ВВОДА");
        }
    }
    
    //Функция изменения задачи
    public static void EditTask()
    {
        try
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("ВВЕДИТЕ ID ЗАДАЧИ: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("ВЫБЕРИТЕ ДЕЙСТВИЕ:\n[1] — Изменить название задачи\n[2] — Изменить описание задачи\n[3] — Изменить дедлайн задачи\n\nВВЕДИТЕ ДЕЙСТВИЕ: ");
            int action = int.Parse(Console.ReadLine());

            switch (action)
            {
                case 1:
                    Console.Write("ВВЕДИТЕ НОВОЕ НАЗВАНИЕ: ");
                    string name = Console.ReadLine();
                    DatabaseRequests.EditTaskNameQuery(id, name);
                    Console.WriteLine("\nНАЗВАНИЕ ОБНОВЛЕНО");
                    break;
                case 2:
                    Console.Write("ВВЕДИТЕ НОВОЕ ОПИСАНИЕ: ");
                    string description = Console.ReadLine();
                    DatabaseRequests.EditTaskDescriptionQuery(id, description);
                    Console.WriteLine("\nОПИСАНИЕ ОБНОВЛЕНО");
                    break;
                case 3:
                    Console.Write("ВВЕДИТЕ НОВЫЙ ДЕДЛАЙН (YYYY.MM.DD): ");
                    DateTime deadline = DateTime.Parse(Console.ReadLine());
                    DatabaseRequests.EditTaskDeadlineQuery(id, deadline);
                    Console.WriteLine("\nДЕДЛАЙН ОБНОВЛЕН");
                    break;
            }
        }
        catch (FormatException)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("ОШИБКА. НЕПРАВИЛЬНЫЙ ФОРМАТ ВВОДА");
        }
    }

    //Функция просмотра всех задач
    public static void GetAllTasks()
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("СПИСОК ВСЕХ ЗАДАЧ:");
        DatabaseRequests.GetAllTasksQuery();
    }
    
    //Функция просмотра прошедших задач
    public static void GetPastTasks()
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("СПИСОК ПРОШЕДШИХ ЗАДАЧ:");
        DatabaseRequests.GetPastTasksQuery();
    }
    
    //Функция просмотра предстоящих задач
    public static void GetUpcomingTasks()
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("СПИСОК ПРЕДСТОЯЩИХ ЗАДАЧ:");
        DatabaseRequests.GetUpcomingTasksQuery();
    }
    
    //Функция просмотра задач на сегодня
    public static void GetTodayTasks()
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("СПИСОК ЗАДАЧ НА СЕГОДНЯ:");
        DatabaseRequests.GetTodayTasksQuery();
    }
    
    //Функция просмотра задач на завтра
    public static void GetTomorrowTasks()
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("СПИСОК ЗАДАЧ НА ЗАВТРА:");
        DatabaseRequests.GetTomorrowTasksQuery();
    }
    
    //Функция просмотра задач на неделю
    public static void GetWeekTasks()
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("СПИСОК ЗАДАЧ НА НЕДЕЛЮ:");
        DatabaseRequests.GetWeekTasksQuery();
    }
}