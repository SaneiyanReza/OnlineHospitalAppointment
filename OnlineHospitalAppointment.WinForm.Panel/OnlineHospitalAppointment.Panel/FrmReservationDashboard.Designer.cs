﻿namespace OnlineHospitalAppointment.WinForm.Panel.OnlineHospitalAppointment.Panel
{
    partial class FrmReservationDashboard
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
            this.LblFullName = new System.Windows.Forms.Label();
            this.LblShowFullName = new System.Windows.Forms.Label();
            this.GvReceiveExpertsPanel = new System.Windows.Forms.DataGridView();
            this.CmbField = new System.Windows.Forms.ComboBox();
            this.LblSearchBy = new System.Windows.Forms.Label();
            this.LblSearchFor = new System.Windows.Forms.Label();
            this.TxtSearchFor = new System.Windows.Forms.TextBox();
            this.BtnReserve = new System.Windows.Forms.Button();
            this.BtnReport = new System.Windows.Forms.Button();
            this.LblUserName = new System.Windows.Forms.Label();
            this.LblShowUserName = new System.Windows.Forms.Label();
            this.BtnEditProfile = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.BtnEntry = new System.Windows.Forms.Button();
            this.BtnEditIdentity = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GvReceiveExpertsPanel)).BeginInit();
            this.SuspendLayout();
            // 
            // LblFullName
            // 
            this.LblFullName.AutoSize = true;
            this.LblFullName.Location = new System.Drawing.Point(12, 56);
            this.LblFullName.Name = "LblFullName";
            this.LblFullName.Size = new System.Drawing.Size(67, 15);
            this.LblFullName.TabIndex = 0;
            this.LblFullName.Text = "Full Name :";
            // 
            // LblShowFullName
            // 
            this.LblShowFullName.AutoSize = true;
            this.LblShowFullName.Location = new System.Drawing.Point(99, 56);
            this.LblShowFullName.Name = "LblShowFullName";
            this.LblShowFullName.Size = new System.Drawing.Size(87, 15);
            this.LblShowFullName.TabIndex = 2;
            this.LblShowFullName.Text = "ShowFullName";
            // 
            // GvReceiveExpertsPanel
            // 
            this.GvReceiveExpertsPanel.AllowUserToAddRows = false;
            this.GvReceiveExpertsPanel.AllowUserToDeleteRows = false;
            this.GvReceiveExpertsPanel.AllowUserToOrderColumns = true;
            this.GvReceiveExpertsPanel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GvReceiveExpertsPanel.BackgroundColor = System.Drawing.Color.Silver;
            this.GvReceiveExpertsPanel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GvReceiveExpertsPanel.Location = new System.Drawing.Point(12, 96);
            this.GvReceiveExpertsPanel.Name = "GvReceiveExpertsPanel";
            this.GvReceiveExpertsPanel.ReadOnly = true;
            this.GvReceiveExpertsPanel.RowTemplate.Height = 25;
            this.GvReceiveExpertsPanel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GvReceiveExpertsPanel.Size = new System.Drawing.Size(690, 288);
            this.GvReceiveExpertsPanel.TabIndex = 4;
            // 
            // CmbField
            // 
            this.CmbField.BackColor = System.Drawing.SystemColors.Control;
            this.CmbField.FormattingEnabled = true;
            this.CmbField.Items.AddRange(new object[] {
            "FullName",
            "Specialist",
            "Address"});
            this.CmbField.Location = new System.Drawing.Point(479, 26);
            this.CmbField.Name = "CmbField";
            this.CmbField.Size = new System.Drawing.Size(223, 23);
            this.CmbField.TabIndex = 5;
            // 
            // LblSearchBy
            // 
            this.LblSearchBy.AutoSize = true;
            this.LblSearchBy.Location = new System.Drawing.Point(397, 29);
            this.LblSearchBy.Name = "LblSearchBy";
            this.LblSearchBy.Size = new System.Drawing.Size(64, 15);
            this.LblSearchBy.TabIndex = 7;
            this.LblSearchBy.Text = "Search By :";
            // 
            // LblSearchFor
            // 
            this.LblSearchFor.AutoSize = true;
            this.LblSearchFor.Location = new System.Drawing.Point(397, 59);
            this.LblSearchFor.Name = "LblSearchFor";
            this.LblSearchFor.Size = new System.Drawing.Size(68, 15);
            this.LblSearchFor.TabIndex = 8;
            this.LblSearchFor.Text = "Search For :";
            // 
            // TxtSearchFor
            // 
            this.TxtSearchFor.Location = new System.Drawing.Point(479, 56);
            this.TxtSearchFor.Name = "TxtSearchFor";
            this.TxtSearchFor.Size = new System.Drawing.Size(223, 23);
            this.TxtSearchFor.TabIndex = 9;
            this.TxtSearchFor.TextChanged += new System.EventHandler(this.TxtSearchFor_TextChanged);
            // 
            // BtnReserve
            // 
            this.BtnReserve.Enabled = false;
            this.BtnReserve.Location = new System.Drawing.Point(318, 428);
            this.BtnReserve.Name = "BtnReserve";
            this.BtnReserve.Size = new System.Drawing.Size(78, 23);
            this.BtnReserve.TabIndex = 18;
            this.BtnReserve.Text = "Reserve";
            this.BtnReserve.UseVisualStyleBackColor = true;
            this.BtnReserve.Click += new System.EventHandler(this.BtnReserve_Click);
            // 
            // BtnReport
            // 
            this.BtnReport.Location = new System.Drawing.Point(627, 405);
            this.BtnReport.Name = "BtnReport";
            this.BtnReport.Size = new System.Drawing.Size(75, 41);
            this.BtnReport.TabIndex = 19;
            this.BtnReport.Text = "Reports";
            this.BtnReport.UseVisualStyleBackColor = true;
            this.BtnReport.Click += new System.EventHandler(this.BtnReport_Click);
            // 
            // LblUserName
            // 
            this.LblUserName.AutoSize = true;
            this.LblUserName.Location = new System.Drawing.Point(12, 26);
            this.LblUserName.Name = "LblUserName";
            this.LblUserName.Size = new System.Drawing.Size(71, 15);
            this.LblUserName.TabIndex = 12;
            this.LblUserName.Text = "User Name :";
            // 
            // LblShowUserName
            // 
            this.LblShowUserName.AutoSize = true;
            this.LblShowUserName.Location = new System.Drawing.Point(99, 26);
            this.LblShowUserName.Name = "LblShowUserName";
            this.LblShowUserName.Size = new System.Drawing.Size(91, 15);
            this.LblShowUserName.TabIndex = 13;
            this.LblShowUserName.Text = "ShowUserName";
            // 
            // BtnEditProfile
            // 
            this.BtnEditProfile.Location = new System.Drawing.Point(12, 405);
            this.BtnEditProfile.Name = "BtnEditProfile";
            this.BtnEditProfile.Size = new System.Drawing.Size(75, 41);
            this.BtnEditProfile.TabIndex = 14;
            this.BtnEditProfile.Text = "Edit Profile";
            this.BtnEditProfile.UseVisualStyleBackColor = true;
            this.BtnEditProfile.Click += new System.EventHandler(this.BtnEditProfile_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.Enabled = false;
            this.BtnBack.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnBack.Location = new System.Drawing.Point(318, 396);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(36, 26);
            this.BtnBack.TabIndex = 16;
            this.BtnBack.Text = "<--";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnEntry
            // 
            this.BtnEntry.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnEntry.Location = new System.Drawing.Point(360, 396);
            this.BtnEntry.Name = "BtnEntry";
            this.BtnEntry.Size = new System.Drawing.Size(36, 26);
            this.BtnEntry.TabIndex = 17;
            this.BtnEntry.Text = "-->";
            this.BtnEntry.UseVisualStyleBackColor = true;
            this.BtnEntry.Click += new System.EventHandler(this.BtnEntry_Click);
            // 
            // BtnEditIdentity
            // 
            this.BtnEditIdentity.Location = new System.Drawing.Point(99, 405);
            this.BtnEditIdentity.Name = "BtnEditIdentity";
            this.BtnEditIdentity.Size = new System.Drawing.Size(75, 41);
            this.BtnEditIdentity.TabIndex = 15;
            this.BtnEditIdentity.Text = "Edit Identity";
            this.BtnEditIdentity.UseVisualStyleBackColor = true;
            this.BtnEditIdentity.Click += new System.EventHandler(this.BtnEditIdentity_Click);
            // 
            // FrmReservationDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(716, 458);
            this.Controls.Add(this.BtnEditIdentity);
            this.Controls.Add(this.BtnEntry);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnEditProfile);
            this.Controls.Add(this.LblShowUserName);
            this.Controls.Add(this.LblUserName);
            this.Controls.Add(this.BtnReport);
            this.Controls.Add(this.BtnReserve);
            this.Controls.Add(this.TxtSearchFor);
            this.Controls.Add(this.LblSearchFor);
            this.Controls.Add(this.LblSearchBy);
            this.Controls.Add(this.CmbField);
            this.Controls.Add(this.GvReceiveExpertsPanel);
            this.Controls.Add(this.LblShowFullName);
            this.Controls.Add(this.LblFullName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmReservationDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmReservationDashboard";
            this.Load += new System.EventHandler(this.FrmReservationDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GvReceiveExpertsPanel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LblFullName;
        private Label LblShowFullName;
        private DataGridView GvReceiveExpertsPanel;
        private ComboBox CmbField;
        private Label LblSearchBy;
        private Label LblSearchFor;
        private TextBox TxtSearchFor;
        private Button BtnReserve;
        private Button BtnReport;
        private Label LblUserName;
        private Label LblShowUserName;
        private Button BtnEditProfile;
        private Button BtnBack;
        private Button BtnEntry;
        private Button BtnEditIdentity;
    }
}