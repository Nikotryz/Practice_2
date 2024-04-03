using System;

namespace Practice_2
{
    public class NumbersOperations
    {
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }
        
        public void ShowInfo()
        {
            Console.WriteLine($"{FirstNumber}, {SecondNumber}");
        }
        public void ChangeNumbers(int a, int b)
        {
            FirstNumber = a;
            SecondNumber = b;
        }
        public int Sum()
        {
            return FirstNumber + SecondNumber;
        }
        public int Max()
        {
            if (FirstNumber > SecondNumber) return FirstNumber;
            return SecondNumber;
        }

        public NumbersOperations(int a, int b)
        {
            FirstNumber = a;
            SecondNumber = b;
        }
    }
}