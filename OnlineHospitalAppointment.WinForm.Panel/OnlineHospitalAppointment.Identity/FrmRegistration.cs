using Microsoft.EntityFrameworkCore;
using OnlineHospitalAppointment.Dll.Tools.Helpers;
using OnlineHospitalAppointment.WinForm.Panel.OnlineHospitalAppointment.Identity.Helpers;

namespace OnlineHospitalAppointment.WinForm.Panel.OnlineHospitalAppointment.Identity
{
    public partial class FrmRegistration : Form
    {
        private readonly OnlineHospitalAppointmentDbContext _dbcontext;

        public FrmRegistration(OnlineHospitalAppointmentDbContext dbContext)
        {
            InitializeComponent();
            _dbcontext = dbContext;
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

                IdentityHelper.CreateUser(userName, hashPassword, TxtNationalCode.Text,
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

        private async void TxtNationalCode_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            (bool isValid, string errorMessage) = UserInfoValidationHelper.NationalCodeValidation(TxtNationalCode.Text);

            if (isValid)
            {
                bool isAccess = await _dbcontext.Users
                    .AnyAsync(x => x.NationalCode == TxtNationalCode.Text
                        && (x.IsDeleted == true || x.IsSuspended == true));

                if (isAccess)
                {
                    e.Cancel = true;
                    ErrorProviderApp.SetError(TxtNationalCode, "دسترسی محدود!");
                }
                else
                {
                    e.Cancel = false;
                    ErrorProviderApp.SetError(TxtNationalCode, string.Empty);
                }
            }
            else
            {
                e.Cancel = true;
                ErrorProviderApp.SetError(TxtNationalCode, errorMessage);
            }
        }

        private async void TxtPhoneNumber_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            (bool isValid, string errorMessage) = UserInfoValidationHelper.PhoneNumberValidation(TxtPhoneNumber.Text);
            if (isValid)
            {
                bool isAccess = await _dbcontext.Users
                  .AnyAsync(x => x.PhoneNumber == TxtPhoneNumber.Text
                      && (x.IsDeleted == true || x.IsSuspended == true));

                if (isAccess)
                {
                    e.Cancel = true;
                    ErrorProviderApp.SetError(TxtPhoneNumber, "دسترسی محدود!");
                }
                else
                {
                    e.Cancel = false;
                    ErrorProviderApp.SetError(TxtPhoneNumber, string.Empty);
                }
            }
            else
            {
                e.Cancel = true;
                ErrorProviderApp.SetError(TxtPhoneNumber, errorMessage);
            }
        }

        private void TxtName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            (bool isValid, string errorMessage) = UserInfoValidationHelper.NameValidation(TxtName.Text);
            if (isValid)
            {
                e.Cancel = false;
                ErrorProviderApp.SetError(TxtName, string.Empty);
            }
            else
            {
                e.Cancel = true;
                ErrorProviderApp.SetError(TxtName, errorMessage);
            }
        }

        private void TxtLastName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            (bool isValid, string errorMessage) = UserInfoValidationHelper.LastNameValidation(TxtLastName.Text);
            if (isValid)
            {
                e.Cancel = false;
                ErrorProviderApp.SetError(TxtLastName, string.Empty);
            }
            else
            {
                e.Cancel = true;
                ErrorProviderApp.SetError(TxtLastName, errorMessage);
            }
        }
    }
}