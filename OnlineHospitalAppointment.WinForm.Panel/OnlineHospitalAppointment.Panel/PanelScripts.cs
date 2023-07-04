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
                e.IsDeleted,
                e.IsSuspended
	            FROM dbo.Experts e
             JOIN dbo.SpecialistTypes st ON st.Id = e.SpecialistTypeId
             JOIN dbo.Cities c ON c.Id = e.CityId
             LEFT JOIN dbo.Provinces p ON p.Id = c.ProvinceId
                ORDER BY e.IsDeleted";

        public static string GetReservationLogData =>
            @"SELECT ac.AppointmentDate FROM dbo.AppointmentCharts ac
                WHERE ac.Id = @AppointmentChartId AND ac.IsReserved = 0

             SELECT ac.AppointmentDate FROM dbo.AppointmentCharts ac
                WHERE ac.UserId = @UserID AND ac.IsReserved = 1

             SELECT TrackingCode FROM dbo.ReservationLogs
                 WHERE IsCanceled = 0";

        public static string SetReservation =>
            @"DECLARE @ExpertId INT = (SELECT TOP 1 ExpertId FROM dbo.AppointmentCharts WHERE Id = @AppointmentChartId)

             INSERT INTO dbo.ReservationLogs
                (
                    UserId, ExpertId, AppointmentChartId, ReservedAt, TrackingCode, IsCanceled, TypeCanceled, Description
                )
                VALUES
                (
                	@UserId, @ExpertId, @AppointmentChartId, @ReservedAt, @TrackingCode, 0, NULL, NULL
                )

             UPDATE dbo.AppointmentCharts SET IsReserved = 1
                WHERE Id = @AppointmentChartId";

        public static string GetUserAppointment =>
            @"SELECT ac.Id,
                e.FullName,
                st.Specialist,
	            CONCAT(p.Name ,' ' ,c.Name) AS Address,
                rl.TrackingCode,
				ac.AppointmentDate,
                rl.ReservedAt,
                rl.IsCanceled FROM dbo.AppointmentCharts ac
              JOIN dbo.ReservationLogs rl ON rl.AppointmentChartId = ac.Id
              JOIN dbo.Experts e ON e.Id = ac.ExpertId
              JOIN dbo.SpecialistTypes st ON st.Id = e.SpecialistTypeId
              JOIN dbo.Cities c ON c.Id = e.CityId
              LEFT JOIN dbo.Provinces p ON p.Id = c.ProvinceId
                WHERE ac.UserId = @UserId
                ORDER BY rl.IsCanceled";

        public static string SetCancelAppointment =>
            @"BEGIN TRANSACTION;

             UPDATE dbo.AppointmentCharts SET IsReserved = 0
                WHERE Id = @AppointmentChartId

             UPDATE dbo.ReservationLogs SET IsCanceled = 1 , Description = @Description , TypeCanceled = @TypeCanceled
                WHERE AppointmentChartId = @AppointmentChartId

            COMMIT;";

        public static string GetAppointmentChart =>
            @"SELECT ac.Id,
                ac.UserId,
                ac.ExpertId,
                ac.AppointmentDate,
                ac.IsReserved,
                e.FullName
	            FROM dbo.AppointmentCharts ac
             JOIN dbo.Experts e ON e.Id = ac.ExpertId
                WHERE ac.ExpertId = @ExpertId AND ac.AppointmentDate > @AppointmentDate
                AND ac.IsReserved = 0";
    }
}