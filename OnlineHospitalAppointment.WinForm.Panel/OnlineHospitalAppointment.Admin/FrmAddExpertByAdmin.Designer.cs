﻿namespace OnlineHospitalAppointment.WinForm.Panel.OnlineHospitalAppointment.Admin
{
    partial class FrmAddExpertByAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.LblUserName = new System.Windows.Forms.Label();
            this.LblName = new System.Windows.Forms.Label();
            this.LblLastName = new System.Windows.Forms.Label();
            this.LblGender = new System.Windows.Forms.Label();
            this.LblPhoneNumber = new System.Windows.Forms.Label();
            this.LblBirthDay = new System.Windows.Forms.Label();
            this.LblNationalCode = new System.Windows.Forms.Label();
            this.LblSpecialistType = new System.Windows.Forms.Label();
            this.LblCity = new System.Windows.Forms.Label();
            this.TxtUserName = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtLastName = new System.Windows.Forms.TextBox();
            this.TxtNationalCode = new System.Windows.Forms.TextBox();
            this.TxtPhoneNumber = new System.Windows.Forms.TextBox();
            this.RbIsMale = new System.Windows.Forms.RadioButton();
            this.RbIsFemale = new System.Windows.Forms.RadioButton();
            this.ComboSpecialistType = new System.Windows.Forms.ComboBox();
            this.ComboCity = new System.Windows.Forms.ComboBox();
            this.BtnSubmit = new System.Windows.Forms.Button();
            this.ErrorProviderApp = new System.Windows.Forms.ErrorProvider(this.components);
            this.DateOfBirthTimePicker = new System.Windows.Forms.DateTimePicker();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.LblPassword = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderApp)).BeginInit();
            this.SuspendLayout();
            // 
            // LblUserName
            // 
            this.LblUserName.AutoSize = true;
            this.LblUserName.Location = new System.Drawing.Point(12, 19);
            this.LblUserName.Name = "LblUserName";
            this.LblUserName.Size = new System.Drawing.Size(71, 15);
            this.LblUserName.TabIndex = 0;
            this.LblUserName.Text = "UserName : ";
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(12, 90);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(45, 15);
            this.LblName.TabIndex = 1;
            this.LblName.Text = "Name :";
            // 
            // LblLastName
            // 
            this.LblLastName.AutoSize = true;
            this.LblLastName.Location = new System.Drawing.Point(12, 132);
            this.LblLastName.Name = "LblLastName";
            this.LblLastName.Size = new System.Drawing.Size(69, 15);
            this.LblLastName.TabIndex = 2;
            this.LblLastName.Text = "Last Name :";
            // 
            // LblGender
            // 
            this.LblGender.AutoSize = true;
            this.LblGender.Location = new System.Drawing.Point(12, 297);
            this.LblGender.Name = "LblGender";
            this.LblGender.Size = new System.Drawing.Size(51, 15);
            this.LblGender.TabIndex = 3;
            this.LblGender.Text = "Gender :";
            // 
            // LblPhoneNumber
            // 
            this.LblPhoneNumber.AutoSize = true;
            this.LblPhoneNumber.Location = new System.Drawing.Point(12, 211);
            this.LblPhoneNumber.Name = "LblPhoneNumber";
            this.LblPhoneNumber.Size = new System.Drawing.Size(94, 15);
            this.LblPhoneNumber.TabIndex = 4;
            this.LblPhoneNumber.Text = "Phone Number :";
            // 
            // LblBirthDay
            // 
            this.LblBirthDay.AutoSize = true;
            this.LblBirthDay.Location = new System.Drawing.Point(12, 253);
            this.LblBirthDay.Name = "LblBirthDay";
            this.LblBirthDay.Size = new System.Drawing.Size(61, 15);
            this.LblBirthDay.TabIndex = 5;
            this.LblBirthDay.Text = "Birth Day :";
            // 
            // LblNationalCode
            // 
            this.LblNationalCode.AutoSize = true;
            this.LblNationalCode.Location = new System.Drawing.Point(12, 172);
            this.LblNationalCode.Name = "LblNationalCode";
            this.LblNationalCode.Size = new System.Drawing.Size(89, 15);
            this.LblNationalCode.TabIndex = 6;
            this.LblNationalCode.Text = "National Code :";
            // 
            // LblSpecialistType
            // 
            this.LblSpecialistType.AutoSize = true;
            this.LblSpecialistType.Location = new System.Drawing.Point(12, 371);
            this.LblSpecialistType.Name = "LblSpecialistType";
            this.LblSpecialistType.Size = new System.Drawing.Size(89, 15);
            this.LblSpecialistType.TabIndex = 7;
            this.LblSpecialistType.Text = "Specialist Type :";
            // 
            // LblCity
            // 
            this.LblCity.AutoSize = true;
            this.LblCity.Location = new System.Drawing.Point(13, 418);
            this.LblCity.Name = "LblCity";
            this.LblCity.Size = new System.Drawing.Size(34, 15);
            this.LblCity.TabIndex = 8;
            this.LblCity.Text = "City :";
            // 
            // TxtUserName
            // 
            this.TxtUserName.Location = new System.Drawing.Point(112, 13);
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.Size = new System.Drawing.Size(209, 23);
            this.TxtUserName.TabIndex = 9;
            this.TxtUserName.Validating += new System.ComponentModel.CancelEventHandler(this.TxtUserName_Validating);
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(112, 87);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(209, 23);
            this.TxtName.TabIndex = 11;
            this.TxtName.Validating += new System.ComponentModel.CancelEventHandler(this.TxtName_Validating);
            // 
            // TxtLastName
            // 
            this.TxtLastName.Location = new System.Drawing.Point(112, 126);
            this.TxtLastName.Name = "TxtLastName";
            this.TxtLastName.Size = new System.Drawing.Size(209, 23);
            this.TxtLastName.TabIndex = 12;
            this.TxtLastName.Validating += new System.ComponentModel.CancelEventHandler(this.TxtLastName_Validating);
            // 
            // TxtNationalCode
            // 
            this.TxtNationalCode.Location = new System.Drawing.Point(112, 166);
            this.TxtNationalCode.Name = "TxtNationalCode";
            this.TxtNationalCode.Size = new System.Drawing.Size(209, 23);
            this.TxtNationalCode.TabIndex = 13;
            this.TxtNationalCode.Validating += new System.ComponentModel.CancelEventHandler(this.TxtNationalCode_Validating);
            // 
            // TxtPhoneNumber
            // 
            this.TxtPhoneNumber.Location = new System.Drawing.Point(112, 208);
            this.TxtPhoneNumber.Name = "TxtPhoneNumber";
            this.TxtPhoneNumber.Size = new System.Drawing.Size(209, 23);
            this.TxtPhoneNumber.TabIndex = 14;
            this.TxtPhoneNumber.Validating += new System.ComponentModel.CancelEventHandler(this.TxtPhoneNumber_Validating);
            // 
            // RbIsMale
            // 
            this.RbIsMale.AutoSize = true;
            this.RbIsMale.Location = new System.Drawing.Point(112, 297);
            this.RbIsMale.Name = "RbIsMale";
            this.RbIsMale.Size = new System.Drawing.Size(51, 19);
            this.RbIsMale.TabIndex = 16;
            this.RbIsMale.TabStop = true;
            this.RbIsMale.Text = "Male";
            this.RbIsMale.UseVisualStyleBackColor = true;
            // 
            // RbIsFemale
            // 
            this.RbIsFemale.AutoSize = true;
            this.RbIsFemale.Location = new System.Drawing.Point(206, 297);
            this.RbIsFemale.Name = "RbIsFemale";
            this.RbIsFemale.Size = new System.Drawing.Size(63, 19);
            this.RbIsFemale.TabIndex = 17;
            this.RbIsFemale.TabStop = true;
            this.RbIsFemale.Text = "Female";
            this.RbIsFemale.UseVisualStyleBackColor = true;
            // 
            // ComboSpecialistType
            // 
            this.ComboSpecialistType.FormattingEnabled = true;
            this.ComboSpecialistType.Location = new System.Drawing.Point(117, 371);
            this.ComboSpecialistType.Name = "ComboSpecialistType";
            this.ComboSpecialistType.Size = new System.Drawing.Size(204, 23);
            this.ComboSpecialistType.TabIndex = 18;
            this.ComboSpecialistType.Validating += new System.ComponentModel.CancelEventHandler(this.ComboSpecialistType_Validating);
            // 
            // ComboCity
            // 
            this.ComboCity.FormattingEnabled = true;
            this.ComboCity.Location = new System.Drawing.Point(117, 418);
            this.ComboCity.Name = "ComboCity";
            this.ComboCity.Size = new System.Drawing.Size(204, 23);
            this.ComboCity.TabIndex = 19;
            this.ComboCity.Validating += new System.ComponentModel.CancelEventHandler(this.ComboCity_Validating);
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.Location = new System.Drawing.Point(87, 462);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(169, 36);
            this.BtnSubmit.TabIndex = 20;
            this.BtnSubmit.Text = "Submit";
            this.BtnSubmit.UseVisualStyleBackColor = true;
            this.BtnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // ErrorProviderApp
            // 
            this.ErrorProviderApp.ContainerControl = this;
            // 
            // DateOfBirthTimePicker
            // 
            this.DateOfBirthTimePicker.Location = new System.Drawing.Point(112, 247);
            this.DateOfBirthTimePicker.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.DateOfBirthTimePicker.Name = "DateOfBirthTimePicker";
            this.DateOfBirthTimePicker.Size = new System.Drawing.Size(209, 23);
            this.DateOfBirthTimePicker.TabIndex = 15;
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(112, 51);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(209, 23);
            this.TxtPassword.TabIndex = 10;
            this.TxtPassword.Validating += new System.ComponentModel.CancelEventHandler(this.TxtPassword_Validating);
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.Location = new System.Drawing.Point(10, 54);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(66, 15);
            this.LblPassword.TabIndex = 20;
            this.LblPassword.Text = "Password : ";
            // 
            // FrmAddExpertByAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(339, 512);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.LblPassword);
            this.Controls.Add(this.DateOfBirthTimePicker);
            this.Controls.Add(this.BtnSubmit);
            this.Controls.Add(this.ComboCity);
            this.Controls.Add(this.ComboSpecialistType);
            this.Controls.Add(this.RbIsFemale);
            this.Controls.Add(this.RbIsMale);
            this.Controls.Add(this.TxtPhoneNumber);
            this.Controls.Add(this.TxtNationalCode);
            this.Controls.Add(this.TxtLastName);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.TxtUserName);
            this.Controls.Add(this.LblCity);
            this.Controls.Add(this.LblSpecialistType);
            this.Controls.Add(this.LblNationalCode);
            this.Controls.Add(this.LblBirthDay);
            this.Controls.Add(this.LblPhoneNumber);
            this.Controls.Add(this.LblGender);
            this.Controls.Add(this.LblLastName);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.LblUserName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmAddExpertByAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAddExpertByAdmin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAddExpertByAdmin_FormClosing);
            this.Load += new System.EventHandler(this.FrmAddExpertByAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderApp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LblUserName;
        private Label LblName;
        private Label LblLastName;
        private Label LblGender;
        private Label LblPhoneNumber;
        private Label LblBirthDay;
        private Label LblNationalCode;
        private Label LblSpecialistType;
        private Label LblCity;
        private TextBox TxtUserName;
        private TextBox TxtName;
        private TextBox TxtLastName;
        private TextBox TxtNationalCode;
        private TextBox TxtPhoneNumber;
        private RadioButton RbIsMale;
        private RadioButton RbIsFemale;
        private ComboBox ComboSpecialistType;
        private ComboBox ComboCity;
        private Button BtnSubmit;
        private ErrorProvider ErrorProviderApp;
        private DateTimePicker DateOfBirthTimePicker;
        private TextBox TxtPassword;
        private Label LblPassword;
    }
}