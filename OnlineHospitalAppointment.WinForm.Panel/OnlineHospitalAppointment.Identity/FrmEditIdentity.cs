using Microsoft.EntityFrameworkCore;
using OnlineHospitalAppointment.Dll.Tools.Helpers;
using OnlineHospitalAppointment.WinForm.Panel.Models;
using OnlineHospitalAppointment.WinForm.Panel.OnlineHospitalAppointment.Identity.Helpers;

namespace OnlineHospitalAppointment.WinForm.Panel.OnlineHospitalAppointment.Identity
{
    public partial class FrmEditIdentity : Form
    {
        private readonly OnlineHospitalAppointmentDbContext _dbContext;

        public static string userName = FrmIdentity.userName;

        public FrmEditIdentity(OnlineHospitalAppointmentDbContext dbContext)
        {
            InitializeComponent();
            _dbContext = dbContext;
        }

        private async void BtnSubmit_Click(object sender, EventArgs e)
        {
            LoginLog loginLog = await _dbContext.LoginLogs
                .FirstOrDefaultAsync(x => x.UserName == userName);

            if (loginLog is null)
                throw new Exception("not found exeption");

            loginLog.UpdateIdentity(TxtUserName.Text, TxtNewPassword.Text);

            User user = await _dbContext.Users
                .FirstOrDefaultAsync(x => x.UserName == userName);

            if (loginLog is null)
                throw new Exception("not found exeption");

            user.UpdateUserName(TxtUserName.Text);

            await _dbContext.SaveChangesAsync();
        }

        private void FrmModifyIdentity_Load(object sender, EventArgs e)
        {
            TxtUserName.Text = userName;
        }

        private void TxtUserName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            (bool isValid, string errorMessage) = UserInfoValidationHelper.UserNameValidation(TxtUserName.Text);

            e.Cancel = !isValid;
            ErrorProviderApp.SetError(TxtUserName, errorMessage);

            if (isValid)
            {
                bool isUniqueUserName = IdentityHelper.IsUniqueUserName(TxtUserName.Text.ToLower());

                if (!isUniqueUserName)
                {
                    e.Cancel = true;
                    ErrorProviderApp.SetError(TxtUserName, "Username Already exist please try another");
                }
            }
        }

        private void TxtCurrentPassword_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            (bool isValid, string errorMessage) = UserInfoValidationHelper.PasswordValidation(TxtCurrentPassword.Text);

            e.Cancel = !isValid;
            ErrorProviderApp.SetError(TxtCurrentPassword, errorMessage);

            if (isValid)
            {
                string userPassword = _dbContext.LoginLogs
                    .Where(x => x.UserName == userName)
                    .Select(x => x.Password)
                    .FirstOrDefault();

                bool equalPassword = PasswordHelper.HashPassword(TxtCurrentPassword.Text)
                    .Equals(userPassword);

                if (!equalPassword)
                {
                    e.Cancel = true;
                    ErrorProviderApp.SetError(TxtCurrentPassword, "Incurrect Password");
                }
            }
        }

        private void TxtNewPassword_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(TxtCurrentPassword.Text))
            {
                e.Cancel = true;
                ErrorProviderApp.SetError(TxtNewPassword, "fill current password");
            }
            else
            {
                (bool isValid, string errorMessage) = UserInfoValidationHelper.PasswordValidation(TxtNewPassword.Text);

                e.Cancel = !isValid;
                ErrorProviderApp.SetError(TxtNewPassword, errorMessage);
            }
        }
    }
}