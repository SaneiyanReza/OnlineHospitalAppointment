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
            _dbContext = context;
            InitializeComponent();
        }

        private void FrmAddExpertByAdmin_Load(object sender, EventArgs e)
        {
            ComboSpecialistType.DataSource = _dbContext.SpecialistTypes
                .Select(x => x.Specialist)
                .ToArray();

            ComboCity.DataSource = _dbContext.Cities
                .Select(x => x.Id)
                .ToArray();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            using var transaction = _dbContext.Database.BeginTransaction();
            try
            {
                bool isMale = RbIsMale.Checked;

                User user = new(TxtUserName.Text, TxtNationalCode.Text, TxtName.Text, TxtLastName.Text,
                    isMale, TxtPhoneNumber.Text, TxtBirthDay.Text, (int)ClientRoleCode.Expert);

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

                string description = "add new expert";

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
    }
}