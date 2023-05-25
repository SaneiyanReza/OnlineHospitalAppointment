using OnlineHospitalAppointment.Dll.Tools.Helpers;
using OnlineHospitalAppointment.WinForm.Panel.OnlineHospitalAppointment.Identity.Helpers;

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

            string result = DapperHelper.QueryFirstOrDefault<string>(IdentityScripts.IsUniqueNationalCodeOrPhoneNumberScript,
                new
                {
                    NationalCode = TxtNationalCode.Text,
                    PhoneNumber = TxtPhoneNumber.Text
                });

            if (result is not null)
            {
                MessageBox.Show("Phone Number or National Code Already exist please try another ",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                byte isMale = (byte)(RbIsMale.Checked ? 1 : 0);
                string birthDay = DateOfBirthTimePicker.Value.Date.ToString("yyyy/MM/dd");

                IdentityHelper.CreateUser(userName, hashPassword, TxtInsuranceNumber.Text, TxtNationalCode.Text,
                    TxtName.Text, TxtLastName.Text, isMale, TxtPhoneNumber.Text, birthDay);

                foreach (Control control in Controls)
                {
                    control.Enabled = false;
                }

                BackColor = Color.Green;
                MessageBox.Show("Your Account is created . Please login now.",
                    "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BackColor = Color.Empty;
            }
        }

        private void TxtNationalCode_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (UserInfoValidationHelper.NationalCodeValidation(TxtNationalCode.Text))
            {
                e.Cancel = false;
                ErrorProviderApp.SetError(TxtNationalCode, string.Empty);
            }
            else
            {
                e.Cancel = true;
                ErrorProviderApp.SetError(TxtNationalCode, "Enter Currect National Code!");
            }
        }

        private void TxtPhoneNumber_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (UserInfoValidationHelper.PhoneNumberValidation(TxtPhoneNumber.Text))
            {
                e.Cancel = false;
                ErrorProviderApp.SetError(TxtPhoneNumber, string.Empty);
            }
            else
            {
                e.Cancel = true;
                ErrorProviderApp.SetError(TxtPhoneNumber, "Enter Currect Mobile Phone Number!");
            }
        }

        private void TxtName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (UserInfoValidationHelper.NameValidation(TxtName.Text))
            {
                e.Cancel = false;
                ErrorProviderApp.SetError(TxtName, string.Empty);
            }
            else
            {
                e.Cancel = true;
                ErrorProviderApp.SetError(TxtName, "Enter Currect Name! Name between 3 to 50 digit");
            }
        }

        private void TxtLastName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (UserInfoValidationHelper.LastNameValidation(TxtLastName.Text))
            {
                e.Cancel = false;
                ErrorProviderApp.SetError(TxtLastName, string.Empty);
            }
            else
            {
                e.Cancel = true;
                ErrorProviderApp.SetError(TxtLastName, "Enter Currect LastName! LastName between 3 to 50 digit");
            }
        }

        private void TxtInsuranceNumber_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (UserInfoValidationHelper.InsuranceNumberValidation(TxtInsuranceNumber.Text))
            {
                e.Cancel = false;
                ErrorProviderApp.SetError(TxtInsuranceNumber, string.Empty);
            }
            else
            {
                e.Cancel = true;
                ErrorProviderApp.SetError(TxtInsuranceNumber, "Enter Currect Insurance Number!");
            }
        }

        private void ChkInsuranceNumber_CheckStateChanged(object sender, EventArgs e)
        {
            TxtInsuranceNumber.Enabled = (ChkInsuranceNumber.CheckState == CheckState.Checked);

            if (ChkInsuranceNumber.CheckState != CheckState.Checked)
                TxtInsuranceNumber.Text = null;
        }
    }
}