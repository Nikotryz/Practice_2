using System;
using System.Collections.Generic;

namespace Practice_2
{
    internal class Main2
    {
        public static void Main()
        {
            Console.Write("Введите номер задания: ");
            int task = int.Parse(Console.ReadLine());

            switch (task)
            {
                case 1: FirstTask(); break;
                case 2: SecondTask(); break;
                case 3: ThirdTask(); break;
                case 4: FourthTask(); break;
                case 5: FifthTask(); break;
            }
        }

        //Задание 1
        public static void FirstTask()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen ; 
            Console.WriteLine("\nЗАДАНИЕ 1");
            Console.ResetColor();

            List<Student> students = new List<Student>();
            
            int[] grade1 = { 5, 2, 4, 4, 3 };
            int[] grade2 = { 5, 5, 5, 4, 5 };
            int[] grade3 = { 4, 5, 4, 4, 3 };
            
            Student student1 = new Student("Иванов", DateTime.Parse("2003-04-15"), 933, grade1); students.Add(student1);
            Student student2 = new Student("Петров", DateTime.Parse("2003-05-23"), 624, grade2); students.Add(student2);
            Student student3 = new Student("Сидоров", DateTime.Parse("2003-02-07"), 622, grade3); students.Add(student3);
            
            student1.ChangeLastName("Харламов");
            student1.ChangeBirthDay(DateTime.Parse("2006-09-05"));
            student1.ChangeGroupNumber(624);
            
            Console.Write("Введите фамилию: ");
            string lastname = Console.ReadLine();
            
            Console.Write("Введите дату рождения (YYYY-MM-DD): ");
            DateTime birthday = DateTime.Parse(Console.ReadLine());
            
            Console.WriteLine();
            foreach (Student student in students)
            {
                if (student.LastName == lastname && student.BirthDay == birthday) student.ShowInfo();
            }
        }

        //Задание 2
        public static void SecondTask()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen ; 
            Console.WriteLine("\nЗАДАНИЕ 2");
            Console.ResetColor();

            List<Train> trains = new List<Train>();

            Train train1 = new Train("Москва", 1, "7:25"); trains.Add(train1);
            Train train2 = new Train("Владивосток", 2, "12:45"); trains.Add(train2);
            Train train3 = new Train("Уфа", 3, "16:05"); trains.Add(train3);
            
            Console.Write("Введите номер поезда: ");
            int trainnumber = int.Parse(Console.ReadLine());
            
            Console.WriteLine();
            foreach (Train train in trains)
            {
                if (trainnumber == train.TrainNumber) train.ShowInfo();
            }
        }

        //Задание 3
        public static void ThirdTask()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen ; 
            Console.WriteLine("\nЗАДАНИЕ 3");
            Console.ResetColor();

            NumbersOperations numbers = new NumbersOperations(4, 8);
            
            Console.Write("Числа: "); numbers.ShowInfo();
            
            Console.WriteLine("Введите новые числа:");
            numbers.ChangeNumbers(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));

            Console.Write("Сумма чисел: "); Console.WriteLine(numbers.Sum());

            Console.Write("Наибольшее число: "); Console.WriteLine(numbers.Max());
        }
        
        //Задание 4
        public static void FourthTask()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen ; 
            Console.WriteLine("\nЗАДАНИЕ 4");
            Console.ResetColor();
            
            Counter count = new Counter();
            
            Console.Write("Введите значение счётчика или отправьте пустую строку для значения по умолчанию: ");
            try
            {
                count.Count = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                count.Count = 0;
            }

            bool action = true;
            while (action == true)
            {
                Console.Write("Текущее состояние счётчика: "); Console.WriteLine(count.Count);
                Console.Write("Увеличить, уменьшить или остановиться? (+, -, stop) ");
                switch (Console.ReadLine())
                {
                    case "+": count.Increase(); break;
                    case "-": count.Reduce(); break;
                    case "stop": action = false; break;
                }
            }
            
            Console.Write("Текущее состояние счётчика: "); Console.WriteLine(count.Count);
        }
        
        //Задание 5
        public static void FifthTask()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen ; 
            Console.WriteLine("\nЗАДАНИЕ 5");
            Console.ResetColor();

            Person person1 = new Person();
            Person person2 = new Person("Андрей", 19);
        }
    }
}