using OnlineHospitalAppointment.Dll.Tools;
using System.Data.SqlClient;

namespace OnlineHospitalAppointment.WinForm.Panel.OnlineHospitalAppointment.Identity
{
    public partial class FrmRegistration : Form
    {
        private SqlCommand cmd;
        private SqlConnection cnn;

        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void FrmRegistration_Load(object sender, EventArgs e)
        {
            cnn = new(@"Server=.;Database=OnlineHospitalAppointmentDB;Trusted_Connection=True;");
            cnn.Open();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            string userName = FrmIdentity.UserName;
            string hashPassword = PasswordHelper.HashPassword(FrmIdentity.Password);

            if ((TxtName.Name.Length < 3 && TxtName.Name.Length > 50) || (TxtLastName.Text.Length < 4 && TxtLastName.Text.Length > 50))
            {
                MessageBox.Show("Please Enter currect value");
            }
            else
            {
                cmd = new SqlCommand("insert into Logins values(@UserName,@Password)", cnn);
                cmd.Parameters.AddWithValue("UserName", userName);
                cmd.Parameters.AddWithValue("Password", hashPassword);
                cmd = new SqlCommand("insert into Users values(@UserName,@NationalCode,@Name,@LastName" +
                    ",@Gender,@PhoneNumber,@BirthDay)", cnn);
                cmd.Parameters.AddWithValue("UserName", userName);
                cmd.Parameters.AddWithValue("NationalCode", TxtNationalCode.Text);
                cmd.Parameters.AddWithValue("Name", TxtName.Text);
                cmd.Parameters.AddWithValue("LastName", TxtLastName.Text);
                cmd.Parameters.AddWithValue("Gender", RbIsMale.Checked ? 1 : 0);
                cmd.Parameters.AddWithValue("PhoneNumber", TxtPhoneNumber.Text);
                cmd.Parameters.AddWithValue("BirthDay", DateOfBirthTimePicker.Value.ToString("yyyy/mm/dd"));
                cmd.ExecuteNonQuery();
                BtnSubmit.Enabled = false;
                BackColor = Color.Green;
                MessageBox.Show("Your Account is created . Please login now.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TxtNationalCode_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!TxtNationalCode.Text.All(char.IsDigit) || TxtNationalCode.Text.Length != 10)
            {
                e.Cancel = true;
                ErrorProviderApp.SetError(TxtNationalCode, "Enter Currect National Code!");
            }
            else
            {
                e.Cancel = false;
                ErrorProviderApp.SetError(TxtNationalCode, "");
            }
        }

        private void TxtPhoneNumber_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!TxtPhoneNumber.Text.All(char.IsDigit) || TxtPhoneNumber.Text.Length != 11)
            {
                e.Cancel = true;
                ErrorProviderApp.SetError(TxtPhoneNumber, "Enter Currect Mobile Phone Number!");
            }
            else
            {
                e.Cancel = false;
                ErrorProviderApp.SetError(TxtPhoneNumber, "");
            }
        }
    }
}