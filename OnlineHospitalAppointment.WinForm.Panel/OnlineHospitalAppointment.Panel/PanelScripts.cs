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

        public static string GetReservationLogData =>
            @"SELECT e.FreeDateTime FROM dbo.Users u
                JOIN dbo.ReservationLogs rl ON rl.UserId = u.Id
                JOIN dbo.Experts e ON e.Id = rl.ExpertId
                WHERE rl.UserId = @UserId AND rl.IsCanceled = 0

             SELECT FreeDateTime FROM dbo.Experts
                 WHERE Id = @ExpertId

             SELECT TrackingCode FROM dbo.ReservationLogs
                 WHERE IsCanceled = 0";

        public static string SetReservation =>
            @"INSERT dbo.ReservationLogs
                (UserId, ExpertId, ReservedAt, TrackingCode, IsCanceled)
              VALUES
                (@UserId, @ExpertId, @ReservedAt, @TrackingCode, 0)

             UPDATE dbo.Experts SET IsReserved = 1
                WHERE Id = @ExpertId";

        public static string GetUserAppointment =>
            @"SELECT rl.Id,
                e.FullName,
                st.Specialist,
	            CONCAT(p.Name ,' ' ,c.Name) AS Address,
                rl.TrackingCode,
                rl.ReservedAt,
                rl.IsCanceled
	            FROM dbo.ReservationLogs rl
             JOIN dbo.Experts e ON e.Id = rl.ExpertId
             JOIN dbo.SpecialistTypes st ON st.Id = e.SpecialistTypeId
             JOIN dbo.Cities c ON c.Id = e.CityId
             LEFT JOIN dbo.Provinces p ON p.Id = c.ProvinceId
             WHERE rl.UserId = @UserId
             ORDER BY rl.IsCanceled";

        public static string SetCancelAppointment =>
            @"BEGIN TRANSACTION;

             UPDATE rl
                SET rl.IsCanceled = 1
             FROM dbo.ReservationLogs rl
                WHERE rl.Id = @ReservationLogId

             UPDATE e
                SET e.IsReserved = 0
             FROM dbo.Experts e
                JOIN dbo.ReservationLogs rl ON rl.ExpertId = e.Id
                WHERE rl.Id = @ReservationLogId

            COMMIT;";
    }
}