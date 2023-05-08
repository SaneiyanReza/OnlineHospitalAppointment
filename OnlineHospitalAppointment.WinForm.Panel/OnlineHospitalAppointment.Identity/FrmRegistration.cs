using OnlineHospitalAppointment.Dll.Tools;

namespace OnlineHospitalAppointment.WinForm.Panel.OnlineHospitalAppointment.Identity
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            string userName = FrmIdentity.UserName;
            string hashPassword = PasswordHelper.HashPassword(FrmIdentity.Password);

            if ((TxtName.Text.Length < 3 || TxtName.Text.Length > 50) ||
                (TxtLastName.Text.Length < 4 || TxtLastName.Text.Length > 50))
            {
                MessageBox.Show("Please Enter currect value");
            }

            string result = DapperHelper.QueryFirstOrDefault<string>(IdentityScripts.IsUniqueNationalCodeOrPhoneNumber, new
            {
                NationalCode = TxtNationalCode.Text,
                PhoneNumber = TxtPhoneNumber.Text
            });

            if (!string.IsNullOrWhiteSpace(result))
            {
                MessageBox.Show("Phone Number or National Code Already exist please try another ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DapperHelper.ExecuteNonQuery(IdentityScripts.CreatLoginLog, new
                {
                    userName,
                    Password = hashPassword
                });

                DapperHelper.ExecuteNonQuery(IdentityScripts.CreateUser, new
                {
                    userName,
                    NationalCode = TxtNationalCode.Text,
                    Name = TxtName.Text,
                    LastName = TxtLastName.Text,
                    Gender = RbIsMale.Checked ? 1 : 0,
                    PhoneNumber = TxtPhoneNumber.Text,
                    BirthDay = DateOfBirthTimePicker.Value.ToString("yyyy/mm/dd"),
                });

                foreach (Control control in this.Controls)
                {
                    control.Enabled = false;
                }

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