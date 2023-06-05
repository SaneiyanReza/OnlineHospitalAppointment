using OnlineHospitalAppointment.Dll.Tools.Helpers;
using OnlineHospitalAppointment.WinForm.Panel.OnlineHospitalAppointment.Account;
using OnlineHospitalAppointment.WinForm.Panel.OnlineHospitalAppointment.Admin;
using OnlineHospitalAppointment.WinForm.Panel.OnlineHospitalAppointment.Identity.Enums;
using OnlineHospitalAppointment.WinForm.Panel.OnlineHospitalAppointment.Identity.Helpers;
using OnlineHospitalAppointment.WinForm.Panel.OnlineHospitalAppointment.Identity.Models;
using System.Text.RegularExpressions;

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
            _dbContext = dbContext;
            InitializeComponent();
        }

        private void BtnSignUp_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtPassword.Text) || !string.IsNullOrEmpty(TxtUserName.Text))
            {
                LoginLogsDto loginLogsDto = IdentityHelper.GetLoginLogByUserName(TxtUserName.Text.ToLower());

                if (loginLogsDto is not null)
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
                        case (int)ClientRoleCode.GodAdmin:
                            FrmAdminDashboard frmAdminDashboard = new();
                            userName = TxtUserName.Text.ToLower();
                            frmAdminDashboard.ShowDialog();
                            break;

                        case (int)ClientRoleCode.Expert:
                            FrmExpertDashboard frmExpertDashboard = new();
                            userName = TxtUserName.Text.ToLower();
                            frmExpertDashboard.ShowDialog();
                            break;

                        case (int)ClientRoleCode.User:
                            FrmManageAccount frmManageAccount = new();
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
            int usernameLength = TxtUserName.Text.Length;

            if (usernameLength < 4 || usernameLength > 50)
            {
                e.Cancel = true;
                ErrorProviderApp.SetError(TxtUserName, "username must between 4 to 50 char");
            }
            else if (!Regex.IsMatch(TxtUserName.Text, "^[a-zA-Z0-9_]+$"))
            {
                e.Cancel = true;
                ErrorProviderApp.SetError(TxtUserName, "username must contain a-z , A-Z , 0-9 , _");
            }
            else
            {
                e.Cancel = false;
                ErrorProviderApp.SetError(TxtUserName, string.Empty);
            }
        }

        private void TxtPassword_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            int passwordLength = TxtPassword.Text.Length;

            if (passwordLength < 8)
            {
                e.Cancel = true;
                ErrorProviderApp.SetError(TxtPassword, "passwod must bigger than 8 char");
            }
            else
            {
                e.Cancel = false;
                ErrorProviderApp.SetError(TxtPassword, string.Empty);
            }
        }
    }
}