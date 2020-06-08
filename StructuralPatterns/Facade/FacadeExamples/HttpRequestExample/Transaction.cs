using System;

namespace HttpRequestExample
{
    public class Transaction
    {
        public Guid Id { get; set; }
        public Guid Source { get; set; }
        public Guid Destination { get; set; }
        public decimal Volume { get; set; }
        public DateTime Date { get; set; }

        public Transaction(Guid source, Guid destination, decimal volume, DateTime date)
        {
            Id = Guid.NewGuid();
            Source = source;
            Destination = destination;
            Volume = volume;
            Date = date;
        }
    }
}
