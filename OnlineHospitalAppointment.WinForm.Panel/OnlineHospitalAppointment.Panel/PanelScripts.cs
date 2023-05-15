namespace OnlineHospitalAppointment.WinForm.Panel.OnlineHospitalAppointment.Panel
{
    public static class PanelScripts
    {
        public static string GetExperts =>
            @"SELECT e.Id,
                e.FullName,
                st.Specialist,
                p.Name AS ProvienceName,
	            c.Name AS CityName,
                e.FreeDateTime,
                e.IsReserved
	            FROM dbo.Experts e
            JOIN dbo.SpecialistTypes st ON st.Id = e.SpecialistTypeId
            JOIN dbo.Cities c ON c.Id = e.CityId
            LEFT JOIN dbo.Provinces p ON p.Id = c.ProvinceId
            WHERE e.IsReserved = 0 AND  e.FreeDateTime > @UtcNow";

        public static string GetReservationData =>
            @"SELECT * FROM dbo.Users
                WHERE UserName = @UserName

            SELECT TrackingCode FROM dbo.ReservationLogs
                WHERE IsCanceled = 0";

        public static string SetReservation =>
            @"INSERT dbo.ReservationLogs
                (UserId, ExpertId, ReservedAt, TrackingCode, IsCanceled)
              VALUES
                (@UserId, @ExpertId, @ReservedAt, @TrackingCode, 0)

             UPDATE dbo.Experts SET IsReserved = 1
                WHERE Id = @ExpertId";
    }
}