using System;
using System.Linq;

namespace Practice_2
{
    public class Student
    {
        public string LastName { get; set; }
        public DateTime BirthDay { get; set; }
        public int GroupNumber { get; set; }
        public int[] Grade { get; set; }

        public void ChangeLastName(string lastname)
        {
            LastName = lastname;
        }
        public void ChangeBirthDay(DateTime birthday)
        {
            BirthDay = birthday;
        }
        public void ChangeGroupNumber(int groupnumber)
        {
            GroupNumber = groupnumber;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Фамилия: {LastName}");
            Console.WriteLine($"Дата рождения: {BirthDay.ToShortDateString()}");
            Console.WriteLine($"Номер группы: {GroupNumber}");
            Console.WriteLine($"Успеваемость: [{string.Join(" ", Grade.ToArray().Select(i => i.ToString()).ToArray())}]");
        }
        public Student(string lastname, DateTime birthday, int groupnumber, int[] grade)
        {
            LastName = lastname;
            BirthDay = birthday;
            GroupNumber = groupnumber;
            Grade = grade;
        }
    }
}