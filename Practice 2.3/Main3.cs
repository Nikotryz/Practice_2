using System;

namespace Practice_2._3
{
    internal class Program
    {
        public static void Main()
        {
            Console.Write("Введите номер задания: ");
            int task = int.Parse(Console.ReadLine());

            switch (task)
            {
                case 1: FirstandSecondTask(); break;
                case 2: FirstandSecondTask(); break;
                case 3: ThirdTask(); break;
            }
        }
        
        //Задание 1 и 2
        public static void FirstandSecondTask()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen ; 
            Console.WriteLine("\nЗАДАНИЕ 1 и 2");
            Console.ResetColor();
            
            Worker worker = new Worker("Иван", "Петров", 1350, 23);

            Console.WriteLine($"Имя: {worker.GetName()}");
            Console.WriteLine($"Фамилия: {worker.GetSurname()}");
            Console.WriteLine($"Ставка: {worker.GetRate()}");
            Console.WriteLine($"Отработанные дни: {worker.GetDays()}");
            
            Console.WriteLine($"Зарплата: {worker.GetSalary()}");
        }
        
        //Задание 3
        public static void ThirdTask()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen ; 
            Console.WriteLine("\nЗАДАНИЕ 3");
            Console.ResetColor();
            
            Calculation calc = new Calculation("Тестовая строка");
            
            calc.SetCalculationLine("Проверочная строка");
            Console.WriteLine($"Установка значения: {calc.GetCalculationLine()}");
            
            calc.SetLastSymbolCalculationLine('!');
            Console.WriteLine($"Прибавление последнего символа: {calc.GetCalculationLine()}");
            
            Console.WriteLine($"Получение последнего символа: {calc.GetLastSymbol()}");
            
            calc.DeleteLastSymbol();
            Console.WriteLine($"Удаление последнего символа: {calc.GetCalculationLine()}");
        }
    }
}