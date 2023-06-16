namespace OnlineHospitalAppointment.WinForm.Panel.OnlineHospitalAppointment.Admin
{
    public class AdminScripts
    {
        public static string GetAdminDashboard =>
            @"SELECT COUNT(u.Id)
              FROM dbo.Users u
              WHERE u.IsDeleted = 0 AND u.IsSuspended = 0 AND u.RoleId = 3

              SELECT COUNT(e.Id)
              FROM dbo.Experts e
              WHERE e.IsDeleted = 0 AND e.IsSuspended = 0

              SELECT COUNT(rl.Id)
              FROM dbo.ReservationLogs rl
              JOIN dbo.Experts e ON e.Id = rl.ExpertId
              WHERE rl.IsCanceled = 0 AND e.IsDeleted = 0 AND e.IsSuspended = 0";

        public static string GetUsers =>
            @"SELECT * FROM dbo.Users
                WHERE RoleId = 3";

        public static string GetExpertDashboard =>
            @"SELECT FullName FROM dbo.Experts
             WHERE Id = @ExpertId And IsDeleted = 0 AND IsSuspended = 0

             SELECT COUNT(u.Id)
             FROM dbo.AppointmentCharts
             WHERE ExpertId = @ExpertId AND IsReserved = 1

             SELECT COUNT(u.Id)
             FROM dbo.ReservationLogs
             WHERE ExpertId = @ExpertId AND IsCanceled = 1";

        public static string GetAppointmentChart =>
            @"SELECT ac.Id,
              ac.UserId,
              ac.AppointmentDate,
              e.FullName,
              u.UserName,
              u.NationalCode,
              u.PhoneNumber FROM dbo.AppointmentCharts ac
              JOIN dbo.Experts e ON e.Id = ac.ExpertId
              JOIN dbo.Users u ON u.Id = ac.UserId
              WHERE ac.ExpertId = @ExpertId";
    }
}