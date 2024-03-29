﻿namespace OnlineHospitalAppointment.WinForm.Panel.OnlineHospitalAppointment.Admin
{
    partial class FrmModifyExpert
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
            this.DateOfBirthTimePicker = new System.Windows.Forms.DateTimePicker();
            this.BtnSave = new System.Windows.Forms.Button();
            this.ComboCity = new System.Windows.Forms.ComboBox();
            this.ComboSpecialistType = new System.Windows.Forms.ComboBox();
            this.RbIsFemale = new System.Windows.Forms.RadioButton();
            this.RbIsMale = new System.Windows.Forms.RadioButton();
            this.TxtPhoneNumber = new System.Windows.Forms.TextBox();
            this.TxtNationalCode = new System.Windows.Forms.TextBox();
            this.TxtLastName = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtUserName = new System.Windows.Forms.TextBox();
            this.LblCity = new System.Windows.Forms.Label();
            this.LblSpecialistType = new System.Windows.Forms.Label();
            this.LblNationalCode = new System.Windows.Forms.Label();
            this.LblBirthDay = new System.Windows.Forms.Label();
            this.LblPhoneNumber = new System.Windows.Forms.Label();
            this.LblGender = new System.Windows.Forms.Label();
            this.LblLastName = new System.Windows.Forms.Label();
            this.LblName = new System.Windows.Forms.Label();
            this.LblUserName = new System.Windows.Forms.Label();
            this.ErrorProviderApp = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderApp)).BeginInit();
            this.SuspendLayout();
            // 
            // DateOfBirthTimePicker
            // 
            this.DateOfBirthTimePicker.Location = new System.Drawing.Point(112, 213);
            this.DateOfBirthTimePicker.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.DateOfBirthTimePicker.Name = "DateOfBirthTimePicker";
            this.DateOfBirthTimePicker.Size = new System.Drawing.Size(209, 23);
            this.DateOfBirthTimePicker.TabIndex = 34;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(87, 428);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(169, 36);
            this.BtnSave.TabIndex = 39;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // ComboCity
            // 
            this.ComboCity.FormattingEnabled = true;
            this.ComboCity.Location = new System.Drawing.Point(117, 384);
            this.ComboCity.Name = "ComboCity";
            this.ComboCity.Size = new System.Drawing.Size(204, 23);
            this.ComboCity.TabIndex = 38;
            // 
            // ComboSpecialistType
            // 
            this.ComboSpecialistType.FormattingEnabled = true;
            this.ComboSpecialistType.Location = new System.Drawing.Point(117, 337);
            this.ComboSpecialistType.Name = "ComboSpecialistType";
            this.ComboSpecialistType.Size = new System.Drawing.Size(204, 23);
            this.ComboSpecialistType.TabIndex = 37;
            // 
            // RbIsFemale
            // 
            this.RbIsFemale.AutoSize = true;
            this.RbIsFemale.Location = new System.Drawing.Point(206, 263);
            this.RbIsFemale.Name = "RbIsFemale";
            this.RbIsFemale.Size = new System.Drawing.Size(63, 19);
            this.RbIsFemale.TabIndex = 36;
            this.RbIsFemale.TabStop = true;
            this.RbIsFemale.Text = "Female";
            this.RbIsFemale.UseVisualStyleBackColor = true;
            // 
            // RbIsMale
            // 
            this.RbIsMale.AutoSize = true;
            this.RbIsMale.Location = new System.Drawing.Point(112, 263);
            this.RbIsMale.Name = "RbIsMale";
            this.RbIsMale.Size = new System.Drawing.Size(51, 19);
            this.RbIsMale.TabIndex = 35;
            this.RbIsMale.TabStop = true;
            this.RbIsMale.Text = "Male";
            this.RbIsMale.UseVisualStyleBackColor = true;
            // 
            // TxtPhoneNumber
            // 
            this.TxtPhoneNumber.Location = new System.Drawing.Point(112, 174);
            this.TxtPhoneNumber.Name = "TxtPhoneNumber";
            this.TxtPhoneNumber.Size = new System.Drawing.Size(209, 23);
            this.TxtPhoneNumber.TabIndex = 33;
            // 
            // TxtNationalCode
            // 
            this.TxtNationalCode.Location = new System.Drawing.Point(112, 132);
            this.TxtNationalCode.Name = "TxtNationalCode";
            this.TxtNationalCode.Size = new System.Drawing.Size(209, 23);
            this.TxtNationalCode.TabIndex = 32;
            // 
            // TxtLastName
            // 
            this.TxtLastName.Location = new System.Drawing.Point(112, 92);
            this.TxtLastName.Name = "TxtLastName";
            this.TxtLastName.Size = new System.Drawing.Size(209, 23);
            this.TxtLastName.TabIndex = 31;
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(112, 53);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(209, 23);
            this.TxtName.TabIndex = 30;
            // 
            // TxtUserName
            // 
            this.TxtUserName.Location = new System.Drawing.Point(112, 13);
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.Size = new System.Drawing.Size(209, 23);
            this.TxtUserName.TabIndex = 29;
            this.TxtUserName.Validating += new System.ComponentModel.CancelEventHandler(this.TxtUserName_Validating);
            // 
            // LblCity
            // 
            this.LblCity.AutoSize = true;
            this.LblCity.Location = new System.Drawing.Point(13, 384);
            this.LblCity.Name = "LblCity";
            this.LblCity.Size = new System.Drawing.Size(34, 15);
            this.LblCity.TabIndex = 28;
            this.LblCity.Text = "City :";
            // 
            // LblSpecialistType
            // 
            this.LblSpecialistType.AutoSize = true;
            this.LblSpecialistType.Location = new System.Drawing.Point(12, 337);
            this.LblSpecialistType.Name = "LblSpecialistType";
            this.LblSpecialistType.Size = new System.Drawing.Size(89, 15);
            this.LblSpecialistType.TabIndex = 27;
            this.LblSpecialistType.Text = "Specialist Type :";
            // 
            // LblNationalCode
            // 
            this.LblNationalCode.AutoSize = true;
            this.LblNationalCode.Location = new System.Drawing.Point(12, 138);
            this.LblNationalCode.Name = "LblNationalCode";
            this.LblNationalCode.Size = new System.Drawing.Size(89, 15);
            this.LblNationalCode.TabIndex = 26;
            this.LblNationalCode.Text = "National Code :";
            // 
            // LblBirthDay
            // 
            this.LblBirthDay.AutoSize = true;
            this.LblBirthDay.Location = new System.Drawing.Point(12, 219);
            this.LblBirthDay.Name = "LblBirthDay";
            this.LblBirthDay.Size = new System.Drawing.Size(61, 15);
            this.LblBirthDay.TabIndex = 25;
            this.LblBirthDay.Text = "Birth Day :";
            // 
            // LblPhoneNumber
            // 
            this.LblPhoneNumber.AutoSize = true;
            this.LblPhoneNumber.Location = new System.Drawing.Point(12, 177);
            this.LblPhoneNumber.Name = "LblPhoneNumber";
            this.LblPhoneNumber.Size = new System.Drawing.Size(94, 15);
            this.LblPhoneNumber.TabIndex = 24;
            this.LblPhoneNumber.Text = "Phone Number :";
            // 
            // LblGender
            // 
            this.LblGender.AutoSize = true;
            this.LblGender.Location = new System.Drawing.Point(12, 263);
            this.LblGender.Name = "LblGender";
            this.LblGender.Size = new System.Drawing.Size(51, 15);
            this.LblGender.TabIndex = 23;
            this.LblGender.Text = "Gender :";
            // 
            // LblLastName
            // 
            this.LblLastName.AutoSize = true;
            this.LblLastName.Location = new System.Drawing.Point(12, 98);
            this.LblLastName.Name = "LblLastName";
            this.LblLastName.Size = new System.Drawing.Size(69, 15);
            this.LblLastName.TabIndex = 22;
            this.LblLastName.Text = "Last Name :";
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(12, 56);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(45, 15);
            this.LblName.TabIndex = 21;
            this.LblName.Text = "Name :";
            // 
            // LblUserName
            // 
            this.LblUserName.AutoSize = true;
            this.LblUserName.Location = new System.Drawing.Point(12, 19);
            this.LblUserName.Name = "LblUserName";
            this.LblUserName.Size = new System.Drawing.Size(71, 15);
            this.LblUserName.TabIndex = 20;
            this.LblUserName.Text = "UserName : ";
            // 
            // ErrorProviderApp
            // 
            this.ErrorProviderApp.ContainerControl = this;
            // 
            // FrmModifyExpert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(344, 473);
            this.Controls.Add(this.DateOfBirthTimePicker);
            this.Controls.Add(this.BtnSave);
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
            this.MaximizeBox = false;
            this.Name = "FrmModifyExpert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmModifyExpertByAdmin";
            this.Load += new System.EventHandler(this.FrmModifyExpertByAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderApp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateTimePicker DateOfBirthTimePicker;
        private Button BtnSave;
        private ComboBox ComboCity;
        private ComboBox ComboSpecialistType;
        private RadioButton RbIsFemale;
        private RadioButton RbIsMale;
        private TextBox TxtPhoneNumber;
        private TextBox TxtNationalCode;
        private TextBox TxtLastName;
        private TextBox TxtName;
        private TextBox TxtUserName;
        private Label LblCity;
        private Label LblSpecialistType;
        private Label LblNationalCode;
        private Label LblBirthDay;
        private Label LblPhoneNumber;
        private Label LblGender;
        private Label LblLastName;
        private Label LblName;
        private Label LblUserName;
        private ErrorProvider ErrorProviderApp;
    }
}