using AutoMapper;
using OnlineHospitalAppointment.Dll.Tools.Helpers;
using OnlineHospitalAppointment.WinForm.Panel.Models;
using OnlineHospitalAppointment.WinForm.Panel.OnlineHospitalAppointment.Admin.Models.Dtos;
using OnlineHospitalAppointment.WinForm.Panel.OnlineHospitalAppointment.Admin.Models.Views;

namespace OnlineHospitalAppointment.WinForm.Panel.OnlineHospitalAppointment.Admin
{
    public partial class FrmAddAppointmentByExpert : Form
    {
        private readonly OnlineHospitalAppointmentDbContext _dbContext;
        private readonly BindingSource bindingSource = new();
        private static ExpertAddAppointmentChartView[] view = default;

        public FrmAddAppointmentByExpert(OnlineHospitalAppointmentDbContext dbContext)
        {
            InitializeComponent();
            _dbContext = dbContext;
        }

        private void FrmAddAppointmentByExpert_Load(object sender, EventArgs e)
        {
            BindGridViewSource();

            LblShowTotalAppointment.Text = GetAppointmentCharts().count.ToString();
        }

        private void BindGridViewSource()
        {
            GvAppointmentCharts.DataSource = GetExpertAppointmentCharts();
        }

        private static ExpertAddAppointmentChartView[] GetExpertAppointmentCharts()
        {
            int expertId = FrmExpertDashboard.expertId;

            Mapper mapper = MapperConfig.InitializeAutomapper();

            ExpertAddAppointmentChartDto[] experts = DapperHelper.Query<ExpertAddAppointmentChartDto>
                (AdminScripts.GetExpertAppointmentChart, new
                {
                    expertId
                });

            view = mapper.Map<ExpertAddAppointmentChartView[]>(experts);

            return view;
        }

        private (int count, AppointmentChart[] charts) GetAppointmentCharts()
        {
            int expertId = FrmExpertDashboard.expertId;

            AppointmentChart[] appointmentCharts = _dbContext.AppointmentCharts
                .Where(x => x.ExpertId == expertId)
                .ToArray();

            int count = appointmentCharts.Length;

            return (count, appointmentCharts);
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            int expertId = FrmExpertDashboard.expertId;

            DateTime timePicker = AppointmentDateTimePicker.Value;

            (int count, AppointmentChart[] charts) = GetAppointmentCharts();

            if (count > 0)
            {
                DateTime lastCharts = DateTimeHelper.UnixTimeToDate(charts
                    .OrderByDescending(x => x.AppointmentDate)
                    .Select(x => x.AppointmentDate)
                    .FirstOrDefault());

                bool betweenFifteenMinute = lastCharts.AddMinutes(15) > timePicker && lastCharts < timePicker;

                if (betweenFifteenMinute)
                {
                    MessageBox.Show("The time interval should be at least more than a quarter");
                    return;
                }

                DateTime now = DateTime.Now;
                bool betweenOneWeek = now.AddDays(7) > timePicker && now < timePicker;

                if (!betweenOneWeek)
                {
                    MessageBox.Show("The maximum time interval is one week");
                    return;
                }
            }

            AppointmentChart chart = new(expertId, DateTimeHelper.ToUnixTime(timePicker));
            _dbContext.AppointmentCharts.Add(chart);

            _dbContext.SaveChanges();

            BackColor = Color.Green;

            BindGridViewSource();

            MessageBox.Show($"Succsessfully!", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);

            BackColor = Color.Empty;
        }
    }
}