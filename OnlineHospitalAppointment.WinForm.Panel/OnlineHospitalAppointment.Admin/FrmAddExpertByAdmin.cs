using OnlineHospitalAppointment.Dll.Tools.Helpers;
using OnlineHospitalAppointment.WinForm.Panel.Models;
using OnlineHospitalAppointment.WinForm.Panel.OnlineHospitalAppointment.Identity.Enums;
using System.Text.RegularExpressions;

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
            using var transaction = _dbContext.Database.BeginTransaction();
            try
            {
                bool isMale = RbIsMale.Checked;
                string birthDay = DateOfBirthTimePicker.Value.Date.ToString("yyyy/MM/dd");

                User user = new(TxtUserName.Text, TxtNationalCode.Text, TxtName.Text, TxtLastName.Text,
                    isMale, TxtPhoneNumber.Text, birthDay, (int)RoleId.Expert);

                _dbContext.Users.Add(user);
                _dbContext.SaveChanges();

                string fullName = $"{user.Name} {user.LastName}";

                int specialistTypeId = _dbContext.SpecialistTypes
                    .Where(x => x.Specialist.Equals(ComboSpecialistType.SelectedText))
                    .Select(x => x.Id)
                    .FirstOrDefault();

                int cityId = _dbContext.Cities
                    .Where(x => x.Name.Equals(ComboCity.SelectedText))
                    .Select(x => x.Id)
                    .FirstOrDefault();

                Expert expert = new(fullName, specialistTypeId, cityId, user.Id);

                _dbContext.Experts.Add(expert);

                string description = $"add new expert id: {expert.Id}";

                AdminActivityLog adminActivityLog = new(user.Id, description);

                _dbContext.AdminActivityLogs.Add(adminActivityLog);
                _dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void TxtUserName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            int usernameLength = TxtUserName.Text.Length;

            if (usernameLength < 4 || usernameLength > 50)
            {
                e.Cancel = true;
                ErrorProviderApp.SetError(TxtUserName, "username must between 4 to 50 char");
            }
            else if (!Regex.IsMatch(TxtUserName.Text, "^[a-zA-Z0-9_]+$"))
            {
                e.Cancel = true;
                ErrorProviderApp.SetError(TxtUserName, "username must contain a-z , A-Z , 0-9 , _");
            }
            else
            {
                e.Cancel = false;
                ErrorProviderApp.SetError(TxtUserName, string.Empty);
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
            if (ComboSpecialistType.GetItemText == null)
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
            if (ComboCity.GetItemText == null)
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
    }
}