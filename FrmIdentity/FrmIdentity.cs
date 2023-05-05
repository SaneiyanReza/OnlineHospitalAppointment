using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;

namespace FrmIdentity
{
    public partial class FrmIdentity : Form
    {
        private const string passwordHash = "919%6Ande919";

        private SqlCommand cmd;
        private SqlConnection cnn;
        private SqlDataReader dr;

        public FrmIdentity()
        {
            InitializeComponent();
        }

        private void FrmIdentity_Load(object sender, EventArgs e)
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
            }

            int passwordLength = TxtPassword.Text.Length;

            if (passwordLength < 8)
            {
                MessageBox.Show("passwod must bigger than 8 char");
                TxtPassword.Clear();
            }

            if (!string.IsNullOrEmpty(TxtPassword.Text) || !string.IsNullOrEmpty(TxtUserName.Text))
            {
                string encryptPassword;
                byte[] data = Encoding.UTF8.GetBytes(TxtPassword.Text);
                using (MD5CryptoServiceProvider md5 = new())
                {
                    byte[] keys = md5.ComputeHash(Encoding.UTF8.GetBytes(passwordHash));
                    using (TripleDESCryptoServiceProvider tripleDes = new TripleDESCryptoServiceProvider()
                    { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                    {
                        ICryptoTransform transform = tripleDes.CreateEncryptor();
                        byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                        encryptPassword = Convert.ToBase64String(results);
                    }
                }

                cmd = new SqlCommand("select * from Login where username='" + TxtUserName.Text + "'", cnn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    MessageBox.Show("Username Already exist please try another ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dr.Close();
                    cmd = new SqlCommand("insert into Login values(@UserName,@Password)", cnn);
                    cmd.Parameters.AddWithValue("UserName", TxtUserName.Text);
                    cmd.Parameters.AddWithValue("Password", encryptPassword);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Your Account is created . Please login now.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please Enter currect value");
            }
        }
    }
}