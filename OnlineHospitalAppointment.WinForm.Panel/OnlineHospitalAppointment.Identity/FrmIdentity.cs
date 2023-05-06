using System.Data.SqlClient;

namespace OnlineHospitalAppointment.WinForm.Panel.OnlineHospitalAppointment.Identity
{
    public partial class FrmIdentity : Form
    {
        public static string UserName;
        public static string Password;

        private SqlCommand cmd;
        private SqlConnection cnn;
        private SqlDataReader dr;

        public FrmIdentity()
        {
            InitializeComponent();
        }

        private void FrmRegistration_Load(object sender, EventArgs e)
        {
            cnn = new(@"Server=.;Database=OnlineHospitalAppointmentDB;Trusted_Connection=True;");
            cnn.Open();
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
                cmd = new SqlCommand("select * from Logins where username='" + TxtUserName.Text + "'", cnn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
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

                dr.Close();
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