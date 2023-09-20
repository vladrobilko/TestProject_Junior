using System;

namespace ClinicApp.HelperClasses
{
    public static class DateTimeHelper
    {
        public static bool IsGreaterThanNow(this DateTime? dateTime)
        {
            return dateTime > DateTime.UtcNow;
        }
    }
}
