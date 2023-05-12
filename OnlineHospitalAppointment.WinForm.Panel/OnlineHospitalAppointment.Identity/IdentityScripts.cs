namespace OnlineHospitalAppointment.WinForm.Panel.OnlineHospitalAppointment.Identity
{
    public static class IdentityScripts
    {
        public static string GetLoginLogsByUserName =>
            $"SELECT Top 1 * FROM dbo.LoginLogs WHERE UserName = @UserName";

        public static string IsUniqueNationalCodeOrPhoneNumberScript =>
            $"SELECT * FROM dbo.Users WHERE NationalCode = @NationalCode OR" +
            $" PhoneNumber = @PhoneNumber";

        public static string CreatLoginLogScript =>
            $"INSERT INTO dbo.LoginLogs" +
            $"(UserName,Password,CreateDateTime)" +
            $"VALUES" +
            $"(@UserName,@Password,@CreateDateTime)";

        public static string CreateUserScript =>
            $"INSERT INTO dbo.Users" +
            $"(UserName,NationalCode,Name,LastName" +
            ",IsMale,PhoneNumber,BirthDay,CreateDateTime)" +
            $"VALUES" +
            $"(@UserName,@NationalCode,@Name,@LastName" +
            ",@IsMale,@PhoneNumber,@BirthDay,@CreateDateTime)";

        public static string IsUniqueUser =>
            "SELECT * FROM dbo.Users WHERE (NationalCode = @NationalCode OR" +
            " PhoneNumber = @PhoneNumber) AND UserName<> @UserName";
    }
}