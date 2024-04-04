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
            Console.Write("ВВЕДИТЕ ДЕДЛАЙН ЗАДАЧИ: ");
            string deadline = Console.ReadLine();
            
            DatabaseRequests.AddTaskQuery(name, description, DateTime.Parse(deadline));
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