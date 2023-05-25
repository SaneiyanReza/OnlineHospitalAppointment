namespace OnlineHospitalAppointment.WinForm.Panel.OnlineHospitalAppointment.Identity
{
    public static class IdentityScripts
    {
        public static string GetLoginLogsByUserName =>
            @"SELECT Top 1 * FROM dbo.LoginLogs WHERE UserName = @UserName";

        public static string IsUniqueNationalCodeOrPhoneNumberScript =>
            @"SELECT * FROM dbo.Users WHERE NationalCode = @NationalCode OR PhoneNumber = @PhoneNumber";

        public static string CreateUserScript =>
            @"INSERT INTO dbo.LoginLogs
                (UserName,Password,CreateDateTime)
               VALUES
                (@UserName,@Password,@CreateDateTime)

             INSERT INTO dbo.Users
                (UserName,NationalCode,InsuranceNumber,Name,LastName
                ,IsMale,PhoneNumber,BirthDay,CreateDateTime)
               VALUES
                (@UserName,@NationalCode,@InsuranceNumber,@Name,@LastName
                ,@IsMale,@PhoneNumber,@BirthDay,@CreateDateTime)";

        public static string IsUniqueUser =>
            @"SELECT * FROM dbo.Users WHERE (NationalCode = @NationalCode OR
                PhoneNumber = @PhoneNumber) AND Id <> @UserId";

        public static string GetUserId =>
            @"SELECT Id FROM dbo.Users
                WHERE UserName = @UserName";
    }
}