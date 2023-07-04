namespace OnlineHospitalAppointment.WinForm.Panel.OnlineHospitalAppointment.Identity
{
    public static class IdentityScripts
    {
        public static string GetLoginLogsByUserName =>
            @"SELECT Top 1 u.Id,
               ll.UserName,
               ll.Password,
               u.RoleId
        	 FROM dbo.LoginLogs ll
              JOIN dbo.Users u ON u.UserName = ll.UserName
             WHERE ll.UserName = @UserName";

        public static string IsUniqueNationalCodeOrPhoneNumberScript =>
            @"SELECT * FROM dbo.Users WHERE NationalCode = @NationalCode OR PhoneNumber = @PhoneNumber";

        public static string IsUniqueNationalCodeOrPhoneNumberExpertScript =>
            @"SELECT * FROM dbo.Users WHERE Id <> @UserId AND (NationalCode = @NationalCode OR PhoneNumber = @PhoneNumber)";

        public static string CreateUserScript =>
            @"BEGIN TRANSACTION

              BEGIN TRY

                 INSERT INTO dbo.LoginLogs
                    (UserName,Password,CreateDateTime)
                   VALUES
                    (@UserName,@Password,@CreateDateTime)

                 DECLARE @LoginLogId INT = (SELECT TOP 1 Id FROM dbo.LoginLogs WHERE UserName = @UserName)

                 INSERT INTO dbo.Users
                    (UserName,LoginLogId,NationalCode,Name,LastName
                    ,IsMale,PhoneNumber,BirthDay,CreateDateTime,RoleId
                     ,IsDeleted,IsSuspended)
                   VALUES
                    (@UserName,@LoginLogId,@NationalCode,@Name,@LastName
                    ,@IsMale,@PhoneNumber,@BirthDay,@CreateDateTime,3
                     ,0,0)

                COMMIT TRANSACTION
			  END TRY

              BEGIN CATCH
			    ROLLBACK TRANSACTION
			  END CATCH";

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
                        SELECT ll.UserName FROM dbo.LoginLogs ll
						    WHERE ll.UserName LIKE @UserName) tbl";

        public static string CountSimilarUserName =>
            @"DECLARE @LoginLogId INT = (SELECT TOP 1 LoginLogId FROM dbo.Users WHERE Id = @UserId)

            SELECT COUNT(tbl.UserName) FROM (
                        SELECT u.UserName FROM dbo.Users u
                            WHERE u.UserName LIKE @UserName AND u.Id <> @UserId
                        UNION
                        SELECT ll.UserName FROM dbo.LoginLogs ll
						    WHERE ll.UserName LIKE @UserName AND ll.Id <> @LoginLogId) tbl";
    }
}