namespace OnlineHospitalAppointment.WinForm.Panel.OnlineHospitalAppointment.Identity
{
    partial class FrmEditIdentity
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
            this.LblCurrentPassword = new System.Windows.Forms.Label();
            this.LblNewPassword = new System.Windows.Forms.Label();
            this.TxtUserName = new System.Windows.Forms.TextBox();
            this.TxtCurrentPassword = new System.Windows.Forms.TextBox();
            this.TxtNewPassword = new System.Windows.Forms.TextBox();
            this.BtnSubmit = new System.Windows.Forms.Button();
            this.ErrorProviderApp = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderApp)).BeginInit();
            this.SuspendLayout();
            // 
            // LblUserName
            // 
            this.LblUserName.AutoSize = true;
            this.LblUserName.Location = new System.Drawing.Point(12, 26);
            this.LblUserName.Name = "LblUserName";
            this.LblUserName.Size = new System.Drawing.Size(71, 15);
            this.LblUserName.TabIndex = 0;
            this.LblUserName.Text = "User Name :";
            // 
            // LblCurrentPassword
            // 
            this.LblCurrentPassword.AutoSize = true;
            this.LblCurrentPassword.Location = new System.Drawing.Point(12, 65);
            this.LblCurrentPassword.Name = "LblCurrentPassword";
            this.LblCurrentPassword.Size = new System.Drawing.Size(106, 15);
            this.LblCurrentPassword.TabIndex = 1;
            this.LblCurrentPassword.Text = "Current Password :";
            // 
            // LblNewPassword
            // 
            this.LblNewPassword.AutoSize = true;
            this.LblNewPassword.Location = new System.Drawing.Point(12, 103);
            this.LblNewPassword.Name = "LblNewPassword";
            this.LblNewPassword.Size = new System.Drawing.Size(90, 15);
            this.LblNewPassword.TabIndex = 2;
            this.LblNewPassword.Text = "New Password :";
            // 
            // TxtUserName
            // 
            this.TxtUserName.Location = new System.Drawing.Point(122, 23);
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.Size = new System.Drawing.Size(181, 23);
            this.TxtUserName.TabIndex = 3;
            this.TxtUserName.Validating += new System.ComponentModel.CancelEventHandler(this.TxtUserName_Validating);
            // 
            // TxtCurrentPassword
            // 
            this.TxtCurrentPassword.Location = new System.Drawing.Point(122, 62);
            this.TxtCurrentPassword.Name = "TxtCurrentPassword";
            this.TxtCurrentPassword.Size = new System.Drawing.Size(181, 23);
            this.TxtCurrentPassword.TabIndex = 4;
            this.TxtCurrentPassword.Validating += new System.ComponentModel.CancelEventHandler(this.TxtCurrentPassword_Validating);
            // 
            // TxtNewPassword
            // 
            this.TxtNewPassword.Location = new System.Drawing.Point(122, 100);
            this.TxtNewPassword.Name = "TxtNewPassword";
            this.TxtNewPassword.Size = new System.Drawing.Size(181, 23);
            this.TxtNewPassword.TabIndex = 5;
            this.TxtNewPassword.Validating += new System.ComponentModel.CancelEventHandler(this.TxtNewPassword_Validating);
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.Location = new System.Drawing.Point(171, 143);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(91, 32);
            this.BtnSubmit.TabIndex = 6;
            this.BtnSubmit.Text = "Submit";
            this.BtnSubmit.UseVisualStyleBackColor = true;
            this.BtnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // ErrorProviderApp
            // 
            this.ErrorProviderApp.ContainerControl = this;
            // 
            // FrmModifyIdentity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(337, 187);
            this.Controls.Add(this.BtnSubmit);
            this.Controls.Add(this.TxtNewPassword);
            this.Controls.Add(this.TxtCurrentPassword);
            this.Controls.Add(this.TxtUserName);
            this.Controls.Add(this.LblNewPassword);
            this.Controls.Add(this.LblCurrentPassword);
            this.Controls.Add(this.LblUserName);
            this.MaximizeBox = false;
            this.Name = "FrmModifyIdentity";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmModifyIdentity";
            this.Load += new System.EventHandler(this.FrmModifyIdentity_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderApp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LblUserName;
        private Label LblCurrentPassword;
        private Label LblNewPassword;
        private TextBox TxtUserName;
        private TextBox TxtCurrentPassword;
        private TextBox TxtNewPassword;
        private Button BtnSubmit;
        private ErrorProvider ErrorProviderApp;
    }
}