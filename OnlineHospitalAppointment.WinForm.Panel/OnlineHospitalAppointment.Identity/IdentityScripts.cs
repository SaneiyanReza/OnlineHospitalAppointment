namespace OnlineHospitalAppointment.WinForm.Panel.OnlineHospitalAppointment.Identity
{
    public static class IdentityScripts
    {
        public static string IsUniqueUserName =
            $"SELECT Top 1 * FROM dbo.Logins WHERE UserName = @UserName";

        public static string IsUniqueNationalCodeOrPhoneNumber =
            $"SELECT * FROM dbo.Users WHERE NationalCode = @NationalCode OR" +
                $" PhoneNumber = @PhoneNumber";

        public static string CreatLoginLog =
            $"INSERT INTO dbo.Logins" +
            $"(UserName,Password)" +
            $"VALUES" +
            $"(@UserName,@Password)";

        public static string CreateUser =
            $"INSERT INTO dbo.Users" +
            $"(UserName,NationalCode,Name,LastName" +
            ",Gender,PhoneNumber,BirthDay)" +
            $"VALUES" +
            $"(@UserName,@NationalCode,@Name,@LastName" +
            ",@Gender,@PhoneNumber,@BirthDay)";
    }
}