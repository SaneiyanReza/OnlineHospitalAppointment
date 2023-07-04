using OnlineHospitalAppointment.Dll.Tools.Helpers;
using OnlineHospitalAppointment.WinForm.Panel.OnlineHospitalAppointment.Account;
using OnlineHospitalAppointment.WinForm.Panel.OnlineHospitalAppointment.Admin;
using OnlineHospitalAppointment.WinForm.Panel.OnlineHospitalAppointment.Identity.Enums;
using OnlineHospitalAppointment.WinForm.Panel.OnlineHospitalAppointment.Identity.Helpers;
using OnlineHospitalAppointment.WinForm.Panel.OnlineHospitalAppointment.Identity.Models;

namespace OnlineHospitalAppointment.WinForm.Panel.OnlineHospitalAppointment.Identity
{
    public partial class FrmIdentity : Form
    {
        public static string userName;
        public static string password;
        public static int userId;

        private readonly OnlineHospitalAppointmentDbContext _dbContext;

        public FrmIdentity(OnlineHospitalAppointmentDbContext dbContext)
        {
            InitializeComponent();
            _dbContext = dbContext;
        }

        private void BtnSignUp_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtPassword.Text) || !string.IsNullOrEmpty(TxtUserName.Text))
            {
                bool isUniqueUserName = IdentityHelper.IsUniqueUserName(TxtUserName.Text.ToLower());

                if (!isUniqueUserName)
                {
                    MessageBox.Show("Username Already exist please try another ",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    FrmRegistration frmRegistration = new();
                    userName = TxtUserName.Text.ToLower();
                    password = TxtPassword.Text;
                    frmRegistration.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Please Fill Text Boxes");
            }
        }

        private void BtnLogIn_Click(object sender, EventArgs e)
        {
            LoginLogsDto loginLogsDto = IdentityHelper.GetLoginLogByUserName(TxtUserName.Text.ToLower());

            if (loginLogsDto is null)
            {
                MessageBox.Show("UserName Not Found!");
            }
            else
            {
                bool equalPassword = PasswordHelper.HashPassword(TxtPassword.Text)
                    .Equals(loginLogsDto.Password);

                if (!equalPassword)
                {
                    MessageBox.Show("Incurrect Password");
                }
                else
                {
                    userId = DapperHelper.QueryFirstOrDefault<int>(IdentityScripts.GetUserId, new
                    {
                        loginLogsDto.UserName
                    });

                    switch (loginLogsDto.RoleId)
                    {
                        case (int)RoleId.GodAdmin:
                            FrmAdminDashboard frmAdminDashboard = new(_dbContext);
                            userName = TxtUserName.Text.ToLower();
                            frmAdminDashboard.ShowDialog();
                            break;

                        case (int)RoleId.Expert:
                            FrmExpertDashboard frmExpertDashboard = new(_dbContext);
                            userName = TxtUserName.Text.ToLower();
                            frmExpertDashboard.ShowDialog();
                            break;

                        case (int)RoleId.User:
                            FrmManageAccount frmManageAccount = new(_dbContext);
                            userName = TxtUserName.Text.ToLower();
                            frmManageAccount.ShowDialog();
                            break;

                        default:
                            break;
                    }
                }
            }
        }

        private void TxtUserName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            (bool isValid, string errorMessage) = UserInfoValidationHelper.UserNameValidation(TxtUserName.Text);

            e.Cancel = !isValid;
            ErrorProviderApp.SetError(TxtUserName, errorMessage);
        }

        private void TxtPassword_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            (bool isValid, string errorMessage) = UserInfoValidationHelper.PasswordValidation(TxtPassword.Text);

            e.Cancel = !isValid;
            ErrorProviderApp.SetError(TxtPassword, errorMessage);
        }
    }
}