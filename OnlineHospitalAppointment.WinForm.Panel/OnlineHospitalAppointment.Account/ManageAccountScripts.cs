namespace OnlineHospitalAppointment.WinForm.Panel.OnlineHospitalAppointment.Account
{
    public static class ManageAccountScripts
    {
        public static string UpdateUserAccountScript =
            $"UPDATE dbo.Users " +
            $"SET NationalCode = @NationalCode ,Name = @Name ,LastName = @LastName , " +
            $"BirthDay = @BirthDay ,Gender = @Gender ,PhoneNumber = @PhoneNumber " +
            $"WHERE UserName = @UserName";

        public static string GetUserByUserName =
            $"SELECT NationalCode ,Name ,LastName ,Gender ,PhoneNumber ,BirthDay " +
            $"FROM dbo.Users WHERE UserName = @UserName";
    }
}