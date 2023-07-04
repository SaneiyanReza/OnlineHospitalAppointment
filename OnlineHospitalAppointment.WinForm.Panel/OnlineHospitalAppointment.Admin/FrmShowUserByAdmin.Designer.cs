namespace OnlineHospitalAppointment.WinForm.Panel.OnlineHospitalAppointment.Admin
{
    partial class FrmShowUserByAdmin
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
            this.GvReceiveUsersPanel = new System.Windows.Forms.DataGridView();
            this.TxtSearchFor = new System.Windows.Forms.TextBox();
            this.CmbField = new System.Windows.Forms.ComboBox();
            this.BtnSuspend = new System.Windows.Forms.Button();
            this.BtnDeleteUser = new System.Windows.Forms.Button();
            this.LblSearchFor = new System.Windows.Forms.Label();
            this.LblSearchBy = new System.Windows.Forms.Label();
            this.BtnTurnOver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GvReceiveUsersPanel)).BeginInit();
            this.SuspendLayout();
            // 
            // GvReceiveUsersPanel
            // 
            this.GvReceiveUsersPanel.AllowUserToAddRows = false;
            this.GvReceiveUsersPanel.AllowUserToDeleteRows = false;
            this.GvReceiveUsersPanel.AllowUserToOrderColumns = true;
            this.GvReceiveUsersPanel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GvReceiveUsersPanel.BackgroundColor = System.Drawing.Color.Silver;
            this.GvReceiveUsersPanel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GvReceiveUsersPanel.Location = new System.Drawing.Point(25, 65);
            this.GvReceiveUsersPanel.Name = "GvReceiveUsersPanel";
            this.GvReceiveUsersPanel.ReadOnly = true;
            this.GvReceiveUsersPanel.RowTemplate.Height = 25;
            this.GvReceiveUsersPanel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GvReceiveUsersPanel.Size = new System.Drawing.Size(763, 337);
            this.GvReceiveUsersPanel.TabIndex = 25;
            // 
            // TxtSearchFor
            // 
            this.TxtSearchFor.Location = new System.Drawing.Point(501, 23);
            this.TxtSearchFor.Name = "TxtSearchFor";
            this.TxtSearchFor.Size = new System.Drawing.Size(287, 23);
            this.TxtSearchFor.TabIndex = 24;
            this.TxtSearchFor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtSearchFor_KeyDown);
            // 
            // CmbField
            // 
            this.CmbField.BackColor = System.Drawing.SystemColors.Control;
            this.CmbField.FormattingEnabled = true;
            this.CmbField.Items.AddRange(new object[] {
            "UserName",
            "FullName",
            "PhoneNumber"});
            this.CmbField.Location = new System.Drawing.Point(95, 23);
            this.CmbField.Name = "CmbField";
            this.CmbField.Size = new System.Drawing.Size(287, 23);
            this.CmbField.TabIndex = 23;
            // 
            // BtnSuspend
            // 
            this.BtnSuspend.Location = new System.Drawing.Point(138, 422);
            this.BtnSuspend.Name = "BtnSuspend";
            this.BtnSuspend.Size = new System.Drawing.Size(91, 36);
            this.BtnSuspend.TabIndex = 22;
            this.BtnSuspend.Text = "Suspend!";
            this.BtnSuspend.UseVisualStyleBackColor = true;
            this.BtnSuspend.Click += new System.EventHandler(this.BtnSuspend_Click);
            // 
            // BtnDeleteUser
            // 
            this.BtnDeleteUser.Location = new System.Drawing.Point(25, 422);
            this.BtnDeleteUser.Name = "BtnDeleteUser";
            this.BtnDeleteUser.Size = new System.Drawing.Size(90, 36);
            this.BtnDeleteUser.TabIndex = 21;
            this.BtnDeleteUser.Text = "Delete User";
            this.BtnDeleteUser.UseVisualStyleBackColor = true;
            this.BtnDeleteUser.Click += new System.EventHandler(this.BtnDeleteUser_Click);
            // 
            // LblSearchFor
            // 
            this.LblSearchFor.AutoSize = true;
            this.LblSearchFor.Location = new System.Drawing.Point(427, 26);
            this.LblSearchFor.Name = "LblSearchFor";
            this.LblSearchFor.Size = new System.Drawing.Size(68, 15);
            this.LblSearchFor.TabIndex = 27;
            this.LblSearchFor.Text = "Search For :";
            // 
            // LblSearchBy
            // 
            this.LblSearchBy.AutoSize = true;
            this.LblSearchBy.Location = new System.Drawing.Point(25, 26);
            this.LblSearchBy.Name = "LblSearchBy";
            this.LblSearchBy.Size = new System.Drawing.Size(64, 15);
            this.LblSearchBy.TabIndex = 26;
            this.LblSearchBy.Text = "Search By :";
            // 
            // BtnTurnOver
            // 
            this.BtnTurnOver.Location = new System.Drawing.Point(697, 422);
            this.BtnTurnOver.Name = "BtnTurnOver";
            this.BtnTurnOver.Size = new System.Drawing.Size(91, 36);
            this.BtnTurnOver.TabIndex = 28;
            this.BtnTurnOver.Text = "Turn Over";
            this.BtnTurnOver.UseVisualStyleBackColor = true;
            this.BtnTurnOver.Click += new System.EventHandler(this.BtnTurnOver_Click);
            // 
            // FrmShowUserByAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 470);
            this.Controls.Add(this.BtnTurnOver);
            this.Controls.Add(this.LblSearchFor);
            this.Controls.Add(this.LblSearchBy);
            this.Controls.Add(this.GvReceiveUsersPanel);
            this.Controls.Add(this.TxtSearchFor);
            this.Controls.Add(this.CmbField);
            this.Controls.Add(this.BtnSuspend);
            this.Controls.Add(this.BtnDeleteUser);
            this.Name = "FrmShowUserByAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmShowUserByAdmin";
            this.Load += new System.EventHandler(this.FrmShowUserByAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GvReceiveUsersPanel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView GvReceiveUsersPanel;
        private TextBox TxtSearchFor;
        private ComboBox CmbField;
        private Button BtnSuspend;
        private Button BtnDeleteUser;
        private Label LblSearchFor;
        private Label LblSearchBy;
        private Button BtnTurnOver;
    }
}