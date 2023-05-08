﻿using OnlineHospitalAppointment.Dll.Tools;
using OnlineHospitalAppointment.WinForm.Panel.OnlineHospitalAppointment.Account.Helper;
using OnlineHospitalAppointment.WinForm.Panel.OnlineHospitalAppointment.Account.Models;
using OnlineHospitalAppointment.WinForm.Panel.OnlineHospitalAppointment.Identity;
using System.ComponentModel;

namespace OnlineHospitalAppointment.WinForm.Panel.OnlineHospitalAppointment.Account
{
    public partial class FrmManageAccount : Form
    {
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
            RbIsMale.Checked = manageAccountDto.Gender;
            RbIsFemale.Checked = !manageAccountDto.Gender;
            TxtPhoneNumber.Text = manageAccountDto.PhoneNumber;
            DateOfBirthTimePicker.Text = manageAccountDto.BirthDay;
        }

        private void BtnEditProfile_Click(object sender, EventArgs e)
        {
            if ((TxtName.Text.Length < 3 || TxtName.Text.Length > 50) ||
                (TxtLastName.Text.Length < 4 || TxtLastName.Text.Length > 50))
            {
                MessageBox.Show("Please Enter currect value");
            }
            else
            {
                DapperHelper.ExecuteNonQuery(ManageAccountScripts.UpdateUserAccountScript, new
                {
                    NationalCode = TxtNationalCode.Text,
                    Name = TxtName.Text,
                    LastName = TxtLastName.Text,
                    BirthDay = DateOfBirthTimePicker.Value.ToString("yyyy/mm/dd"),
                    Gender = RbIsMale.Checked ? 1 : 0,
                    PhoneNumber = TxtPhoneNumber.Text,
                    userName
                });

                BackColor = Color.Green;
                MessageBox.Show("Your Account is created . Please login now.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                ErrorProviderApp.SetError(TxtNationalCode, "");
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
                ErrorProviderApp.SetError(TxtPhoneNumber, "");
            }
        }
    }
}