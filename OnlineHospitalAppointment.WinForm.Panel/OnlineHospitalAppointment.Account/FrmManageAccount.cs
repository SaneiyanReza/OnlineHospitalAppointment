using OnlineHospitalAppointment.Dll.Tools;
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
        private string userName;

        public FrmManageAccount()
        {
            InitializeComponent();
        }

        private void FrmManageAccount_Load(object sender, EventArgs e)
        {
            userName = FrmIdentity.userName;

            ManageAccountDto manageAccountDto = ManageAccountHelper.GetAccountData(userName);

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
                    userName
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
                    userName
                });

                BackColor = Color.Green;
                MessageBox.Show("Your Account is created . Please login now.",
                    "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BackColor = Color.Empty;
            }
            else
            {
                MessageBox.Show("Phone Number or National Code Already exist please try another ",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtNationalCode_Validating(object sender, CancelEventArgs e)
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

        private void TxtPhoneNumber_Validating(object sender, CancelEventArgs e)
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

        private void BtnAppointmentReservation_Click(object sender, EventArgs e)
        {
            FrmReservationDashboard frmReservationDashboard = new();
            fullName = $"{TxtName.Text} {TxtLastName.Text}";
            frmReservationDashboard.ShowDialog();
        }
    }
}