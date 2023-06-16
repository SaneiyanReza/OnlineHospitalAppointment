namespace OnlineHospitalAppointment.WinForm.Panel.OnlineHospitalAppointment.Admin
{
    partial class FrmAddAppointmentByExpert
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
            this.AppointmentDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.GvAppointmentCharts = new System.Windows.Forms.DataGridView();
            this.LblTotalAppointment = new System.Windows.Forms.Label();
            this.LblShowTotalAppointment = new System.Windows.Forms.Label();
            this.BtnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GvAppointmentCharts)).BeginInit();
            this.SuspendLayout();
            // 
            // AppointmentDateTimePicker
            // 
            this.AppointmentDateTimePicker.Location = new System.Drawing.Point(12, 307);
            this.AppointmentDateTimePicker.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.AppointmentDateTimePicker.Name = "AppointmentDateTimePicker";
            this.AppointmentDateTimePicker.Size = new System.Drawing.Size(294, 23);
            this.AppointmentDateTimePicker.TabIndex = 10;
            // 
            // GvAppointmentCharts
            // 
            this.GvAppointmentCharts.AllowUserToAddRows = false;
            this.GvAppointmentCharts.AllowUserToDeleteRows = false;
            this.GvAppointmentCharts.AllowUserToOrderColumns = true;
            this.GvAppointmentCharts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GvAppointmentCharts.BackgroundColor = System.Drawing.Color.Silver;
            this.GvAppointmentCharts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GvAppointmentCharts.Location = new System.Drawing.Point(12, 68);
            this.GvAppointmentCharts.Name = "GvAppointmentCharts";
            this.GvAppointmentCharts.ReadOnly = true;
            this.GvAppointmentCharts.RowTemplate.Height = 25;
            this.GvAppointmentCharts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GvAppointmentCharts.Size = new System.Drawing.Size(626, 207);
            this.GvAppointmentCharts.TabIndex = 22;
            // 
            // LblTotalAppointment
            // 
            this.LblTotalAppointment.AutoSize = true;
            this.LblTotalAppointment.Location = new System.Drawing.Point(12, 25);
            this.LblTotalAppointment.Name = "LblTotalAppointment";
            this.LblTotalAppointment.Size = new System.Drawing.Size(112, 15);
            this.LblTotalAppointment.TabIndex = 23;
            this.LblTotalAppointment.Text = "Total Appointment :";
            // 
            // LblShowTotalAppointment
            // 
            this.LblShowTotalAppointment.AutoSize = true;
            this.LblShowTotalAppointment.Location = new System.Drawing.Point(174, 25);
            this.LblShowTotalAppointment.Name = "LblShowTotalAppointment";
            this.LblShowTotalAppointment.Size = new System.Drawing.Size(132, 15);
            this.LblShowTotalAppointment.TabIndex = 24;
            this.LblShowTotalAppointment.Text = "ShowTotalAppointment";
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(401, 307);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(237, 23);
            this.BtnAdd.TabIndex = 25;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // FrmAddAppointmentByExpert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(659, 353);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.LblShowTotalAppointment);
            this.Controls.Add(this.LblTotalAppointment);
            this.Controls.Add(this.GvAppointmentCharts);
            this.Controls.Add(this.AppointmentDateTimePicker);
            this.MaximizeBox = false;
            this.Name = "FrmAddAppointmentByExpert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAddAppointmentByExpert";
            this.Load += new System.EventHandler(this.FrmAddAppointmentByExpert_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GvAppointmentCharts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateTimePicker AppointmentDateTimePicker;
        private DataGridView GvAppointmentCharts;
        private Label LblTotalAppointment;
        private Label LblShowTotalAppointment;
        private Button BtnAdd;
    }
}