using OnlineHospitalAppointment.Dll.Tools.Helpers;
using OnlineHospitalAppointment.WinForm.Panel.Models;
using OnlineHospitalAppointment.WinForm.Panel.OnlineHospitalAppointment.Identity.Enums;
using OnlineHospitalAppointment.WinForm.Panel.OnlineHospitalAppointment.Identity.Helpers;

namespace OnlineHospitalAppointment.WinForm.Panel.OnlineHospitalAppointment.Admin
{
    public partial class FrmAddExpertByAdmin : Form
    {
        private readonly OnlineHospitalAppointmentDbContext _dbContext;

        public FrmAddExpertByAdmin(OnlineHospitalAppointmentDbContext context)
        {
            InitializeComponent();
            _dbContext = context;
        }

        private void FrmAddExpertByAdmin_Load(object sender, EventArgs e)
        {
            ComboSpecialistType.DataSource = _dbContext.SpecialistTypes
                .Select(x => x.Specialist)
                .ToArray();

            ComboCity.DataSource = _dbContext.Cities
                .Select(x => x.Name)
                .ToArray();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            bool isUniqueUserName = IdentityHelper.IsUniqueUserName(TxtUserName.Text.ToLower());

            if (!isUniqueUserName)
            {
                MessageBox.Show("Username Already exist please try another ",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using var transaction = _dbContext.Database.BeginTransaction();
                try
                {
                    string hashPassword = PasswordHelper.HashPassword(TxtPassword.Text);

                    LoginLog loginLog = new(TxtUserName.Text, hashPassword);

                    _dbContext.LoginLogs.Add(loginLog);
                    _dbContext.SaveChanges();

                    bool isMale = RbIsMale.Checked;
                    string birthDay = DateOfBirthTimePicker.Value.Date.ToString("yyyy/MM/dd");

                    User user = new(TxtUserName.Text, TxtNationalCode.Text, TxtName.Text, TxtLastName.Text,
                        isMale, TxtPhoneNumber.Text, birthDay, (int)RoleId.Expert);

                    _dbContext.Users.Add(user);
                    _dbContext.SaveChanges();

                    string fullName = $"{user.Name} {user.LastName}";

                    int specialistTypeId = _dbContext.SpecialistTypes
                        .Where(x => x.Specialist.Equals(ComboSpecialistType.SelectedValue))
                        .Select(x => x.Id)
                        .FirstOrDefault();

                    int cityId = _dbContext.Cities
                        .Where(x => x.Name.Equals(ComboCity.SelectedValue))
                        .Select(x => x.Id)
                        .FirstOrDefault();

                    Expert expert = new(fullName, specialistTypeId, cityId, user.Id);

                    _dbContext.Experts.Add(expert);
                    _dbContext.SaveChanges();

                    string description = $"add new expert id: {expert.Id}";

                    AdminActivityLog adminActivityLog = new(user.Id, description);

                    _dbContext.AdminActivityLogs.Add(adminActivityLog);
                    _dbContext.SaveChanges();

                    BackColor = Color.Green;

                    MessageBox.Show($"Succsessfully!", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    BackColor = Color.Empty;

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }

                CleanForm();
            }
        }

        private void TxtUserName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            (bool isValid, string errorMessage) = UserInfoValidationHelper.UserNameValidation(TxtUserName.Text);

            e.Cancel = !isValid;
            ErrorProviderApp.SetError(TxtUserName, errorMessage);
        }

        private void TxtPassword_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            (bool isValid, string errorMessage) = UserInfoValidationHelper.PasswordValidation(TxtPassword.Text);

            e.Cancel = !isValid;
            ErrorProviderApp.SetError(TxtPassword, errorMessage);
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

        private void TxtNationalCode_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            (bool isValid, string errorMessage) = UserInfoValidationHelper.NationalCodeValidation(TxtNationalCode.Text);

            if (isValid)
            {
                e.Cancel = false;
                ErrorProviderApp.SetError(TxtNationalCode, string.Empty);
            }
            else
            {
                e.Cancel = true;
                ErrorProviderApp.SetError(TxtNationalCode, errorMessage);
            }
        }

        private void TxtPhoneNumber_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            (bool isValid, string errorMessage) = UserInfoValidationHelper.PhoneNumberValidation(TxtPhoneNumber.Text);
            if (isValid)
            {
                e.Cancel = false;
                ErrorProviderApp.SetError(TxtPhoneNumber, string.Empty);
            }
            else
            {
                e.Cancel = true;
                ErrorProviderApp.SetError(TxtPhoneNumber, errorMessage);
            }
        }

        private void ComboSpecialistType_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (ComboSpecialistType.SelectedValue is not null)
            {
                e.Cancel = false;
                ErrorProviderApp.SetError(ComboSpecialistType, string.Empty);
            }
            else
            {
                e.Cancel = true;
                ErrorProviderApp.SetError(ComboSpecialistType, "select type!");
            }
        }

        private void ComboCity_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (ComboCity.SelectedValue is not null)
            {
                e.Cancel = false;
                ErrorProviderApp.SetError(ComboCity, string.Empty);
            }
            else
            {
                e.Cancel = true;
                ErrorProviderApp.SetError(ComboCity, "select city!");
            }
        }

        private void CleanForm()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = string.Empty;
                }
            }
        }

        private void FrmAddExpertByAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();

            FrmAdminDashboard frmAdminDashboard = new(_dbContext);
            frmAdminDashboard.ShowDialog();
        }
    }
}