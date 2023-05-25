using OnlineHospitalAppointment.Dll.Tools.Helpers;
using OnlineHospitalAppointment.WinForm.Panel.OnlineHospitalAppointment.Identity.Models;

namespace OnlineHospitalAppointment.WinForm.Panel.OnlineHospitalAppointment.Identity.Helpers
{
    public static class IdentityHelper
    {
        public static LoginLogsDto GetLoginLogByUserName(string userName)
        {
            return DapperHelper
                .QueryFirstOrDefault<LoginLogsDto>(IdentityScripts.GetLoginLogsByUserName, new
                {
                    UserName = userName
                });
        }

        public static void CreateUser(string userName, string hashPassword, string insuranceNumber, string nationalCode,
            string name, string lastName, byte isMale, string phoneNumber, string birthDay)
        {
            DapperHelper.ExecuteNonQuery(IdentityScripts.CreateUserScript, new
            {
                userName,
                Password = hashPassword,
                NationalCode = nationalCode,
                InsuranceNumber = insuranceNumber,
                Name = name,
                LastName = lastName,
                IsMale = isMale,
                PhoneNumber = phoneNumber,
                BirthDay = birthDay,
                CreateDateTime = DateTimeHelper.ToUnixTime(DateTime.UtcNow)
            });
        }
    }
}