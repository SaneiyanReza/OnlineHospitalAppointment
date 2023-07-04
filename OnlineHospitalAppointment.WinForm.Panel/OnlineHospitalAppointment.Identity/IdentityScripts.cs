namespace OnlineHospitalAppointment.WinForm.Panel.OnlineHospitalAppointment.Identity
{
    public static class IdentityScripts
    {
        public static string GetLoginLogsByUserName =>
            @"SELECT Top 1 ll.UserName,
               ll.Password,
               u.RoleId
        	 FROM dbo.LoginLogs ll
              JOIN dbo.Users u ON u.UserName = ll.UserName
             WHERE ll.UserName = @UserName";

        public static string IsUniqueNationalCodeOrPhoneNumberScript =>
            @"SELECT * FROM dbo.Users WHERE NationalCode = @NationalCode OR PhoneNumber = @PhoneNumber";

        public static string CreateUserScript =>
            @"INSERT INTO dbo.LoginLogs
                (UserName,Password,CreateDateTime)
               VALUES
                (@UserName,@Password,@CreateDateTime)

             INSERT INTO dbo.Users
                (UserName,NationalCode,Name,LastName
                ,IsMale,PhoneNumber,BirthDay,CreateDateTime)
               VALUES
                (@UserName,@NationalCode,@Name,@LastName
                ,@IsMale,@PhoneNumber,@BirthDay,@CreateDateTime)";

        public static string IsUniqueUser =>
            @"SELECT * FROM dbo.Users WHERE (NationalCode = @NationalCode OR
                PhoneNumber = @PhoneNumber) AND Id <> @UserId";

        public static string GetUserId =>
            @"SELECT Id FROM dbo.Users
                WHERE UserName = @UserName";

        public static string IsUniqueUserName =>
            @"SELECT TOP 1 * FROM (
                        SELECT u.UserName FROM dbo.Users u
                            WHERE u.UserName LIKE @UserName
                        UNION
                        SELECT * FROM dbo.LoginLogs ll
						    WHERE ll.UserName LIKE @UserName) tbl";
    }
}