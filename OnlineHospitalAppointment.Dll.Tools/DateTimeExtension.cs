namespace OnlineHospitalAppointment.Dll.Tools
{
    public static class DateTimeExtension
    {
        public static int ToUnixTime(this DateTime utcDateTime)
        {
            return Convert.ToInt32(utcDateTime.Subtract(new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc)).TotalSeconds);
        }
    }
}