namespace OnlineHospitalAppointment.WinForm.Panel.OnlineHospitalAppointment.Identity
{
    partial class FrmRegistration
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
            this.LblNationalCode = new System.Windows.Forms.Label();
            this.LblName = new System.Windows.Forms.Label();
            this.LblLastName = new System.Windows.Forms.Label();
            this.LblBirthDay = new System.Windows.Forms.Label();
            this.LblGender = new System.Windows.Forms.Label();
            this.LblPhoneNumber = new System.Windows.Forms.Label();
            this.TxtNationalCode = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtLastName = new System.Windows.Forms.TextBox();
            this.TxtPhoneNumber = new System.Windows.Forms.TextBox();
            this.BtnSubmit = new System.Windows.Forms.Button();
            this.RbIsMale = new System.Windows.Forms.RadioButton();
            this.DateOfBirthTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ErrorProviderApp = new System.Windows.Forms.ErrorProvider(this.components);
            this.RbIsFemale = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderApp)).BeginInit();
            this.SuspendLayout();
            // 
            // LblNationalCode
            // 
            this.LblNationalCode.AutoSize = true;
            this.LblNationalCode.Location = new System.Drawing.Point(13, 24);
            this.LblNationalCode.Name = "LblNationalCode";
            this.LblNationalCode.Size = new System.Drawing.Size(80, 15);
            this.LblNationalCode.TabIndex = 0;
            this.LblNationalCode.Text = "NationalCode";
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(13, 64);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(39, 15);
            this.LblName.TabIndex = 1;
            this.LblName.Text = "Name";
            // 
            // LblLastName
            // 
            this.LblLastName.AutoSize = true;
            this.LblLastName.Location = new System.Drawing.Point(13, 104);
            this.LblLastName.Name = "LblLastName";
            this.LblLastName.Size = new System.Drawing.Size(60, 15);
            this.LblLastName.TabIndex = 2;
            this.LblLastName.Text = "LastName";
            // 
            // LblBirthDay
            // 
            this.LblBirthDay.AutoSize = true;
            this.LblBirthDay.Location = new System.Drawing.Point(13, 145);
            this.LblBirthDay.Name = "LblBirthDay";
            this.LblBirthDay.Size = new System.Drawing.Size(52, 15);
            this.LblBirthDay.TabIndex = 3;
            this.LblBirthDay.Text = "BirthDay";
            // 
            // LblGender
            // 
            this.LblGender.AutoSize = true;
            this.LblGender.Location = new System.Drawing.Point(13, 228);
            this.LblGender.Name = "LblGender";
            this.LblGender.Size = new System.Drawing.Size(45, 15);
            this.LblGender.TabIndex = 5;
            this.LblGender.Text = "Gender";
            // 
            // LblPhoneNumber
            // 
            this.LblPhoneNumber.AutoSize = true;
            this.LblPhoneNumber.Location = new System.Drawing.Point(13, 188);
            this.LblPhoneNumber.Name = "LblPhoneNumber";
            this.LblPhoneNumber.Size = new System.Drawing.Size(85, 15);
            this.LblPhoneNumber.TabIndex = 4;
            this.LblPhoneNumber.Text = "PhoneNumber";
            // 
            // TxtNationalCode
            // 
            this.TxtNationalCode.Location = new System.Drawing.Point(111, 21);
            this.TxtNationalCode.Name = "TxtNationalCode";
            this.TxtNationalCode.Size = new System.Drawing.Size(209, 23);
            this.TxtNationalCode.TabIndex = 6;
            this.TxtNationalCode.Validating += new System.ComponentModel.CancelEventHandler(this.TxtNationalCode_Validating);
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(111, 61);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(209, 23);
            this.TxtName.TabIndex = 7;
            // 
            // TxtLastName
            // 
            this.TxtLastName.Location = new System.Drawing.Point(111, 101);
            this.TxtLastName.Name = "TxtLastName";
            this.TxtLastName.Size = new System.Drawing.Size(209, 23);
            this.TxtLastName.TabIndex = 8;
            // 
            // TxtPhoneNumber
            // 
            this.TxtPhoneNumber.Location = new System.Drawing.Point(111, 188);
            this.TxtPhoneNumber.Name = "TxtPhoneNumber";
            this.TxtPhoneNumber.Size = new System.Drawing.Size(209, 23);
            this.TxtPhoneNumber.TabIndex = 10;
            this.TxtPhoneNumber.Validating += new System.ComponentModel.CancelEventHandler(this.TxtPhoneNumber_Validating);
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.Location = new System.Drawing.Point(207, 260);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(113, 39);
            this.BtnSubmit.TabIndex = 12;
            this.BtnSubmit.Text = "Submit";
            this.BtnSubmit.UseVisualStyleBackColor = true;
            this.BtnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // RbIsMale
            // 
            this.RbIsMale.AutoSize = true;
            this.RbIsMale.Location = new System.Drawing.Point(111, 228);
            this.RbIsMale.Name = "RbIsMale";
            this.RbIsMale.Size = new System.Drawing.Size(59, 19);
            this.RbIsMale.TabIndex = 11;
            this.RbIsMale.TabStop = true;
            this.RbIsMale.Text = "IsMale";
            this.RbIsMale.UseVisualStyleBackColor = true;
            // 
            // DateOfBirthTimePicker
            // 
            this.DateOfBirthTimePicker.Location = new System.Drawing.Point(111, 139);
            this.DateOfBirthTimePicker.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.DateOfBirthTimePicker.Name = "DateOfBirthTimePicker";
            this.DateOfBirthTimePicker.Size = new System.Drawing.Size(209, 23);
            this.DateOfBirthTimePicker.TabIndex = 9;
            // 
            // ErrorProviderApp
            // 
            this.ErrorProviderApp.ContainerControl = this;
            // 
            // RbIsFemale
            // 
            this.RbIsFemale.AutoSize = true;
            this.RbIsFemale.Location = new System.Drawing.Point(193, 228);
            this.RbIsFemale.Name = "RbIsFemale";
            this.RbIsFemale.Size = new System.Drawing.Size(71, 19);
            this.RbIsFemale.TabIndex = 13;
            this.RbIsFemale.TabStop = true;
            this.RbIsFemale.Text = "IsFemale";
            this.RbIsFemale.UseVisualStyleBackColor = true;
            // 
            // FrmRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 311);
            this.Controls.Add(this.RbIsFemale);
            this.Controls.Add(this.DateOfBirthTimePicker);
            this.Controls.Add(this.RbIsMale);
            this.Controls.Add(this.BtnSubmit);
            this.Controls.Add(this.TxtPhoneNumber);
            this.Controls.Add(this.TxtLastName);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.TxtNationalCode);
            this.Controls.Add(this.LblPhoneNumber);
            this.Controls.Add(this.LblGender);
            this.Controls.Add(this.LblBirthDay);
            this.Controls.Add(this.LblLastName);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.LblNationalCode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRegistration";
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderApp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LblNationalCode;
        private Label LblName;
        private Label LblLastName;
        private Label LblBirthDay;
        private Label LblGender;
        private Label LblPhoneNumber;
        private TextBox TxtNationalCode;
        private TextBox TxtName;
        private TextBox TxtLastName;
        private TextBox TxtPhoneNumber;
        private Button BtnSubmit;
        private RadioButton RbIsMale;
        private DateTimePicker DateOfBirthTimePicker;
        private ErrorProvider ErrorProviderApp;
        private RadioButton RbIsFemale;
    }
}