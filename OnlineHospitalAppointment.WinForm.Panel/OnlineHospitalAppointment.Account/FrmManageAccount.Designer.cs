namespace OnlineHospitalAppointment.WinForm.Panel.OnlineHospitalAppointment.Account
{
    partial class FrmManageAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmManageAccount));
            this.ErrorProviderApp = new System.Windows.Forms.ErrorProvider(this.components);
            this.TxtNationalCode = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtPhoneNumber = new System.Windows.Forms.TextBox();
            this.RbIsMale = new System.Windows.Forms.RadioButton();
            this.DateOfBirthTimePicker = new System.Windows.Forms.DateTimePicker();
            this.TxtLastName = new System.Windows.Forms.TextBox();
            this.LblNationalCode = new System.Windows.Forms.Label();
            this.LblName = new System.Windows.Forms.Label();
            this.LblLastName = new System.Windows.Forms.Label();
            this.LblBirthDay = new System.Windows.Forms.Label();
            this.LblPhoneNumber = new System.Windows.Forms.Label();
            this.LblGender = new System.Windows.Forms.Label();
            this.BtnAppointmentReservation = new System.Windows.Forms.Button();
            this.BtnEditProfile = new System.Windows.Forms.Button();
            this.RbIsFemale = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderApp)).BeginInit();
            this.SuspendLayout();
            // 
            // ErrorProviderApp
            // 
            this.ErrorProviderApp.ContainerControl = this;
            // 
            // TxtNationalCode
            // 
            resources.ApplyResources(this.TxtNationalCode, "TxtNationalCode");
            this.TxtNationalCode.Name = "TxtNationalCode";
            this.TxtNationalCode.Validating += new System.ComponentModel.CancelEventHandler(this.TxtNationalCode_Validating);
            // 
            // TxtName
            // 
            resources.ApplyResources(this.TxtName, "TxtName");
            this.TxtName.Name = "TxtName";
            // 
            // TxtPhoneNumber
            // 
            resources.ApplyResources(this.TxtPhoneNumber, "TxtPhoneNumber");
            this.TxtPhoneNumber.Name = "TxtPhoneNumber";
            this.TxtPhoneNumber.Validating += new System.ComponentModel.CancelEventHandler(this.TxtPhoneNumber_Validating);
            // 
            // RbIsMale
            // 
            resources.ApplyResources(this.RbIsMale, "RbIsMale");
            this.RbIsMale.Checked = true;
            this.RbIsMale.Name = "RbIsMale";
            this.RbIsMale.TabStop = true;
            this.RbIsMale.UseVisualStyleBackColor = true;
            // 
            // DateOfBirthTimePicker
            // 
            resources.ApplyResources(this.DateOfBirthTimePicker, "DateOfBirthTimePicker");
            this.DateOfBirthTimePicker.Name = "DateOfBirthTimePicker";
            // 
            // TxtLastName
            // 
            resources.ApplyResources(this.TxtLastName, "TxtLastName");
            this.TxtLastName.Name = "TxtLastName";
            // 
            // LblNationalCode
            // 
            resources.ApplyResources(this.LblNationalCode, "LblNationalCode");
            this.LblNationalCode.Name = "LblNationalCode";
            // 
            // LblName
            // 
            resources.ApplyResources(this.LblName, "LblName");
            this.LblName.Name = "LblName";
            // 
            // LblLastName
            // 
            resources.ApplyResources(this.LblLastName, "LblLastName");
            this.LblLastName.Name = "LblLastName";
            // 
            // LblBirthDay
            // 
            resources.ApplyResources(this.LblBirthDay, "LblBirthDay");
            this.LblBirthDay.Name = "LblBirthDay";
            // 
            // LblPhoneNumber
            // 
            resources.ApplyResources(this.LblPhoneNumber, "LblPhoneNumber");
            this.LblPhoneNumber.Name = "LblPhoneNumber";
            // 
            // LblGender
            // 
            resources.ApplyResources(this.LblGender, "LblGender");
            this.LblGender.Name = "LblGender";
            // 
            // BtnAppointmentReservation
            // 
            this.BtnAppointmentReservation.BackColor = System.Drawing.SystemColors.Info;
            resources.ApplyResources(this.BtnAppointmentReservation, "BtnAppointmentReservation");
            this.BtnAppointmentReservation.Name = "BtnAppointmentReservation";
            this.BtnAppointmentReservation.UseVisualStyleBackColor = false;
            this.BtnAppointmentReservation.Click += new System.EventHandler(this.BtnAppointmentReservation_Click);
            // 
            // BtnEditProfile
            // 
            this.BtnEditProfile.BackColor = System.Drawing.SystemColors.Info;
            resources.ApplyResources(this.BtnEditProfile, "BtnEditProfile");
            this.BtnEditProfile.Name = "BtnEditProfile";
            this.BtnEditProfile.UseVisualStyleBackColor = false;
            this.BtnEditProfile.Click += new System.EventHandler(this.BtnEditProfile_Click);
            // 
            // RbIsFemale
            // 
            resources.ApplyResources(this.RbIsFemale, "RbIsFemale");
            this.RbIsFemale.Name = "RbIsFemale";
            this.RbIsFemale.UseVisualStyleBackColor = true;
            // 
            // FrmManageAccount
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RbIsFemale);
            this.Controls.Add(this.BtnEditProfile);
            this.Controls.Add(this.BtnAppointmentReservation);
            this.Controls.Add(this.LblGender);
            this.Controls.Add(this.LblPhoneNumber);
            this.Controls.Add(this.LblBirthDay);
            this.Controls.Add(this.LblLastName);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.LblNationalCode);
            this.Controls.Add(this.TxtLastName);
            this.Controls.Add(this.DateOfBirthTimePicker);
            this.Controls.Add(this.RbIsMale);
            this.Controls.Add(this.TxtPhoneNumber);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.TxtNationalCode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmManageAccount";
            this.Load += new System.EventHandler(this.FrmManageAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderApp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ErrorProvider ErrorProviderApp;
        private DateTimePicker DateOfBirthTimePicker;
        private RadioButton RbIsMale;
        private TextBox TxtPhoneNumber;
        private TextBox TxtName;
        private TextBox TxtNationalCode;
        private TextBox TxtLastName;
        private Label LblGender;
        private Label LblPhoneNumber;
        private Label LblBirthDay;
        private Label LblLastName;
        private Label LblName;
        private Label LblNationalCode;
        private Button BtnEditProfile;
        private Button BtnAppointmentReservation;
        private RadioButton RbIsFemale;
    }
}