using OnlineHospitalAppointment.Dll.Tools.Helpers;
using OnlineHospitalAppointment.WinForm.Panel.OnlineHospitalAppointment.Account.Helper;
using OnlineHospitalAppointment.WinForm.Panel.OnlineHospitalAppointment.Account.Models;
using OnlineHospitalAppointment.WinForm.Panel.OnlineHospitalAppointment.Identity;
using OnlineHospitalAppointment.WinForm.Panel.OnlineHospitalAppointment.Panel;
using System.ComponentModel;

namespace OnlineHospitalAppointment.WinForm.Panel.OnlineHospitalAppointment.Account
{
    public partial class FrmManageAccount : Form
    {
        public static string fullName;
        private static int userId;

        private readonly OnlineHospitalAppointmentDbContext _dbContext;

        public FrmManageAccount(OnlineHospitalAppointmentDbContext dbContext)
        {
            InitializeComponent();
            _dbContext = dbContext;
        }

        private void FrmManageAccount_Load(object sender, EventArgs e)
        {
            userId = FrmIdentity.userId;

            ManageAccountDto manageAccountDto = ManageAccountHelper.GetAccountData(userId);

            TxtNationalCode.Text = manageAccountDto.NationalCode;
            TxtName.Text = manageAccountDto.Name;
            TxtLastName.Text = manageAccountDto.LastName;
            RbIsMale.Checked = manageAccountDto.IsMale;
            RbIsFemale.Checked = !manageAccountDto.IsMale;
            TxtPhoneNumber.Text = manageAccountDto.PhoneNumber;
            DateOfBirthTimePicker.Text = manageAccountDto.BirthDay;
        }

        private void BtnEditProfile_Click(object sender, EventArgs e)
        {
            if ((TxtName.Text.Length < 3 || TxtName.Text.Length > 50) ||
                (TxtLastName.Text.Length < 4 || TxtLastName.Text.Length > 50))
            {
                MessageBox.Show("Please Enter currect value", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string result = DapperHelper
                .QueryFirstOrDefault<string>(IdentityScripts.IsUniqueUser, new
                {
                    NationalCode = TxtNationalCode.Text,
                    PhoneNumber = TxtPhoneNumber.Text,
                    userId
                });

            if (result is null)
            {
                DapperHelper.ExecuteNonQuery(ManageAccountScripts.UpdateUserAccountScript, new
                {
                    NationalCode = TxtNationalCode.Text,
                    Name = TxtName.Text,
                    LastName = TxtLastName.Text,
                    BirthDay = DateOfBirthTimePicker.Value.Date.ToString("yyyy/MM/dd"),
                    IsMale = RbIsMale.Checked ? 1 : 0,
                    PhoneNumber = TxtPhoneNumber.Text,
                    userId
                });

                BackColor = Color.Green;
                MessageBox.Show("Your account has been updated.",
                    "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BackColor = Color.Empty;
            }
            else
            {
                MessageBox.Show("Phone Number or National Code Already exist please try another ",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAppointmentReservation_Click(object sender, EventArgs e)
        {
            FrmReservationDashboard frmReservationDashboard = new(_dbContext);
            fullName = $"{TxtName.Text} {TxtLastName.Text}";
            this.Close();
            frmReservationDashboard.ShowDialog();
        }

        private void TxtNationalCode_Validating(object sender, CancelEventArgs e)
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

        private void TxtPhoneNumber_Validating(object sender, CancelEventArgs e)
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
    }
}