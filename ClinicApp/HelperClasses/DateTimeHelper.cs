using System;

namespace ClinicApp.HelperClasses
{
    public static class DateTimeHelper
    {
        public static bool IsGreaterThanNow(this DateTime? dateTime)
        {
            return dateTime > DateTime.UtcNow;
        }

        public static string GetAgeFromDate(this DateTime dateOfBirthday)
        {
            DateTime today = DateTime.Today;

            int months = today.Month - dateOfBirthday.Month;
            int years = today.Year - dateOfBirthday.Year;

            if (today.Day < dateOfBirthday.Day)
            {
                months--;
            }

            if (months < 0)
            {
                years--;
                months += 12;
            }

            int days = (today - dateOfBirthday.AddMonths((years * 12) + months)).Days;

            return string.Format("{0} {1}, {2} {3} и {4} {5}",
                years, (years == 1) ? "год" : "лет",
                months, (months == 1) ? "месяц" : "месяцев",
                days, (days == 1) ? "день" : "дней");
        }
    }
}
