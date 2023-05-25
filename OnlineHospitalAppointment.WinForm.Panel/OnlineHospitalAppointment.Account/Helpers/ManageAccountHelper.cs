using OnlineHospitalAppointment.Dll.Tools.Helpers;
using OnlineHospitalAppointment.WinForm.Panel.OnlineHospitalAppointment.Account.Models;

namespace OnlineHospitalAppointment.WinForm.Panel.OnlineHospitalAppointment.Account.Helper
{
    public static class ManageAccountHelper
    {
        public static ManageAccountDto GetAccountData(int userId)
        {
            return DapperHelper.QueryFirstOrDefault<ManageAccountDto>(ManageAccountScripts.GetUserByUserId, new
            {
                userId
            });
        }
    }
}