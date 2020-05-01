using System;

namespace Domain
{
    public class DeliveryWindow
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public DeliveryWindowType Type { get; set; }
        public WeekDay WeekDays { get; set; } = WeekDay.AllDays;
        public TimeSpan? Start { get; set; }
        public TimeSpan? Finish { get; set; }
        public TimeSpan? AvailabilityOffset { get; set; }
        public Period ValidityPeriod { get; set; }
    }

    public enum DeliveryWindowType
    {
        Regular,
        Urgent
    }

    public class Period
    {
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }
    }

    [Flags]
    public enum WeekDay
    {
        Sunday = 1,
        Monday = 2,
        Tuesday = 4,
        Wednesday = 8,
        Thursday = 16,
        Friday = 32,
        Saturday = 64,
        WorkDays = Monday | Tuesday | Wednesday | Thursday | Friday,
        WeekEnd = Sunday | Saturday,
        AllDays = WorkDays | WeekEnd
    }
}
