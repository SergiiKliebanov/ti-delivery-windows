using Domain;
using System;
using System.Collections.Generic;

namespace Infrastructure
{
    public static class Seed
    {
        public static IEnumerable<DeliveryWindow> GetDeliveryWindows()
        {
            var start = new DateTime(2020, 01, 01);
            var validityPeriod = new Period { Start = start, Finish = start.AddMonths(24) };

            return new[]
            {
                new DeliveryWindow
                {
                    Id = 1,
                    Name = "Срочная доставка",
                    Description = "Доставка за 1-2 часа",
                    Type = DeliveryWindowType.Urgent,
                    Price = 99,
                    WeekDays = WeekDay.AllDays,
                    ValidityPeriod = validityPeriod
                },
                new DeliveryWindow
                {
                    Id = 2,
                    Name = "10:00 - 12:00",
                    Description = "Доставка 10:00 - 12:00",
                    Start = TimeSpan.FromHours(10),
                    Finish = TimeSpan.FromHours(12),
                    Type = DeliveryWindowType.Regular,
                    Price = 59,
                    WeekDays = WeekDay.WorkDays,
                    // до 20:00 предыдущего дня
                    AvailabilityOffset = TimeSpan.FromHours(14),
                    ValidityPeriod = validityPeriod
                },
                new DeliveryWindow
                {
                    Id = 3,
                    Name = "12:00 - 18:00",
                    Description = "Доставка 12:00 - 18:00",
                    Start = TimeSpan.FromHours(12),
                    Finish = TimeSpan.FromHours(18),
                    Type = DeliveryWindowType.Regular,
                    Price = 49,
                    WeekDays = WeekDay.WorkDays,
                    // до 14:00 текущего дня
                    AvailabilityOffset = TimeSpan.FromHours(-2),
                    ValidityPeriod = validityPeriod
                },
                new DeliveryWindow
                {
                    Id = 4,
                    Name = "14:00 - 18:00",
                    Description = "Доставка 14:00 - 18:00",
                    Start = TimeSpan.FromHours(14),
                    Finish = TimeSpan.FromHours(18),
                    Type = DeliveryWindowType.Regular,
                    Price = 59,
                    WeekDays = WeekDay.Saturday,
                    // до 20:00 предыдущего дня
                    AvailabilityOffset = TimeSpan.FromHours(18),
                    ValidityPeriod = validityPeriod
                },
                new DeliveryWindow
                {
                    Id = 5,
                    Name = "18:00 - 23:00",
                    Description = "Доставка 18:00 - 23:00",
                    Start = TimeSpan.FromHours(18),
                    Finish = TimeSpan.FromHours(23),
                    Type = DeliveryWindowType.Regular,
                    Price = 59,
                    WeekDays = WeekDay.Saturday,
                    // до 14:00 текущего дня
                    AvailabilityOffset = TimeSpan.FromHours(4),
                    ValidityPeriod = validityPeriod
                },
                new DeliveryWindow
                {
                    Id = 6,
                    Name = "10:00 - 18:00",
                    Description = "Доставка 10:00 - 18:00",
                    Start = TimeSpan.FromHours(10),
                    Finish = TimeSpan.FromHours(18),
                    Type = DeliveryWindowType.Regular,
                    Price = 59,
                    WeekDays = WeekDay.Sunday,
                    // до 20:00 предыдущего дня
                    AvailabilityOffset = TimeSpan.FromHours(14),
                    ValidityPeriod = validityPeriod
                }
            };
        }
    }
}
