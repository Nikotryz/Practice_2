using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice_2._1
{
    internal class Main1
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
            }
        }

        //Задание 1
        public static void FirstTask()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\nЗАДАНИЕ 1");
            Console.ResetColor();
            
            Console.Write("Введите драгоценности: ");
            string J = Console.ReadLine();
            
            Console.Write("Введите камни: ");
            string S = Console.ReadLine();
            
            int count = 0;
            for (int i = 0; i < S.Length; i++) 
            {
                for (int j = 0; j < J.Length; j++)
                {
                    if (S[i] == J[j])
                    {
                        count += 1;
                        break;
                    }
                }
            }
            
            Console.WriteLine($"Камней, являющимися драгоценностями: {count}");
        }
        
        //Задание 2
        public static void SecondTask()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\nЗАДАНИЕ 2");
            Console.ResetColor();
            
            Console.Write("Сколько чисел будет в массиве: ");
            int N = int.Parse(Console.ReadLine());
            int[] candidates = new int[N];
            for (int i = 0; i < N; i++) candidates[i] = int.Parse(Console.ReadLine());
        
            Console.Write("Введите target: ");
            int target = int.Parse(Console.ReadLine());
        
            Array.Sort(candidates);
            List<List<int>> result = new List<List<int>>();
            FindCombinations(candidates, target, 0, new List<int>(), result);
            
            Console.WriteLine("\nВсе комбинации:");
            foreach (var combination in result)
            {
                Console.WriteLine($"[{string.Join("+", combination.ToArray().Select(i => i.ToString()).ToArray())}] = {target}");
            }
        }
        
        //Рекурсивная функция 2-го задания
        public static void FindCombinations(int[] candidates, int target, int index, List<int> current, List<List<int>> result) 
        {
            if (target == 0) 
            {
                result.Add(new List<int>(current));
                return;
            }

            for (int i = index; i < candidates.Length; i++) 
            {
                if (candidates[i] > target) break;

                if (i > index && candidates[i] == candidates[i - 1]) continue;
      
                current.Add(candidates[i]);
                FindCombinations(candidates, target - candidates[i], i + 1, current, result);
                current.RemoveAt(current.Count - 1);
            }
        }
        
        //Задание 3
        public static void ThirdTask()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\nЗАДАНИЕ 3");
            Console.ResetColor();
            
            Console.Write("Сколько чисел будет в массиве: ");
            int N = int.Parse(Console.ReadLine());
            int[] nums = new int[N];
            for (int i = 0; i < N; i++) nums[i] = int.Parse(Console.ReadLine());

            bool flag = false;

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (nums[i] == nums[j] && i != j) flag = true;
                }
            }
            
            Console.WriteLine($"Результат: {flag}");
        }
    }
}