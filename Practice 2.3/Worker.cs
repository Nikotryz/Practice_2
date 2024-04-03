namespace Practice_2._3
{
    public class Worker
    {
        private string Name { get; set; }
        private string Surname { get; set; }
        private int Rate { get; set; }
        private int Days { get; set; }

        public string GetName()
        {
            return Name;
        }
        public string GetSurname()
        {
            return Surname;
        }
        public int GetRate()
        {
            return Rate;
        }
        public int GetDays()
        {
            return Days;
        }

        public int GetSalary()
        {
            return Rate * Days;
        }

        public Worker(string name, string surname, int rate, int days)
        {
            Name = name;
            Surname = surname;
            Rate = rate;
            Days = days;
        }
    }
}