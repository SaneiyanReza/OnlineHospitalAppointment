namespace OnlineHospitalAppointment.Dll.Tools.Helpers
{
    public static class DateTimeHelper
    {
        public static int ToUnixTime(this DateTime utcDateTime)
        {
            return Convert.ToInt32(utcDateTime.Subtract(new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc)).TotalSeconds);
        }

        public static DateTime UnixTimeToDateTime(int unixTime)
        {
            return new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc).AddSeconds(unixTime);
        }
    }
}