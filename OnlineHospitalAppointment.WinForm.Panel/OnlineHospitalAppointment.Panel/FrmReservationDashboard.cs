using AutoMapper;
using OnlineHospitalAppointment.Dll.Tools.Helpers;
using OnlineHospitalAppointment.WinForm.Panel.OnlineHospitalAppointment.Account;
using OnlineHospitalAppointment.WinForm.Panel.OnlineHospitalAppointment.Identity;
using OnlineHospitalAppointment.WinForm.Panel.OnlineHospitalAppointment.Panel.Models.Dtos;
using OnlineHospitalAppointment.WinForm.Panel.OnlineHospitalAppointment.Panel.Models.Views;
using System.Data;

namespace OnlineHospitalAppointment.WinForm.Panel.OnlineHospitalAppointment.Panel
{
    public partial class FrmReservationDashboard : Form
    {
        private static ExpertView[] expertViews = default;
        private static UserAppointmentChartView[] appointmentChartViews = default;
        private readonly BindingSource bindingSource = new();
        private readonly string userName = FrmIdentity.userName;
        private readonly int userId = FrmIdentity.userId;
        private bool isEntry = default;
        private int currentExpertId = default;

        private readonly OnlineHospitalAppointmentDbContext _dbContext;

        public FrmReservationDashboard(OnlineHospitalAppointmentDbContext dbContext)
        {
            InitializeComponent();
            _dbContext = dbContext;
        }

        private void FrmReservationDashboard_Load(object sender, EventArgs e)
        {
            LblShowUserName.Text = userName;
            LblShowFullName.Text = FrmManageAccount.fullName;
            CmbField.SelectedIndex = 0;
            BindExpertGridViewSource(bindingSource);
        }

