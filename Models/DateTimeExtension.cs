using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace WebMonitoring.Models
{
    public static class DateTimeExtension
    {
        private static long Timestamp => (long)DateTime.Now.Subtract(new DateTime(1970, 1, 1)).TotalMilliseconds;

        private static string zone => "Central European Standard Time";

        private static string DateConvertSql(DateTime dateTime)
        {
            string day = dateTime.Day >= 10 ? dateTime.Day.ToString() : "0" + dateTime.Day;
            string month = dateTime.Month >= 10 ? dateTime.Month.ToString() : "0" + dateTime.Month;
            string year = dateTime.Year.ToString();
            string hour = (dateTime.Hour >= 10 ? dateTime.Hour.ToString() : "0" + dateTime.Hour) + ":00:00";
            string delimiter = "-";

            return year + delimiter + month + delimiter + day + " " + hour;
        }

        private static string DateConvertSql_AllDay(DateTime dateTime)
        {
            string day = dateTime.Day >= 10 ? dateTime.Day.ToString() : "0" + dateTime.Day;
            string month = dateTime.Month >= 10 ? dateTime.Month.ToString() : "0" + dateTime.Month;
            string year = dateTime.Year.ToString();
            string hour = dateTime.Hour >= 10 ? dateTime.Hour.ToString() + ":00:00" : "0" + dateTime.Hour.ToString() + ":00:00";
            string delimiter = "-";

            return year + delimiter + month + delimiter + day + " " + hour;
        }

        public static long ConvertDateTimeToFrameTime(this DateTime dateTime)
        {
            var dt = DateTime.Parse(DateConvertSql(dateTime));
            return (long)dt.Subtract(new DateTime(1970, 1, 1)).TotalMilliseconds;
        }

        public static long ConvertDateTimeToFrameTimeUtc(this DateTime dateTime)
        {
            var dt = DateTime.Parse(DateConvertSql(dateTime.ToUniversalTime()));
            return (long)dt.Subtract(new DateTime(1970, 1, 1)).TotalMilliseconds;
        }

        public static string ConvertFrameTimeToDateTime(this DateTime dateTime, long? frameTime, bool moveTime = false)
        {
            if (!moveTime)
            {
                dateTime = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddMilliseconds(Convert.ToDouble(frameTime));
                TimeZoneInfo localZone = TimeZoneInfo.Local;
                TimeZoneInfo cstZone = TimeZoneInfo.FindSystemTimeZoneById(zone);
                DateTime cstTime = TimeZoneInfo.ConvertTimeFromUtc(dateTime, cstZone);

                return cstTime.ToString();
            }
            else
            {
                return new DateTime(1970, 1, 1, 0, 0, 0).AddMilliseconds(double.Parse((frameTime).ToString())).ToString();
            }
        }

        public static long ConvertDateTimeToFrameTimeUtc_AllDay(this DateTime dateTime)
        {
            var dt = DateTime.Parse(DateConvertSql_AllDay(dateTime.ToUniversalTime()));
            return (long)dt.Subtract(new DateTime(1970, 1, 1)).TotalMilliseconds;
        }

        public static long ConvertDateTimeToFrameTime_AllDay(this DateTime dateTime)
        {
            var dt = DateTime.Parse(DateConvertSql_AllDay(dateTime));
            return (long)dt.Subtract(new DateTime(1970, 1, 1)).TotalMilliseconds;
        }

        public static int CalendarWeek(this DateTime dateTime)
        {            
            CultureInfo myCI = new CultureInfo("pl-PL");
            Calendar myCal = myCI.Calendar;

            // Gets the DTFI properties required by GetWeekOfYear.
            CalendarWeekRule myCWR = myCI.DateTimeFormat.CalendarWeekRule;
            int result = myCal.GetWeekOfYear(dateTime, myCWR, dateTime.FirstDayOfWeek());
            return result;
        }

        public static DayOfWeek FirstDayOfWeek(this DateTime dateTime)
        {
            CultureInfo myCI = new CultureInfo("pl-PL");

            return myCI.DateTimeFormat.FirstDayOfWeek;
        }

        public static string DayName(this DateTime dateTime)
        {
            CultureInfo myCI = new CultureInfo("pl-PL");
            return myCI.DateTimeFormat.Calendar.GetDayOfWeek(dateTime).ToString();
        }

        public static DateTime FirstDay(this DateTime dateTime)
        {
            string actualNameDay = dateTime.DayName();

            switch (actualNameDay)
            {
                case "Monday":
                    return dateTime;

                case "Tuesday":
                    return dateTime.AddDays(-1);

                case "Wednesday":
                    return dateTime.AddDays(-2);

                case "Thursday":
                    return dateTime.AddDays(-3);

                case "Friday":
                    return dateTime.AddDays(-4);

                case "Saturday":
                    return dateTime.AddDays(-5);

                case "Sunday":
                    return dateTime.AddDays(-6);
            }

            return dateTime;
        }

        public static DateTime LastDay(this DateTime dateTime)
        {
            string actualNameDay = dateTime.DayName();

            switch (actualNameDay)
            {
                case "Monday":
                    return dateTime.AddDays(6);

                case "Tuesday":
                    return dateTime.AddDays(5);

                case "Wednesday":
                    return dateTime.AddDays(4);

                case "Thursday":
                    return dateTime.AddDays(3);

                case "Friday":
                    return  dateTime.AddDays(2);

                case "Saturday":
                    return dateTime.AddDays(1);

                case "Sunday":
                    return dateTime;
            }

            return dateTime;
        }

        public static DateTime SetTimeForShift(this DateTime dateTime)
        {            
            if(dateTime.Hour >= 6 && dateTime.Hour < 14)
            {
                dateTime = dateTime.Date;
                dateTime = dateTime.AddHours(6);
            }
            else if (dateTime.Hour >= 14 && dateTime.Hour < 22)
            {
                dateTime = dateTime.Date;
                dateTime = dateTime.AddHours(14);
            }
            else
            {
                //do poprawy - przeprowadzic testy na 3 shift
                if (dateTime.Hour >= 22 && dateTime.Hour < 24)
                {
                    dateTime = dateTime.Date;
                    dateTime = dateTime.AddHours(22);
                }
                else
                {
                    dateTime = dateTime.Date.AddDays(-1);
                    dateTime = dateTime.AddHours(22);
                }
            }

            return dateTime;
        }

        public static int GetShift(this DateTime dateTime)
        {
            if (dateTime.Hour >= 6 && dateTime.Hour < 14)
            {
                return 1; //shift 1
            }
            else if (dateTime.Hour >= 14 && dateTime.Hour < 22)
            {
                return 2; // shift 2
            }

            return 3;//shift 3
        }

       
    }
}
