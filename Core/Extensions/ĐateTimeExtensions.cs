using System;

namespace Core.Extensions
{
    public static class ĐateTimeExtensions
    {
        public static DateTime GetEndOfMonth(this DateTime date)
        {
            return new DateTime(date.Year, date.Month, DateTime.DaysInMonth(date.Year, date.Month));
        }
        public static DateTime GetNextWeekday(this DateTime date, DayOfWeek dayOfWeek)
        {
            int daysToAdd = ((int)dayOfWeek - (int)date.DayOfWeek + 7) % 7;
            return date.AddDays(daysToAdd);
        }

        public static DateTime GetLastWeekday(this DateTime date, DayOfWeek dayOfWeek)
        {
            DateTime lastDayOfMonth = date.GetEndOfMonth();
            int daysUntilLastThursday = (lastDayOfMonth.DayOfWeek - dayOfWeek + 7) % 7;
            DateTime lastThursday = lastDayOfMonth.AddDays(-daysUntilLastThursday);
            return lastThursday;
        }

        public static DateTime GetEndOfQuarter(this DateTime date)
        {
            return date.AddDays(1 - date.Day).AddMonths(3 - (date.Month - 1) % 3).AddDays(-1);
        }

        public static DateTime GetDays2ndOr16thOfMonthAfter(this DateTime date)
        {
            var d = date.AddMonths(1);
            return new DateTime(d.Year, d.Month, d.Day >= 16 ? 16 : 2);
        }

        public static DateTime GetDaysAfter15thOfMonthAfter(this DateTime date)
        {
            var d = date.AddMonths(1);
            return new DateTime(d.Year, d.Month, 15);
        }

        public static DateTime GetDayUpToOrAfter23rd(this DateTime date)
        {
            var d = date.AddMonths(date.Day <= 23 ? 1 : 2);
            return GetEndOfMonth(d);
        }

        public static DateTime CutOff15ofMonthFollowingDayofWeek(this DateTime date, DayOfWeek dayOfWeek)
        {
            var day15thInMonth = new DateTime(date.Year, date.Month, 15);
            var nextDayOfweekDay15th = GetNextWeekday(day15thInMonth, dayOfWeek);
            var returnDate = day15thInMonth.DayOfWeek == dayOfWeek ? day15thInMonth : nextDayOfweekDay15th;
            return returnDate > date ? returnDate : GetNextWeekday(day15thInMonth.AddMonths(1), dayOfWeek);
        }

        public static DateTime AddDaysOffset(this DateTime date, int offsetValue, bool acceptWeekend)
        {
            date = date.AddDays(offsetValue);
            if (!acceptWeekend && (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday))
            {
                date = date.GetNextWeekday(DayOfWeek.Monday);
            }
            return date;
        }

        public static DateTime AddDaysOffsetNotOverMonth(this DateTime date, int offsetValue)
        {
            var lastDateOfMonth = date.GetEndOfMonth();
            return date.Day + offsetValue > lastDateOfMonth.Day ? lastDateOfMonth : date.AddDays(offsetValue);
        }
    }
}