        private void TxtSearchFor_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtSearchFor.Text))
            {
                if (isEntry)
                    BindAppointmentChartGridViewSource(bindingSource);
                else
                    BindExpertGridViewSource(bindingSource);
            }
            else
            {
                if (isEntry)
                {
                    bindingSource.DataSource = CmbField.SelectedIndex switch
                    {
                        0 => appointmentChartViews.Where(x => x.AppointmentDate.Contains(TxtSearchFor.Text)),
                        _ => GetAppointmentChart(),
                    };

                    BindAppointmentChartGridViewSource(bindingSource, true);
                }
                else
                {
                    bindingSource.DataSource = CmbField.SelectedIndex switch
                    {
                        0 => expertViews.Where(x => x.FullName.Contains(TxtSearchFor.Text)),
                        1 => expertViews.Where(x => x.Specialist.Contains(TxtSearchFor.Text)),
                        2 => expertViews.Where(x => x.Address.Contains(TxtSearchFor.Text)),
                        _ => GetExperts(),
                    };

                    BindExpertGridViewSource(bindingSource, true);
                }
            }
        }

        private void BtnReserve_Click(object sender, EventArgs e)
        {
            ReservationLogDto reservationLog = new();
            string trackingCode = string.Empty;
            int appointmentChartId = (int)GvReceiveExpertsPanel.CurrentRow.Cells[0].Value;
            bool canReserve = true;

            DapperHelper.QueryMultiple(PanelScripts.GetReservationLogData, gride =>
            {
                reservationLog.SelectAppointmentDate = gride.ReadFirst<int>();

                reservationLog.UserAppointmentDates = gride.Read<int>().ToArray() ?? Array.Empty<int>();

                reservationLog.TrackingCodes = gride.Read<string>().ToArray() ?? Array.Empty<string>();
            }, new
            {
                userId,
                appointmentChartId
            });

            for (int i = 0; i < reservationLog.UserAppointmentDates.Length; i++)
            {
                int userAppointmentFifteenMinutesLater = DateTimeHelper
                    .UnixTimeToDate(reservationLog.UserAppointmentDates[i]).AddMinutes(15).ToUnixTime();

                if (userAppointmentFifteenMinutesLater >= reservationLog.SelectAppointmentDate &&
                    reservationLog.UserAppointmentDates[i] <= reservationLog.SelectAppointmentDate)
                {
                    canReserve = false;
                    break;
                }
            }

            if (!canReserve)
            {
                MessageBox.Show("You cannot make a reservation because there is a time conflict!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                do
                {
                    trackingCode = RandomGenerator.GetUniqueCode();
                } while (reservationLog.TrackingCodes.Contains(trackingCode));

                DapperHelper.ExecuteNonQuery(PanelScripts.SetReservation, new
                {
                    userId,
                    appointmentChartId,
                    ReservedAt = DateTimeHelper.ToUnixTime(DateTime.UtcNow),
                    trackingCode
                });

                BackColor = Color.Green;
                GvReceiveExpertsPanel.BackgroundColor = Color.ForestGreen;

                BindExpertGridViewSource(bindingSource);

                MessageBox.Show($"The appointment was successfully received.\n Tracking Code : {trackingCode}",
                    "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);

                BackColor = Color.Empty;
                GvReceiveExpertsPanel.BackgroundColor = Color.Silver;

                isEntry = false;
                BtnReserve.Enabled = false;
                BtnBack.Enabled = false;
                BtnEntry.Enabled = true;
            }
        }

        private void BtnReport_Click(object sender, EventArgs e)
        {
            FrmUserAppointments frmUserAppointments = new(_dbContext);
            this.Close();
            frmUserAppointments.ShowDialog();
        }

        private void BtnEditProfile_Click(object sender, EventArgs e)
        {
            FrmManageAccount frmManageAccount = new(_dbContext);
            this.Close();
            frmManageAccount.ShowDialog();
        }

        private void BtnEntry_Click(object sender, EventArgs e)
        {
            currentExpertId = (int)GvReceiveExpertsPanel.CurrentRow.Cells[0].Value;
            isEntry = true;

            BindAppointmentChartGridViewSource(bindingSource);

            BtnReserve.Enabled = true;
            BtnBack.Enabled = true;
            BtnEntry.Enabled = false;

            CmbField.Text = string.Empty;
            CmbField.Items.Clear();
            CmbField.Items.Add("Appointment Date");
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            isEntry = false;

            BindExpertGridViewSource(bindingSource);

            BtnReserve.Enabled = false;
            BtnBack.Enabled = false;
            BtnEntry.Enabled = true;

            CmbField.Text = string.Empty;
            CmbField.Items.Clear();
            CmbField.Items.Add("FullName");
            CmbField.Items.Add("Specialist");
            CmbField.Items.Add("Address");
        }

        private void BindExpertGridViewSource(BindingSource bindingSource, bool isFiltered = default)
        {
            if (!isFiltered)
            {
                bindingSource.DataSource = GetExperts();
            }

            GvReceiveExpertsPanel.DataSource = bindingSource;
        }

        private static ExpertView[] GetExperts()
        {
            Mapper mapper = MapperConfig.InitializeAutomapper();

            ExpertDto[] experts = DapperHelper.Query<ExpertDto>(PanelScripts.GetExperts);

            expertViews = mapper.Map<ExpertView[]>(experts);

            return expertViews;
        }

        private void BindAppointmentChartGridViewSource(BindingSource bindingSource, bool isFiltered = default)
        {
            if (!isFiltered)
            {
                bindingSource.DataSource = GetAppointmentChart();
            }

            GvReceiveExpertsPanel.DataSource = bindingSource;
        }

        private UserAppointmentChartView[] GetAppointmentChart()
        {
            int expertId = isEntry ? currentExpertId : (int)(GvReceiveExpertsPanel.CurrentRow?.Cells[0]?.Value ?? currentExpertId);
            currentExpertId = expertId;

            Mapper mapper = MapperConfig.InitializeAutomapper();

            UserAppointmentChartDto[] appointmentCharts = DapperHelper.Query<UserAppointmentChartDto>(PanelScripts.GetAppointmentChart,
                new
                {
                    ExpertId = expertId,
                    AppointmentDate = DateTime.UtcNow.AddMinutes(15).ToUnixTime()
                });

            appointmentChartViews = mapper.Map<UserAppointmentChartView[]>(appointmentCharts);

            return appointmentChartViews;
        }

        private void BtnEditIdentity_Click(object sender, EventArgs e)
        {
            FrmEditIdentity frmEditIdentity = new(_dbContext);
            frmEditIdentity.ShowDialog();
        }
    }
}