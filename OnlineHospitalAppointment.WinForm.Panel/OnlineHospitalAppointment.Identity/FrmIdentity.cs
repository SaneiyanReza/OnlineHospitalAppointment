using OnlineHospitalAppointment.Dll.Tools;

namespace OnlineHospitalAppointment.WinForm.Panel.OnlineHospitalAppointment.Identity
{
    public partial class FrmIdentity : Form
    {
        public static string UserName;
        public static string Password;

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

            if (!string.IsNullOrEmpty(TxtPassword.Text) || !string.IsNullOrEmpty(TxtUserName.Text))
            {
                string result = DapperHelper.QueryFirstOrDefault<string>(IdentityScripts.IsUniqueUserName, new
                {
                    UserName = TxtUserName.Text
                });

                if (!string.IsNullOrWhiteSpace(result))
                {
                    MessageBox.Show("Username Already exist please try another ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    FrmRegistration frmRegistration = new();
                    UserName = TxtUserName.Text;
                    Password = TxtPassword.Text;
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
            MessageBox.Show("Good job");
        }
    }
}