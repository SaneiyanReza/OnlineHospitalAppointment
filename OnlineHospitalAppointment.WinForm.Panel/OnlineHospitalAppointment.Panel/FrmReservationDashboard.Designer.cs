namespace OnlineHospitalAppointment.WinForm.Panel.OnlineHospitalAppointment.Panel
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
            this.LblName = new System.Windows.Forms.Label();
            this.LblLastName = new System.Windows.Forms.Label();
            this.LblShowName = new System.Windows.Forms.Label();
            this.LblShowLastName = new System.Windows.Forms.Label();
            this.GvReceiveDoctorPanel = new System.Windows.Forms.DataGridView();
            this.CmbField = new System.Windows.Forms.ComboBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.LblSearchBy = new System.Windows.Forms.Label();
            this.LblSearchFor = new System.Windows.Forms.Label();
            this.TxtSearchFor = new System.Windows.Forms.TextBox();
            this.BtnReserve = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GvReceiveDoctorPanel)).BeginInit();
            this.SuspendLayout();
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(12, 19);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(45, 15);
            this.LblName.TabIndex = 0;
            this.LblName.Text = "Name :";
            // 
            // LblLastName
            // 
            this.LblLastName.AutoSize = true;
            this.LblLastName.Location = new System.Drawing.Point(12, 49);
            this.LblLastName.Name = "LblLastName";
            this.LblLastName.Size = new System.Drawing.Size(66, 15);
            this.LblLastName.TabIndex = 1;
            this.LblLastName.Text = "LastName :";
            // 
            // LblShowName
            // 
            this.LblShowName.AutoSize = true;
            this.LblShowName.Location = new System.Drawing.Point(99, 19);
            this.LblShowName.Name = "LblShowName";
            this.LblShowName.Size = new System.Drawing.Size(68, 15);
            this.LblShowName.TabIndex = 2;
            this.LblShowName.Text = "ShowName";
            // 
            // LblShowLastName
            // 
            this.LblShowLastName.AutoSize = true;
            this.LblShowLastName.Location = new System.Drawing.Point(99, 49);
            this.LblShowLastName.Name = "LblShowLastName";
            this.LblShowLastName.Size = new System.Drawing.Size(89, 15);
            this.LblShowLastName.TabIndex = 3;
            this.LblShowLastName.Text = "ShowLastName";
            // 
            // GvReceiveDoctorPanel
            // 
            this.GvReceiveDoctorPanel.AllowUserToAddRows = false;
            this.GvReceiveDoctorPanel.AllowUserToDeleteRows = false;
            this.GvReceiveDoctorPanel.AllowUserToOrderColumns = true;
            this.GvReceiveDoctorPanel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GvReceiveDoctorPanel.Location = new System.Drawing.Point(12, 96);
            this.GvReceiveDoctorPanel.Name = "GvReceiveDoctorPanel";
            this.GvReceiveDoctorPanel.ReadOnly = true;
            this.GvReceiveDoctorPanel.RowTemplate.Height = 25;
            this.GvReceiveDoctorPanel.Size = new System.Drawing.Size(776, 288);
            this.GvReceiveDoctorPanel.TabIndex = 4;
            // 
            // CmbField
            // 
            this.CmbField.BackColor = System.Drawing.SystemColors.ControlDark;
            this.CmbField.FormattingEnabled = true;
            this.CmbField.Location = new System.Drawing.Point(422, 16);
            this.CmbField.Name = "CmbField";
            this.CmbField.Size = new System.Drawing.Size(223, 23);
            this.CmbField.TabIndex = 5;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(705, 19);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(75, 45);
            this.BtnSearch.TabIndex = 6;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = true;
            // 
            // LblSearchBy
            // 
            this.LblSearchBy.AutoSize = true;
            this.LblSearchBy.Location = new System.Drawing.Point(340, 19);
            this.LblSearchBy.Name = "LblSearchBy";
            this.LblSearchBy.Size = new System.Drawing.Size(64, 15);
            this.LblSearchBy.TabIndex = 7;
            this.LblSearchBy.Text = "Search By :";
            // 
            // LblSearchFor
            // 
            this.LblSearchFor.AutoSize = true;
            this.LblSearchFor.Location = new System.Drawing.Point(340, 49);
            this.LblSearchFor.Name = "LblSearchFor";
            this.LblSearchFor.Size = new System.Drawing.Size(68, 15);
            this.LblSearchFor.TabIndex = 8;
            this.LblSearchFor.Text = "Search For :";
            // 
            // TxtSearchFor
            // 
            this.TxtSearchFor.Location = new System.Drawing.Point(422, 46);
            this.TxtSearchFor.Name = "TxtSearchFor";
            this.TxtSearchFor.Size = new System.Drawing.Size(223, 23);
            this.TxtSearchFor.TabIndex = 9;
            // 
            // BtnReserve
            // 
            this.BtnReserve.Location = new System.Drawing.Point(705, 400);
            this.BtnReserve.Name = "BtnReserve";
            this.BtnReserve.Size = new System.Drawing.Size(75, 38);
            this.BtnReserve.TabIndex = 10;
            this.BtnReserve.Text = "Reserve";
            this.BtnReserve.UseVisualStyleBackColor = true;
            // 
            // FrmReservationDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnReserve);
            this.Controls.Add(this.TxtSearchFor);
            this.Controls.Add(this.LblSearchFor);
            this.Controls.Add(this.LblSearchBy);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.CmbField);
            this.Controls.Add(this.GvReceiveDoctorPanel);
            this.Controls.Add(this.LblShowLastName);
            this.Controls.Add(this.LblShowName);
            this.Controls.Add(this.LblLastName);
            this.Controls.Add(this.LblName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmReservationDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmReservationDashboard";
            ((System.ComponentModel.ISupportInitialize)(this.GvReceiveDoctorPanel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LblName;
        private Label LblLastName;
        private Label LblShowName;
        private Label LblShowLastName;
        private DataGridView GvReceiveDoctorPanel;
        private ComboBox CmbField;
        private Button BtnSearch;
        private Label LblSearchBy;
        private Label LblSearchFor;
        private TextBox TxtSearchFor;
        private Button BtnReserve;
    }
}