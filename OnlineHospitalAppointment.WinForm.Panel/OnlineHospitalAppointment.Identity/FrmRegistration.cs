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
            string userName = FrmIdentity.userName;
            string hashPassword = PasswordHelper.HashPassword(FrmIdentity.password);

            string result = DapperHelper.QueryFirstOrDefault<string>(IdentityScripts.IsUniqueNationalCodeOrPhoneNumberScript, new
            {
                NationalCode = TxtNationalCode.Text,
                PhoneNumber = TxtPhoneNumber.Text
            });

            if (result is not null)
            {
                MessageBox.Show("Phone Number or National Code Already exist please try another ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                CreateUser(userName, hashPassword);

                foreach (Control control in Controls)
                {
                    control.Enabled = false;
                }

                BackColor = Color.Green;
                MessageBox.Show("Your Account is created . Please login now.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BackColor = Color.Empty;
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
                ErrorProviderApp.SetError(TxtNationalCode, string.Empty);
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
                ErrorProviderApp.SetError(TxtPhoneNumber, string.Empty);
            }
        }

        private void TxtName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!TxtName.Text.All(char.IsLetter) || (TxtName.Text.Length < 3 || TxtName.Text.Length > 50))
            {
                e.Cancel = true;
                ErrorProviderApp.SetError(TxtPhoneNumber, "Enter Currect Name! Name between 3 to 50 digit");
            }
            else
            {
                e.Cancel = false;
                ErrorProviderApp.SetError(TxtName, string.Empty);
            }
        }

        private void TxtLastName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!TxtLastName.Text.All(char.IsLetter) || (TxtLastName.Text.Length < 4 || TxtLastName.Text.Length > 50))
            {
                e.Cancel = true;
                ErrorProviderApp.SetError(TxtPhoneNumber, "Enter Currect LastName! LastName between 3 to 50 digit");
            }
            else
            {
                e.Cancel = false;
                ErrorProviderApp.SetError(TxtLastName, string.Empty);
            }
        }

        private void CreateUser(string userName, string hashPassword)
        {
            DapperHelper.ExecuteNonQuery(IdentityScripts.CreatLoginLogScript, new
            {
                userName,
                Password = hashPassword,
                CreateDateTime = DateTimeExtension.ToUnixTime(DateTime.UtcNow)
            });

            DapperHelper.ExecuteNonQuery(IdentityScripts.CreateUserScript, new
            {
                userName,
                NationalCode = TxtNationalCode.Text,
                Name = TxtName.Text,
                LastName = TxtLastName.Text,
                IsMale = RbIsMale.Checked ? 1 : 0,
                PhoneNumber = TxtPhoneNumber.Text,
                BirthDay = DateOfBirthTimePicker.Value.Date.ToString("yyyy/MM/dd"),
                CreateDateTime = DateTimeExtension.ToUnixTime(DateTime.UtcNow)
            });
        }
    }
}