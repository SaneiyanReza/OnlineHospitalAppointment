namespace OnlineHospitalAppointment.WinForm.Panel.OnlineHospitalAppointment.Admin
{
    partial class FrmAddSpecialistTypeByAdmin
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
            this.LblSpecialistType = new System.Windows.Forms.Label();
            this.TxtSpecialistType = new System.Windows.Forms.TextBox();
            this.ComboSpecialistType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblSpecialistType
            // 
            this.LblSpecialistType.AutoSize = true;
            this.LblSpecialistType.Location = new System.Drawing.Point(280, 90);
            this.LblSpecialistType.Name = "LblSpecialistType";
            this.LblSpecialistType.Size = new System.Drawing.Size(53, 15);
            this.LblSpecialistType.TabIndex = 0;
            this.LblSpecialistType.Text = "متخصص";
            // 
            // TxtSpecialistType
            // 
            this.TxtSpecialistType.Location = new System.Drawing.Point(24, 87);
            this.TxtSpecialistType.Name = "TxtSpecialistType";
            this.TxtSpecialistType.Size = new System.Drawing.Size(250, 23);
            this.TxtSpecialistType.TabIndex = 1;
            // 
            // ComboSpecialistType
            // 
            this.ComboSpecialistType.FormattingEnabled = true;
            this.ComboSpecialistType.Location = new System.Drawing.Point(129, 34);
            this.ComboSpecialistType.Name = "ComboSpecialistType";
            this.ComboSpecialistType.Size = new System.Drawing.Size(204, 23);
            this.ComboSpecialistType.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "Specialist Type :";
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.Location = new System.Drawing.Point(129, 145);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(92, 28);
            this.BtnSubmit.TabIndex = 20;
            this.BtnSubmit.Text = "Submit";
            this.BtnSubmit.UseVisualStyleBackColor = true;
            this.BtnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // FrmAddSpecialistTypeByAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(345, 185);
            this.Controls.Add(this.BtnSubmit);
            this.Controls.Add(this.ComboSpecialistType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtSpecialistType);
            this.Controls.Add(this.LblSpecialistType);
            this.MaximizeBox = false;
            this.Name = "FrmAddSpecialistTypeByAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAddSpecialistTypeByAdmin";
            this.Load += new System.EventHandler(this.AddSpecialistTypeByAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LblSpecialistType;
        private TextBox TxtSpecialistType;
        private ComboBox ComboSpecialistType;
        private Label label1;
        private Button BtnSubmit;
    }
}