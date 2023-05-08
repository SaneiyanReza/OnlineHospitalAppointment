namespace OnlineHospitalAppointment.WinForm.Panel.OnlineHospitalAppointment.Identity
{
    public static class IdentityScripts
    {
        public static string GetLoginLogsByUserName =
            $"SELECT Top 1 * FROM dbo.LoginLogs WHERE UserName = @UserName";

        public static string IsUniqueNationalCodeOrPhoneNumberScript =
            $"SELECT * FROM dbo.Users WHERE NationalCode = @NationalCode OR" +
                $" PhoneNumber = @PhoneNumber";

        public static string CreatLoginLogScript =
            $"INSERT INTO dbo.LoginLogs" +
            $"(UserName,Password)" +
            $"VALUES" +
            $"(@UserName,@Password)";

        public static string CreateUserScript =
            $"INSERT INTO dbo.Users" +
            $"(UserName,NationalCode,Name,LastName" +
            ",Gender,PhoneNumber,BirthDay)" +
            $"VALUES" +
            $"(@UserName,@NationalCode,@Name,@LastName" +
            ",@Gender,@PhoneNumber,@BirthDay)";
    }
}