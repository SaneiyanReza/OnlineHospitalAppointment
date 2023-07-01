namespace OnlineHospitalAppointment.WinForm.Panel.OnlineHospitalAppointment.Admin
{
    partial class FrmExpertDashboard
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
            this.LblReservation = new System.Windows.Forms.Label();
            this.LblShowReservation = new System.Windows.Forms.Label();
            this.LblCancelReservation = new System.Windows.Forms.Label();
            this.LblShowCanceledReserved = new System.Windows.Forms.Label();
            this.GvAppointmentCharts = new System.Windows.Forms.DataGridView();
            this.TxtSearchFor = new System.Windows.Forms.TextBox();
            this.LblSearchFor = new System.Windows.Forms.Label();
            this.LblSearchBy = new System.Windows.Forms.Label();
            this.CmbField = new System.Windows.Forms.ComboBox();
            this.BtnAddAppointment = new System.Windows.Forms.Button();
            this.BtnCancelAppointment = new System.Windows.Forms.Button();
            this.BtnModifyProfile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GvAppointmentCharts)).BeginInit();
            this.SuspendLayout();
            // 
            // LblFullName
            // 
            this.LblFullName.AutoSize = true;
            this.LblFullName.Location = new System.Drawing.Point(13, 19);
            this.LblFullName.Name = "LblFullName";
            this.LblFullName.Size = new System.Drawing.Size(70, 15);
            this.LblFullName.TabIndex = 0;
            this.LblFullName.Text = "Full Name : ";
            // 
            // LblShowFullName
            // 
            this.LblShowFullName.AutoSize = true;
            this.LblShowFullName.Location = new System.Drawing.Point(89, 19);
            this.LblShowFullName.Name = "LblShowFullName";
            this.LblShowFullName.Size = new System.Drawing.Size(87, 15);
            this.LblShowFullName.TabIndex = 1;
            this.LblShowFullName.Text = "ShowFullName";
            // 
            // LblReservation
            // 
            this.LblReservation.AutoSize = true;
            this.LblReservation.Location = new System.Drawing.Point(13, 45);
            this.LblReservation.Name = "LblReservation";
            this.LblReservation.Size = new System.Drawing.Size(77, 15);
            this.LblReservation.TabIndex = 2;
            this.LblReservation.Text = "Reservation : ";
            // 
            // LblShowReservation
            // 
            this.LblShowReservation.AutoSize = true;
            this.LblShowReservation.Location = new System.Drawing.Point(96, 45);
            this.LblShowReservation.Name = "LblShowReservation";
            this.LblShowReservation.Size = new System.Drawing.Size(97, 15);
            this.LblShowReservation.TabIndex = 3;
            this.LblShowReservation.Text = "ShowReservation";
            // 
            // LblCancelReservation
            // 
            this.LblCancelReservation.AutoSize = true;
            this.LblCancelReservation.Location = new System.Drawing.Point(12, 72);
            this.LblCancelReservation.Name = "LblCancelReservation";
            this.LblCancelReservation.Size = new System.Drawing.Size(105, 15);
            this.LblCancelReservation.TabIndex = 4;
            this.LblCancelReservation.Text = "Canceled Reserve :";
            // 
            // LblShowCanceledReserved
            // 
            this.LblShowCanceledReserved.AutoSize = true;
            this.LblShowCanceledReserved.Location = new System.Drawing.Point(123, 72);
            this.LblShowCanceledReserved.Name = "LblShowCanceledReserved";
            this.LblShowCanceledReserved.Size = new System.Drawing.Size(125, 15);
            this.LblShowCanceledReserved.TabIndex = 5;
            this.LblShowCanceledReserved.Text = "ShowCanceledReserve";
            // 
            // GvAppointmentCharts
            // 
            this.GvAppointmentCharts.AllowUserToAddRows = false;
            this.GvAppointmentCharts.AllowUserToDeleteRows = false;
            this.GvAppointmentCharts.AllowUserToOrderColumns = true;
            this.GvAppointmentCharts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GvAppointmentCharts.BackgroundColor = System.Drawing.Color.Silver;
            this.GvAppointmentCharts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GvAppointmentCharts.Location = new System.Drawing.Point(12, 99);
            this.GvAppointmentCharts.Name = "GvAppointmentCharts";
            this.GvAppointmentCharts.ReadOnly = true;
            this.GvAppointmentCharts.RowTemplate.Height = 25;
            this.GvAppointmentCharts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GvAppointmentCharts.Size = new System.Drawing.Size(763, 207);
            this.GvAppointmentCharts.TabIndex = 21;
            // 
            // TxtSearchFor
            // 
            this.TxtSearchFor.Location = new System.Drawing.Point(488, 54);
            this.TxtSearchFor.Name = "TxtSearchFor";
            this.TxtSearchFor.Size = new System.Drawing.Size(287, 23);
            this.TxtSearchFor.TabIndex = 25;
            this.TxtSearchFor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtSearchFor_KeyDown);
            // 
            // LblSearchFor
            // 
            this.LblSearchFor.AutoSize = true;
            this.LblSearchFor.Location = new System.Drawing.Point(404, 57);
            this.LblSearchFor.Name = "LblSearchFor";
            this.LblSearchFor.Size = new System.Drawing.Size(68, 15);
            this.LblSearchFor.TabIndex = 24;
            this.LblSearchFor.Text = "Search For :";
            // 
            // LblSearchBy
            // 
            this.LblSearchBy.AutoSize = true;
            this.LblSearchBy.Location = new System.Drawing.Point(404, 18);
            this.LblSearchBy.Name = "LblSearchBy";
            this.LblSearchBy.Size = new System.Drawing.Size(64, 15);
            this.LblSearchBy.TabIndex = 23;
            this.LblSearchBy.Text = "Search By :";
            // 
            // CmbField
            // 
            this.CmbField.BackColor = System.Drawing.SystemColors.Control;
            this.CmbField.FormattingEnabled = true;
            this.CmbField.Items.AddRange(new object[] {
            "FullName",
            "UserName",
            "Date"});
            this.CmbField.Location = new System.Drawing.Point(488, 15);
            this.CmbField.Name = "CmbField";
            this.CmbField.Size = new System.Drawing.Size(287, 23);
            this.CmbField.TabIndex = 22;
            // 
            // BtnAddAppointment
            // 
            this.BtnAddAppointment.Location = new System.Drawing.Point(12, 322);
            this.BtnAddAppointment.Name = "BtnAddAppointment";
            this.BtnAddAppointment.Size = new System.Drawing.Size(104, 38);
            this.BtnAddAppointment.TabIndex = 26;
            this.BtnAddAppointment.Text = "Add Appointment";
            this.BtnAddAppointment.UseVisualStyleBackColor = true;
            this.BtnAddAppointment.Click += new System.EventHandler(this.BtnAddAppointment_Click);
            // 
            // BtnCancelAppointment
            // 
            this.BtnCancelAppointment.Location = new System.Drawing.Point(133, 322);
            this.BtnCancelAppointment.Name = "BtnCancelAppointment";
            this.BtnCancelAppointment.Size = new System.Drawing.Size(104, 38);
            this.BtnCancelAppointment.TabIndex = 27;
            this.BtnCancelAppointment.Text = "Cancel Appointment";
            this.BtnCancelAppointment.UseVisualStyleBackColor = true;
            this.BtnCancelAppointment.Click += new System.EventHandler(this.BtnCancelAppointment_Click);
            // 
            // BtnModifyProfile
            // 
            this.BtnModifyProfile.Location = new System.Drawing.Point(671, 322);
            this.BtnModifyProfile.Name = "BtnModifyProfile";
            this.BtnModifyProfile.Size = new System.Drawing.Size(104, 38);
            this.BtnModifyProfile.TabIndex = 28;
            this.BtnModifyProfile.Text = "Modify Profile";
            this.BtnModifyProfile.UseVisualStyleBackColor = true;
            this.BtnModifyProfile.Click += new System.EventHandler(this.BtnModifyProfile_Click);
            // 
            // FrmExpertDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(790, 377);
            this.Controls.Add(this.BtnModifyProfile);
            this.Controls.Add(this.BtnCancelAppointment);
            this.Controls.Add(this.BtnAddAppointment);
            this.Controls.Add(this.TxtSearchFor);
            this.Controls.Add(this.LblSearchFor);
            this.Controls.Add(this.LblSearchBy);
            this.Controls.Add(this.CmbField);
            this.Controls.Add(this.GvAppointmentCharts);
            this.Controls.Add(this.LblShowCanceledReserved);
            this.Controls.Add(this.LblCancelReservation);
            this.Controls.Add(this.LblShowReservation);
            this.Controls.Add(this.LblReservation);
            this.Controls.Add(this.LblShowFullName);
            this.Controls.Add(this.LblFullName);
            this.MaximizeBox = false;
            this.Name = "FrmExpertDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmExpertDashboard";
            this.Load += new System.EventHandler(this.FrmExpertDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GvAppointmentCharts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LblFullName;
        private Label LblShowFullName;
        private Label LblReservation;
        private Label LblShowReservation;
        private Label LblCancelReservation;
        private Label LblShowCanceledReserved;
        private DataGridView GvAppointmentCharts;
        private TextBox TxtSearchFor;
        private Label LblSearchFor;
        private Label LblSearchBy;
        private ComboBox CmbField;
        private Button BtnAddAppointment;
        private Button BtnCancelAppointment;
        private Button BtnModifyProfile;
    }
}