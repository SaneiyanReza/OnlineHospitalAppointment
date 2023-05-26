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
        private static ExpertView[] view = default;
        private readonly BindingSource bindingSource = new();
        private readonly string userName = FrmIdentity.userName;
        private readonly int userId = FrmIdentity.userId;

        public FrmReservationDashboard()
        {
            InitializeComponent();
        }

        private void FrmReservationDashboard_Load(object sender, EventArgs e)
        {
            LblShowUserName.Text = userName;
            LblShowFullName.Text = FrmManageAccount.fullName;
            CmbField.SelectedIndex = 0;
            BindGridViewSource(bindingSource);
        }

        private void TxtSearchFor_KeyDown(object sender, KeyEventArgs e)
        {
            if (string.IsNullOrEmpty(TxtSearchFor.Text))
            {
                BindGridViewSource(bindingSource);
            }
            else
            {
                bindingSource.DataSource = CmbField.SelectedIndex switch
                {
                    0 => view.Where(x => x.FullName.Contains(TxtSearchFor.Text)),
                    1 => view.Where(x => x.Specialist.Contains(TxtSearchFor.Text)),
                    2 => view.Where(x => x.Address.Contains(TxtSearchFor.Text)),
                    3 => view.Where(x => x.FreeDateTime.Contains(TxtSearchFor.Text)),
                    _ => GetExperts(),
                };

                BindGridViewSource(bindingSource, true);
            }
        }

        private void BtnReserve_Click(object sender, EventArgs e)
        {
            ReservationLogDto reservationLog = new();
            string trackingCode = string.Empty;
            int expertId = (int)GvReceiveExpertsPanel.CurrentRow.Cells[0].Value;
            bool canReserve = true;

            DapperHelper.QueryMultiple(PanelScripts.GetReservationLogData, gride =>
            {
                reservationLog.ExpertTimeReserved = gride.Read<int>().ToArray() ??
                    Array.Empty<int>();

                reservationLog.ExpertFreeTime = gride.ReadFirst<int>();

                reservationLog.TrackingCodes = gride.Read<string>().ToArray() ?? Array.Empty<string>();
            }, new
            {
                userId,
                expertId
            });

            for (int i = 0; i < reservationLog.ExpertTimeReserved.Length; i++)
            {
                int ExpertFreeTimeThirtyMinutesLater = DateTimeHelper
                    .UnixTimeToDateTime(reservationLog.ExpertFreeTime).AddMinutes(30).ToUnixTime();

                if (reservationLog.ExpertTimeReserved[i] >= reservationLog.ExpertFreeTime &&
                    reservationLog.ExpertTimeReserved[i] <= ExpertFreeTimeThirtyMinutesLater)
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
                    expertId,
                    ReservedAt = DateTimeHelper.ToUnixTime(DateTime.UtcNow),
                    trackingCode
                });

                BackColor = Color.Green;
                GvReceiveExpertsPanel.BackgroundColor = Color.ForestGreen;

                MessageBox.Show($"The appointment was successfully received.\n Tracking Code : {trackingCode}",
                    "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);

                BackColor = Color.Empty;
                GvReceiveExpertsPanel.BackgroundColor = Color.Silver;

                BindGridViewSource(bindingSource);
            }
        }

        private void BtnReport_Click(object sender, EventArgs e)
        {
            FrmUserAppointments frmUserAppointments = new();
            this.Close();
            frmUserAppointments.ShowDialog();
        }

        private void BindGridViewSource(BindingSource bindingSource, bool isFiltered = default)
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

            ExpertDto[] experts = DapperHelper.Query<ExpertDto>(PanelScripts.GetExperts, new
            {
                UtcNow = DateTime.UtcNow.ToUnixTime()
            });

            view = mapper.Map<ExpertView[]>(experts);

            return view;
        }
    }
}