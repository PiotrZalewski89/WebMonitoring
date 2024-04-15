using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebMonitoring.Models
{
    public class FrameTime
    {
        private static string zone => "Central European Standard Time";

        public static DateTime SelectedFrameTime(long? frameTime_1, long? frameTime_2, long? frameTime_3, long? frameTime_4, bool moveTime = false)
        {
            if (frameTime_1 != null && frameTime_1 > (frameTime_2 != null ? frameTime_2 : 0) && frameTime_1 > (frameTime_3 != null ? frameTime_3 : 0) && frameTime_1 > (frameTime_4 != null ? frameTime_4 : 0))
                return ConvertFrameTime(frameTime_1, moveTime);
            else if (frameTime_2 != null && frameTime_2 > (frameTime_1 != null ? frameTime_1 : 0) && frameTime_2 > (frameTime_3 != null ? frameTime_3 : 0) && frameTime_2 > (frameTime_4 != null ? frameTime_4 : 0))
                return ConvertFrameTime(frameTime_2, moveTime);
            else if (frameTime_3 != null && frameTime_3 > (frameTime_2 != null ? frameTime_2 : 0) && frameTime_3 > (frameTime_1 != null ? frameTime_1 : 0) && frameTime_3 > (frameTime_4 != null ? frameTime_4 : 0))
                return ConvertFrameTime(frameTime_3, moveTime);
            else if (frameTime_4 != null && frameTime_4 > (frameTime_2 != null ? frameTime_2 : 0) && frameTime_4 > (frameTime_1 != null ? frameTime_1 : 0) && frameTime_4 > (frameTime_3 != null ? frameTime_3 : 0))
                return ConvertFrameTime(frameTime_4, moveTime);
            else
                return DateTime.Now;
        }

        private static DateTime ConvertFrameTime(long? frameTime, bool moveTime = false)
        {
            if (!moveTime)
            {
                DateTime utcDateTime = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddMilliseconds(Convert.ToDouble(frameTime));
                TimeZoneInfo localZone = TimeZoneInfo.Local;
                TimeZoneInfo cstZone = TimeZoneInfo.FindSystemTimeZoneById(zone);
                DateTime cstTime = TimeZoneInfo.ConvertTimeFromUtc(utcDateTime, cstZone);

                return cstTime;
            }
            else
            {
                return new DateTime(1970, 1, 1, 0, 0, 0).AddMilliseconds(double.Parse((frameTime).ToString()));
            }
        }
    }
}
