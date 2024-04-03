namespace Practice_2
{
    public class Counter
    {
        public int Count { get; set; }

        public void Increase()
        {
            Count += 1;
        }
        public void Reduce()
        {
            Count -= 1;
        }

        public Counter()
        {
            Count = 0;
        }
        public Counter(int num)
        {
            Count = num;
        }
    }
}