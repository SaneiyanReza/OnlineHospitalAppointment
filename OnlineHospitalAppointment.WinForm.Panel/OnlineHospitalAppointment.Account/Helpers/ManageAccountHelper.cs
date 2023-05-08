using OnlineHospitalAppointment.Dll.Tools;
using OnlineHospitalAppointment.WinForm.Panel.OnlineHospitalAppointment.Account.Models;

namespace OnlineHospitalAppointment.WinForm.Panel.OnlineHospitalAppointment.Account.Helper
{
    public static class ManageAccountHelper
    {
        public static ManageAccountDto GetAccountData(string userName)
        {
            return DapperHelper.QueryFirstOrDefault<ManageAccountDto>(ManageAccountScripts.GetUserByUserName, new
            {
                userName
            });
        }
    }
}