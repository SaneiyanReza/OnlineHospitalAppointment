namespace OnlineHospitalAppointment.WinForm.Panel.OnlineHospitalAppointment.Account
{
    public static class ManageAccountScripts
    {
        public static string UpdateUserAccountScript =
            @"UPDATE dbo.Users
                SET NationalCode = @NationalCode ,Name = @Name ,LastName = @LastName ,
                BirthDay = @BirthDay ,IsMale = @IsMale ,PhoneNumber = @PhoneNumber
                WHERE UserName = @UserName";

        public static string GetUserByUserName =
            @"SELECT NationalCode ,Name ,LastName ,IsMale ,PhoneNumber ,BirthDay
                FROM dbo.Users WHERE UserName = @UserName";
    }
}