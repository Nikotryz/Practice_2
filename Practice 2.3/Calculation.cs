namespace Practice_2._3
{
    public class Calculation
    {
        private string CalculationLine { get; set; }

        public void SetCalculationLine(string value)
        {
            CalculationLine = value;
        }
        public void SetLastSymbolCalculationLine(char symbol)
        {
            CalculationLine += symbol;
        }
        public string GetCalculationLine()
        {
            return CalculationLine;
        }
        public char GetLastSymbol()
        {
            return CalculationLine[CalculationLine.Length-1];
        }
        public void DeleteLastSymbol()
        {
            CalculationLine = CalculationLine.Remove(CalculationLine.Length-1);
        }

        public Calculation(string value)
        {
            CalculationLine = value;
        }
    }
}