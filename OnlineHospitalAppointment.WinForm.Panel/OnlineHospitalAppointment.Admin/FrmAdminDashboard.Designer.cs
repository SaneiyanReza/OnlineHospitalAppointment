namespace OnlineHospitalAppointment.WinForm.Panel.OnlineHospitalAppointment.Admin
{
    partial class FrmAdminDashboard
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
            this.LblTotalExperts = new System.Windows.Forms.Label();
            this.LblShowTotalExperts = new System.Windows.Forms.Label();
            this.BtnAddExpert = new System.Windows.Forms.Button();
            this.LblTotalUsers = new System.Windows.Forms.Label();
            this.LblShowTotalUsers = new System.Windows.Forms.Label();
            this.LblTotalReservations = new System.Windows.Forms.Label();
            this.LblShowTotalReservations = new System.Windows.Forms.Label();
            this.BtnDeleteExpert = new System.Windows.Forms.Button();
            this.BtnModifyExpert = new System.Windows.Forms.Button();
            this.BtnSuspend = new System.Windows.Forms.Button();
            this.BtnShowUser = new System.Windows.Forms.Button();
            this.TxtSearchFor = new System.Windows.Forms.TextBox();
            this.LblSearchFor = new System.Windows.Forms.Label();
            this.LblSearchBy = new System.Windows.Forms.Label();
            this.CmbField = new System.Windows.Forms.ComboBox();
            this.GvReceiveExpertsPanel = new System.Windows.Forms.DataGridView();
            this.BtnAddSpecialistType = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GvReceiveExpertsPanel)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTotalExperts
            // 
            this.LblTotalExperts.AutoSize = true;
            this.LblTotalExperts.Location = new System.Drawing.Point(13, 56);
            this.LblTotalExperts.Name = "LblTotalExperts";
            this.LblTotalExperts.Size = new System.Drawing.Size(79, 15);
            this.LblTotalExperts.TabIndex = 0;
            this.LblTotalExperts.Text = "Total Experts :";
            // 
            // LblShowTotalExperts
            // 
            this.LblShowTotalExperts.AutoSize = true;
            this.LblShowTotalExperts.Location = new System.Drawing.Point(97, 56);
            this.LblShowTotalExperts.Name = "LblShowTotalExperts";
            this.LblShowTotalExperts.Size = new System.Drawing.Size(99, 15);
            this.LblShowTotalExperts.TabIndex = 1;
            this.LblShowTotalExperts.Text = "ShowTotalExperts";
            // 
            // BtnAddExpert
            // 
            this.BtnAddExpert.Location = new System.Drawing.Point(13, 463);
            this.BtnAddExpert.Name = "BtnAddExpert";
            this.BtnAddExpert.Size = new System.Drawing.Size(91, 36);
            this.BtnAddExpert.TabIndex = 2;
            this.BtnAddExpert.Text = "Add Expert";
            this.BtnAddExpert.UseVisualStyleBackColor = true;
            this.BtnAddExpert.Click += new System.EventHandler(this.BtnAddExpert_Click);
            // 
            // LblTotalUsers
            // 
            this.LblTotalUsers.AutoSize = true;
            this.LblTotalUsers.Location = new System.Drawing.Point(13, 28);
            this.LblTotalUsers.Name = "LblTotalUsers";
            this.LblTotalUsers.Size = new System.Drawing.Size(69, 15);
            this.LblTotalUsers.TabIndex = 8;
            this.LblTotalUsers.Text = "Total Users :";
            // 
            // LblShowTotalUsers
            // 
            this.LblShowTotalUsers.AutoSize = true;
            this.LblShowTotalUsers.Location = new System.Drawing.Point(97, 28);
            this.LblShowTotalUsers.Name = "LblShowTotalUsers";
            this.LblShowTotalUsers.Size = new System.Drawing.Size(89, 15);
            this.LblShowTotalUsers.TabIndex = 9;
            this.LblShowTotalUsers.Text = "ShowTotalUsers";
            // 
            // LblTotalReservations
            // 
            this.LblTotalReservations.AutoSize = true;
            this.LblTotalReservations.Location = new System.Drawing.Point(13, 84);
            this.LblTotalReservations.Name = "LblTotalReservations";
            this.LblTotalReservations.Size = new System.Drawing.Size(107, 15);
            this.LblTotalReservations.TabIndex = 10;
            this.LblTotalReservations.Text = "Total Reservations :";
            // 
            // LblShowTotalReservations
            // 
            this.LblShowTotalReservations.AutoSize = true;
            this.LblShowTotalReservations.Location = new System.Drawing.Point(125, 84);
            this.LblShowTotalReservations.Name = "LblShowTotalReservations";
            this.LblShowTotalReservations.Size = new System.Drawing.Size(127, 15);
            this.LblShowTotalReservations.TabIndex = 11;
            this.LblShowTotalReservations.Text = "ShowTotalReservations";
            // 
            // BtnDeleteExpert
            // 
            this.BtnDeleteExpert.Location = new System.Drawing.Point(228, 463);
            this.BtnDeleteExpert.Name = "BtnDeleteExpert";
            this.BtnDeleteExpert.Size = new System.Drawing.Size(90, 36);
            this.BtnDeleteExpert.TabIndex = 12;
            this.BtnDeleteExpert.Text = "Delete Expert";
            this.BtnDeleteExpert.UseVisualStyleBackColor = true;
            this.BtnDeleteExpert.Click += new System.EventHandler(this.BtnDeleteExpert_Click);
            // 
            // BtnModifyExpert
            // 
            this.BtnModifyExpert.Location = new System.Drawing.Point(122, 463);
            this.BtnModifyExpert.Name = "BtnModifyExpert";
            this.BtnModifyExpert.Size = new System.Drawing.Size(90, 36);
            this.BtnModifyExpert.TabIndex = 13;
            this.BtnModifyExpert.Text = "Modify Expert";
            this.BtnModifyExpert.UseVisualStyleBackColor = true;
            this.BtnModifyExpert.Click += new System.EventHandler(this.BtnModifyExpert_Click);
            // 
            // BtnSuspend
            // 
            this.BtnSuspend.Location = new System.Drawing.Point(336, 463);
            this.BtnSuspend.Name = "BtnSuspend";
            this.BtnSuspend.Size = new System.Drawing.Size(91, 36);
            this.BtnSuspend.TabIndex = 14;
            this.BtnSuspend.Text = "Suspend!";
            this.BtnSuspend.UseVisualStyleBackColor = true;
            this.BtnSuspend.Click += new System.EventHandler(this.BtnSuspend_Click);
            // 
            // BtnShowUser
            // 
            this.BtnShowUser.Location = new System.Drawing.Point(680, 463);
            this.BtnShowUser.Name = "BtnShowUser";
            this.BtnShowUser.Size = new System.Drawing.Size(97, 36);
            this.BtnShowUser.TabIndex = 15;
            this.BtnShowUser.Text = "Show User";
            this.BtnShowUser.UseVisualStyleBackColor = true;
            // 
            // TxtSearchFor
            // 
            this.TxtSearchFor.Location = new System.Drawing.Point(489, 67);
            this.TxtSearchFor.Name = "TxtSearchFor";
            this.TxtSearchFor.Size = new System.Drawing.Size(287, 23);
            this.TxtSearchFor.TabIndex = 19;
            this.TxtSearchFor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtSearchFor_KeyDown);
            // 
            // LblSearchFor
            // 
            this.LblSearchFor.AutoSize = true;
            this.LblSearchFor.Location = new System.Drawing.Point(405, 70);
            this.LblSearchFor.Name = "LblSearchFor";
            this.LblSearchFor.Size = new System.Drawing.Size(68, 15);
            this.LblSearchFor.TabIndex = 18;
            this.LblSearchFor.Text = "Search For :";
            // 
            // LblSearchBy
            // 
            this.LblSearchBy.AutoSize = true;
            this.LblSearchBy.Location = new System.Drawing.Point(405, 31);
            this.LblSearchBy.Name = "LblSearchBy";
            this.LblSearchBy.Size = new System.Drawing.Size(64, 15);
            this.LblSearchBy.TabIndex = 17;
            this.LblSearchBy.Text = "Search By :";
            // 
            // CmbField
            // 
            this.CmbField.BackColor = System.Drawing.SystemColors.Control;
            this.CmbField.FormattingEnabled = true;
            this.CmbField.Items.AddRange(new object[] {
            "FullName",
            "Specialist",
            "Address"});
            this.CmbField.Location = new System.Drawing.Point(489, 28);
            this.CmbField.Name = "CmbField";
            this.CmbField.Size = new System.Drawing.Size(287, 23);
            this.CmbField.TabIndex = 16;
            // 
            // GvReceiveExpertsPanel
            // 
            this.GvReceiveExpertsPanel.AllowUserToAddRows = false;
            this.GvReceiveExpertsPanel.AllowUserToDeleteRows = false;
            this.GvReceiveExpertsPanel.AllowUserToOrderColumns = true;
            this.GvReceiveExpertsPanel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GvReceiveExpertsPanel.BackgroundColor = System.Drawing.Color.Silver;
            this.GvReceiveExpertsPanel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GvReceiveExpertsPanel.Location = new System.Drawing.Point(13, 110);
            this.GvReceiveExpertsPanel.Name = "GvReceiveExpertsPanel";
            this.GvReceiveExpertsPanel.ReadOnly = true;
            this.GvReceiveExpertsPanel.RowTemplate.Height = 25;
            this.GvReceiveExpertsPanel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GvReceiveExpertsPanel.Size = new System.Drawing.Size(763, 337);
            this.GvReceiveExpertsPanel.TabIndex = 20;
            // 
            // BtnAddSpecialistType
            // 
            this.BtnAddSpecialistType.Location = new System.Drawing.Point(446, 463);
            this.BtnAddSpecialistType.Name = "BtnAddSpecialistType";
            this.BtnAddSpecialistType.Size = new System.Drawing.Size(122, 36);
            this.BtnAddSpecialistType.TabIndex = 21;
            this.BtnAddSpecialistType.Text = "Add Specialist Type";
            this.BtnAddSpecialistType.UseVisualStyleBackColor = true;
            // 
            // FrmAdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 509);
            this.Controls.Add(this.BtnAddSpecialistType);
            this.Controls.Add(this.GvReceiveExpertsPanel);
            this.Controls.Add(this.TxtSearchFor);
            this.Controls.Add(this.LblSearchFor);
            this.Controls.Add(this.LblSearchBy);
            this.Controls.Add(this.CmbField);
            this.Controls.Add(this.BtnShowUser);
            this.Controls.Add(this.BtnSuspend);
            this.Controls.Add(this.BtnModifyExpert);
            this.Controls.Add(this.BtnDeleteExpert);
            this.Controls.Add(this.LblShowTotalReservations);
            this.Controls.Add(this.LblTotalReservations);
            this.Controls.Add(this.LblShowTotalUsers);
            this.Controls.Add(this.LblTotalUsers);
            this.Controls.Add(this.BtnAddExpert);
            this.Controls.Add(this.LblShowTotalExperts);
            this.Controls.Add(this.LblTotalExperts);
            this.Name = "FrmAdminDashboard";
            this.Text = "FrmAdminDashboard";
            this.Load += new System.EventHandler(this.FrmAdminDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GvReceiveExpertsPanel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LblTotalExperts;
        private Label LblShowTotalExperts;
        private Button BtnAddExpert;
        private Label LblTotalUsers;
        private Label LblShowTotalUsers;
        private Label LblTotalReservations;
        private Label LblShowTotalReservations;
        private Button BtnDeleteExpert;
        private Button BtnModifyExpert;
        private Button BtnSuspend;
        private Button BtnShowUser;
        private TextBox TxtSearchFor;
        private Label LblSearchFor;
        private Label LblSearchBy;
        private ComboBox CmbField;
        private DataGridView GvReceiveExpertsPanel;
        private Button BtnAddSpecialistType;
    }
}