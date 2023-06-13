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
    }
}