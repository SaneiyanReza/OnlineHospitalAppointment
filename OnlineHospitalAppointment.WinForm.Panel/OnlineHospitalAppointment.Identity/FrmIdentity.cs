using OnlineHospitalAppointment.Dll.Tools;
using OnlineHospitalAppointment.WinForm.Panel.OnlineHospitalAppointment.Account;
using OnlineHospitalAppointment.WinForm.Panel.OnlineHospitalAppointment.Identity.Models;
using System.Text.RegularExpressions;

namespace OnlineHospitalAppointment.WinForm.Panel.OnlineHospitalAppointment.Identity
{
    public partial class FrmIdentity : Form
    {
        public static string userName;
        public static string password;

        public FrmIdentity()
        {
            InitializeComponent();
        }

        private void BtnSignUp_Click(object sender, EventArgs e)
        {
            int usernameLength = TxtUserName.Text.Length;

            if (usernameLength < 4 || usernameLength > 50)
            {
                MessageBox.Show("username must between 4 to 50 char");
                TxtUserName.Clear();
                return;
            }

            int passwordLength = TxtPassword.Text.Length;

            if (passwordLength < 8)
            {
                MessageBox.Show("passwod must bigger than 8 char");
                TxtPassword.Clear();
                return;
            }

            if (!Regex.IsMatch(TxtUserName.Text, "^[a-zA-Z0-9_]+$"))
            {
                MessageBox.Show("username must contain a-z , A-Z , 0-9 , _");
                TxtUserName.Clear();
                return;
            }

            if (!string.IsNullOrEmpty(TxtPassword.Text) || !string.IsNullOrEmpty(TxtUserName.Text))
            {
                LoginLogsDto loginLogsDto = GetLoginLogByUserName();

                if (loginLogsDto is not null)
                {
                    MessageBox.Show("Username Already exist please try another ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Please Enter currect value");
            }
        }

        private void BtnLogIn_Click(object sender, EventArgs e)
        {
            LoginLogsDto loginLogsDto = GetLoginLogByUserName();

            if (loginLogsDto is null)
            {
                MessageBox.Show("UserName Not Found!");
            }
            else
            {
                bool equalPassword = PasswordHelper.HashPassword(TxtPassword.Text).Equals(loginLogsDto.Password);

                if (!equalPassword)
                {
                    MessageBox.Show("Incurrect Password");
                }
                else
                {
                    FrmManageAccount frmManageAccount = new();
                    userName = TxtUserName.Text.ToLower();
                    frmManageAccount.ShowDialog();
                }
            }
        }

        private LoginLogsDto GetLoginLogByUserName()
        {
            return DapperHelper
                .QueryFirstOrDefault<LoginLogsDto>(IdentityScripts.GetLoginLogsByUserName, new
                {
                    UserName = TxtUserName.Text.ToLower()
                });
        }
    }
}