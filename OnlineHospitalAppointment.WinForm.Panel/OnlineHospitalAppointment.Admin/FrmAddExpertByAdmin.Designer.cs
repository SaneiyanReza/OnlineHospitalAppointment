namespace OnlineHospitalAppointment.WinForm.Panel.OnlineHospitalAppointment.Admin
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
            this.LblUserName = new System.Windows.Forms.Label();
            this.LblName = new System.Windows.Forms.Label();
            this.LblLastName = new System.Windows.Forms.Label();
            this.LblIsMale = new System.Windows.Forms.Label();
            this.LblPhoneNumber = new System.Windows.Forms.Label();
            this.LblBirthDay = new System.Windows.Forms.Label();
            this.LblNationalCode = new System.Windows.Forms.Label();
            this.LblSpecialistType = new System.Windows.Forms.Label();
            this.LblCity = new System.Windows.Forms.Label();
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
            this.LblName.Location = new System.Drawing.Point(12, 56);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(45, 15);
            this.LblName.TabIndex = 1;
            this.LblName.Text = "Name :";
            // 
            // LblLastName
            // 
            this.LblLastName.AutoSize = true;
            this.LblLastName.Location = new System.Drawing.Point(12, 98);
            this.LblLastName.Name = "LblLastName";
            this.LblLastName.Size = new System.Drawing.Size(69, 15);
            this.LblLastName.TabIndex = 2;
            this.LblLastName.Text = "Last Name :";
            // 
            // LblIsMale
            // 
            this.LblIsMale.AutoSize = true;
            this.LblIsMale.Location = new System.Drawing.Point(12, 263);
            this.LblIsMale.Name = "LblIsMale";
            this.LblIsMale.Size = new System.Drawing.Size(50, 15);
            this.LblIsMale.TabIndex = 3;
            this.LblIsMale.Text = "Is Male :";
            // 
            // LblPhoneNumber
            // 
            this.LblPhoneNumber.AutoSize = true;
            this.LblPhoneNumber.Location = new System.Drawing.Point(12, 177);
            this.LblPhoneNumber.Name = "LblPhoneNumber";
            this.LblPhoneNumber.Size = new System.Drawing.Size(94, 15);
            this.LblPhoneNumber.TabIndex = 4;
            this.LblPhoneNumber.Text = "Phone Number :";
            // 
            // LblBirthDay
            // 
            this.LblBirthDay.AutoSize = true;
            this.LblBirthDay.Location = new System.Drawing.Point(12, 219);
            this.LblBirthDay.Name = "LblBirthDay";
            this.LblBirthDay.Size = new System.Drawing.Size(61, 15);
            this.LblBirthDay.TabIndex = 5;
            this.LblBirthDay.Text = "Birth Day :";
            // 
            // LblNationalCode
            // 
            this.LblNationalCode.AutoSize = true;
            this.LblNationalCode.Location = new System.Drawing.Point(12, 138);
            this.LblNationalCode.Name = "LblNationalCode";
            this.LblNationalCode.Size = new System.Drawing.Size(89, 15);
            this.LblNationalCode.TabIndex = 6;
            this.LblNationalCode.Text = "National Code :";
            // 
            // LblSpecialistType
            // 
            this.LblSpecialistType.AutoSize = true;
            this.LblSpecialistType.Location = new System.Drawing.Point(7, 320);
            this.LblSpecialistType.Name = "LblSpecialistType";
            this.LblSpecialistType.Size = new System.Drawing.Size(89, 15);
            this.LblSpecialistType.TabIndex = 7;
            this.LblSpecialistType.Text = "Specialist Type :";
            // 
            // LblCity
            // 
            this.LblCity.AutoSize = true;
            this.LblCity.Location = new System.Drawing.Point(7, 355);
            this.LblCity.Name = "LblCity";
            this.LblCity.Size = new System.Drawing.Size(34, 15);
            this.LblCity.TabIndex = 8;
            this.LblCity.Text = "City :";
            // 
            // FrmAddExpertByAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblCity);
            this.Controls.Add(this.LblSpecialistType);
            this.Controls.Add(this.LblNationalCode);
            this.Controls.Add(this.LblBirthDay);
            this.Controls.Add(this.LblPhoneNumber);
            this.Controls.Add(this.LblIsMale);
            this.Controls.Add(this.LblLastName);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.LblUserName);
            this.Name = "FrmAddExpertByAdmin";
            this.Text = "FrmAddExpertByAdmin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LblUserName;
        private Label LblName;
        private Label LblLastName;
        private Label LblIsMale;
        private Label LblPhoneNumber;
        private Label LblBirthDay;
        private Label LblNationalCode;
        private Label LblSpecialistType;
        private Label LblCity;
    }
}