namespace OnlineHospitalAppointment.WinForm.Panel.OnlineHospitalAppointment.Panel
{
    partial class FrmUserAppointments
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
            this.LblFullName = new System.Windows.Forms.Label();
            this.LblShowUserName = new System.Windows.Forms.Label();
            this.LblShowFullName = new System.Windows.Forms.Label();
            this.TxtSearchFor = new System.Windows.Forms.TextBox();
            this.LblSearchFor = new System.Windows.Forms.Label();
            this.LblSearchBy = new System.Windows.Forms.Label();
            this.CmbField = new System.Windows.Forms.ComboBox();
            this.GvReceiveAppointmentReport = new System.Windows.Forms.DataGridView();
            this.BtnCancelReserve = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GvReceiveAppointmentReport)).BeginInit();
            this.SuspendLayout();
            // 
            // LblUserName
            // 
            this.LblUserName.AutoSize = true;
            this.LblUserName.Location = new System.Drawing.Point(12, 25);
            this.LblUserName.Name = "LblUserName";
            this.LblUserName.Size = new System.Drawing.Size(71, 15);
            this.LblUserName.TabIndex = 0;
            this.LblUserName.Text = "User Name :";
            // 
            // LblFullName
            // 
            this.LblFullName.AutoSize = true;
            this.LblFullName.Location = new System.Drawing.Point(12, 57);
            this.LblFullName.Name = "LblFullName";
            this.LblFullName.Size = new System.Drawing.Size(67, 15);
            this.LblFullName.TabIndex = 1;
            this.LblFullName.Text = "Full Name :";
            // 
            // LblShowUserName
            // 
            this.LblShowUserName.AutoSize = true;
            this.LblShowUserName.Location = new System.Drawing.Point(102, 25);
            this.LblShowUserName.Name = "LblShowUserName";
            this.LblShowUserName.Size = new System.Drawing.Size(91, 15);
            this.LblShowUserName.TabIndex = 2;
            this.LblShowUserName.Text = "ShowUserName";
            // 
            // LblShowFullName
            // 
            this.LblShowFullName.AutoSize = true;
            this.LblShowFullName.Location = new System.Drawing.Point(102, 57);
            this.LblShowFullName.Name = "LblShowFullName";
            this.LblShowFullName.Size = new System.Drawing.Size(87, 15);
            this.LblShowFullName.TabIndex = 3;
            this.LblShowFullName.Text = "ShowFullName";
            // 
            // TxtSearchFor
            // 
            this.TxtSearchFor.Location = new System.Drawing.Point(479, 52);
            this.TxtSearchFor.Name = "TxtSearchFor";
            this.TxtSearchFor.Size = new System.Drawing.Size(223, 23);
            this.TxtSearchFor.TabIndex = 14;
            this.TxtSearchFor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtSearchFor_KeyDown);
            // 
            // LblSearchFor
            // 
            this.LblSearchFor.AutoSize = true;
            this.LblSearchFor.Location = new System.Drawing.Point(397, 55);
            this.LblSearchFor.Name = "LblSearchFor";
            this.LblSearchFor.Size = new System.Drawing.Size(68, 15);
            this.LblSearchFor.TabIndex = 13;
            this.LblSearchFor.Text = "Search For :";
            // 
            // LblSearchBy
            // 
            this.LblSearchBy.AutoSize = true;
            this.LblSearchBy.Location = new System.Drawing.Point(397, 25);
            this.LblSearchBy.Name = "LblSearchBy";
            this.LblSearchBy.Size = new System.Drawing.Size(64, 15);
            this.LblSearchBy.TabIndex = 12;
            this.LblSearchBy.Text = "Search By :";
            // 
            // CmbField
            // 
            this.CmbField.BackColor = System.Drawing.SystemColors.Control;
            this.CmbField.FormattingEnabled = true;
            this.CmbField.Items.AddRange(new object[] {
            "FullName",
            "Specialist",
            "Address",
            "Reserved DateTime"});
            this.CmbField.Location = new System.Drawing.Point(479, 22);
            this.CmbField.Name = "CmbField";
            this.CmbField.Size = new System.Drawing.Size(223, 23);
            this.CmbField.TabIndex = 11;
            // 
            // GvReceiveAppointmentReport
            // 
            this.GvReceiveAppointmentReport.AllowUserToAddRows = false;
            this.GvReceiveAppointmentReport.AllowUserToDeleteRows = false;
            this.GvReceiveAppointmentReport.AllowUserToOrderColumns = true;
            this.GvReceiveAppointmentReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GvReceiveAppointmentReport.BackgroundColor = System.Drawing.Color.Silver;
            this.GvReceiveAppointmentReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GvReceiveAppointmentReport.Location = new System.Drawing.Point(12, 95);
            this.GvReceiveAppointmentReport.Name = "GvReceiveAppointmentReport";
            this.GvReceiveAppointmentReport.ReadOnly = true;
            this.GvReceiveAppointmentReport.RowTemplate.Height = 25;
            this.GvReceiveAppointmentReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GvReceiveAppointmentReport.Size = new System.Drawing.Size(690, 288);
            this.GvReceiveAppointmentReport.TabIndex = 10;
            this.GvReceiveAppointmentReport.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GvReceiveAppointmentReport_MouseClick);
            // 
            // BtnCancelReserve
            // 
            this.BtnCancelReserve.Location = new System.Drawing.Point(605, 401);
            this.BtnCancelReserve.Name = "BtnCancelReserve";
            this.BtnCancelReserve.Size = new System.Drawing.Size(97, 37);
            this.BtnCancelReserve.TabIndex = 15;
            this.BtnCancelReserve.Text = "Cancel Reserve";
            this.BtnCancelReserve.UseVisualStyleBackColor = true;
            this.BtnCancelReserve.Click += new System.EventHandler(this.BtnCancelReserve_Click);
            // 
            // FrmUserAppointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(716, 450);
            this.Controls.Add(this.BtnCancelReserve);
            this.Controls.Add(this.TxtSearchFor);
            this.Controls.Add(this.LblSearchFor);
            this.Controls.Add(this.LblSearchBy);
            this.Controls.Add(this.CmbField);
            this.Controls.Add(this.GvReceiveAppointmentReport);
            this.Controls.Add(this.LblShowFullName);
            this.Controls.Add(this.LblShowUserName);
            this.Controls.Add(this.LblFullName);
            this.Controls.Add(this.LblUserName);
            this.MaximizeBox = false;
            this.Name = "FrmUserAppointments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmUserAppointments";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmUserAppointments_FormClosing);
            this.Load += new System.EventHandler(this.FrmUserAppointments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GvReceiveAppointmentReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LblUserName;
        private Label LblFullName;
        private Label LblShowUserName;
        private Label LblShowFullName;
        private TextBox TxtSearchFor;
        private Label LblSearchFor;
        private Label LblSearchBy;
        private ComboBox CmbField;
        private DataGridView GvReceiveAppointmentReport;
        private Button BtnCancelReserve;
    }
}