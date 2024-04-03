using System;

namespace Practice_2._4
{
    internal class Program
    {
        public static void Main()
        {
			Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("ВВЕДИТЕ РИМСКОЕ ЧИСЛО (используйте символы I, V, X, L, C, D, M)\n\nВВОД: ");
            string rimNumber = Console.ReadLine();
            
            Console.WriteLine($"\nРЕЗУЛЬТАТ: {Convert(rimNumber)}");
        }

        public static int Convert(string rimNumber)
        {
            rimNumber += " ";
            
            int result = 0;
            
            for (int i = 0; i < rimNumber.Length; i++)
            {
                //Все варианты вычитания
                if (rimNumber[i] == 'I' && rimNumber[i+1] == 'V')
                {
                    result += 4;
                    continue;
                }
                if (rimNumber[i] == 'I' && rimNumber[i+1] == 'X')
                {
                    result += 9;
                    continue;
                }
                if (rimNumber[i] == 'X' && rimNumber[i+1] == 'L')
                {
                    result += 40;
                    continue;
                }
                if (rimNumber[i] == 'X' && rimNumber[i+1] == 'C')
                {
                    result += 90;
                    continue;
                }
                if (rimNumber[i] == 'C' && rimNumber[i+1] == 'D')
                {
                    result += 400;
                    continue;
                }
                if (rimNumber[i] == 'C' && rimNumber[i+1] == 'M')
                {
                    result += 900;
                    continue;
                }
                
                //Все варианты сложения
                if (rimNumber[i] == 'I') result += 1;
                if (rimNumber[i] == 'V' && (i == 0 || rimNumber[i-1] != 'I')) result += 5;
                if (rimNumber[i] == 'X' && (i == 0 || rimNumber[i-1] != 'I')) result += 10;
                if (rimNumber[i] == 'L' && (i == 0 || rimNumber[i-1] != 'X')) result += 50;
                if (rimNumber[i] == 'C' && (i == 0 || rimNumber[i-1] != 'X')) result += 100;
                if (rimNumber[i] == 'D' && (i == 0 || rimNumber[i-1] != 'C')) result += 500;
                if (rimNumber[i] == 'M' && (i == 0 || rimNumber[i-1] != 'C')) result += 1000;
            }

            return result;
        }
    }
}