using System;

namespace Practice_2
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public Person()
        {
            Name = "Иван";
            Age = 20;
        }
        
        ~Person()
        {
            Console.WriteLine($"{Name} был удалён");
        }
    }
}