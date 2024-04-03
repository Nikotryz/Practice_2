using System;

namespace Practice_2._5;

public class App 
{
    public static void Main()
    {
        bool flag = true;
        
        while (flag == true)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nКОМАНДЫ ПРОСМОТРА:" +
                              "\n[1] — Просмотреть все типы автомобилей" +
                              "\n[2] — Просмотреть все автомобили" +
                              "\n[3] — Просмотреть всех водителей" +
                              "\n[4] — Просмотреть все категории прав" +
                              "\n[5] — Просмотреть категории прав у водителя" +
                              "\n[6] — Просмотреть все маршруты" +
                              "\n[7] — Просмотреть все рейсы" +
                              "\n\nКОМАНДЫ ДОБАВЛЕНИЯ:" +
                              "\n[8] — Добавить новый тип автомобилей" +
                              "\n[9] — Добавить новый автомобиль" +
                              "\n[10] — Добавить водителя" +
                              "\n[11] — Добавить категорию прав водителю" +
                              "\n[12] — Добавить новую категорию прав" +
                              "\n[13] — Добавить новый маршрут" +
                              "\n[14] — Добавить новый рейс" +
                              "\n\n[stop] — ЗАКРЫТЬ ПРОГРАММУ");
            Console.Write("\nВВЕДИТЕ КОМАНДУ: ");
            string action = Console.ReadLine();
            
            Console.ResetColor();
            Console.Clear();

            switch (action)
            {
                case "1": DatabaseRequests.GetTypeCarQuery(); break;
                case "2": DatabaseRequests.GetCarsQuery(); break;
                case "3": DatabaseRequests.GetDriverQuery(); break;
                case "4": DatabaseRequests.GetRightsCategoryQuery(); break;
                case "5": Commands.ViewRights(); break;
                case "6": DatabaseRequests.GetItineraryQuery(); break;
                case "7": DatabaseRequests.GetRouteQuery(); break;
                case "8": Commands.AddCarType(); break;
                case "9": Commands.AddCar(); break;
                case "10": Commands.AddDriver(); break;
                case "11": Commands.AddDriverRights(); break;
                case "12": Commands.AddRights(); break;
                case "13": Commands.AddItinerary(); break;
                case "14": Commands.AddRoute(); break;
                case "stop": flag = false; break;
            }
        }
    }
}