using System;

namespace Practice_2
{
    public class Train
    {
        public string DestinationPoint { get; set; }
        public int TrainNumber { get; set; }
        public string  DepartureTime { get; set; }

        public void ShowInfo()
        {
            Console.WriteLine($"Пункт назначения: {DestinationPoint}");
            Console.WriteLine($"Номер поезда: {TrainNumber}");
            Console.WriteLine($"Время отправления: {DepartureTime}");
        }

        public Train(string destinationPoint, int trainNumber, string departureTime)
        {
            DestinationPoint = destinationPoint;
            TrainNumber = trainNumber;
            DepartureTime = departureTime;
        }
    }
}