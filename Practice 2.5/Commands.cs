using System;

namespace Practice_2._5;

public static class Commands
{
    //Функция просмотра категорий прав у водителя
    public static void ViewRights()
    {
        Console.Write("Введите ID водителя: ");
        try
        {
            int driver = int.Parse(Console.ReadLine());
            Console.WriteLine();
            DatabaseRequests.GetDriverRightsCategoryQuery(driver);
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка. Неправильный формат ввода");
        }
    }
    
    //Функция добавления нового типа автомобиля
    public static void AddCarType()
    {
        Console.Write("Введите название нового типа автомобиля: ");
        DatabaseRequests.AddTypeCarQuery(Console.ReadLine());
    }

    //Функция добавления нового водителя
    public static void AddDriver()
    {
        Console.Write("Введите имя: ");
        string name = Console.ReadLine();
        Console.Write("Введите фамилию: ");
        string surname = Console.ReadLine();
        Console.Write("Введите дату рождения (YYYY.MM.DD): ");
        string birthday = Console.ReadLine();
        try
        {
            DatabaseRequests.AddDriverQuery(name, surname, DateTime.Parse(birthday));
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка. Неправильный формат ввода");
        }
    }
    
    //Функция добавления категории прав водителю
    public static void AddDriverRights()
    {
        try
        {
            Console.Write("Введите ID водителя: ");
            int driver = int.Parse(Console.ReadLine());
            Console.Write("Введите ID категории: ");
            int rights = int.Parse(Console.ReadLine());
            DatabaseRequests.AddDriverRightsCategoryQuery(driver, rights);
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка. Неправильный формат ввода");
        }
    }

    //Функция добавления новой категории прав
    public static void AddRights()
    {
        Console.Write("Введите название категории: ");
        string name = Console.ReadLine();
        DatabaseRequests.AddRightsCategoryQuery(name);
    }

    //Функция добавления автомобиля
    public static void AddCar()
    {
        try
        {
            Console.Write("Введите ID типа автомобиля: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Введите название автомобиля: ");
            string name = Console.ReadLine();
            Console.Write("Введите номера автомобиля: ");
            string state = Console.ReadLine();
            Console.Write("Введите число вместимости пассажиров: ");
            int number = int.Parse(Console.ReadLine());
            
            DatabaseRequests.AddCarsQuery(id, name, state, number);    
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка. Неправильный формат ввода");
        }
    }

    //Функция добавления маршрута
    public static void AddItinerary()
    {
        Console.Write("Введите название маршрута: ");
        string name = Console.ReadLine();
        DatabaseRequests.AddItineraryQuery(name);
    }

    //Функция добавления рейса
    public static void AddRoute()
    {
        try
        {
            Console.Write("Введите ID водителя: ");
            int driver = int.Parse(Console.ReadLine());
            Console.Write("Введите ID автомобиля: ");
            int car = int.Parse(Console.ReadLine());
            Console.Write("Введите ID маршрута: ");
            int itinerary = int.Parse(Console.ReadLine());
            Console.Write("Введите число пассажиров: ");
            int number = int.Parse(Console.ReadLine());
            
            DatabaseRequests.AddRouteQuery(driver, car, itinerary, number);    
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка. Неправильный формат ввода");
        }
    }
}