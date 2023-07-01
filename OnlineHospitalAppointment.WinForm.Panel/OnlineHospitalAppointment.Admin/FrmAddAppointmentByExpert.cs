using OnlineHospitalAppointment.Dll.Tools.Helpers;
using OnlineHospitalAppointment.WinForm.Panel.Models;
using OnlineHospitalAppointment.WinForm.Panel.OnlineHospitalAppointment.Identity;

namespace OnlineHospitalAppointment.WinForm.Panel.OnlineHospitalAppointment.Admin
{
    public partial class FrmAddAppointmentByExpert : Form
    {
        private readonly OnlineHospitalAppointmentDbContext _dbContext;
        private readonly BindingSource bindingSource = new();
        private static readonly int userId = FrmIdentity.userId;

        public FrmAddAppointmentByExpert(OnlineHospitalAppointmentDbContext dbContext)
        {
            InitializeComponent();
            _dbContext = dbContext;
        }

        private void FrmAddAppointmentByExpert_Load(object sender, EventArgs e)
        {
            BindGridViewSource(bindingSource);

            LblShowTotalAppointment.Text = GetAppointmentCharts().count.ToString();
        }

        private void BindGridViewSource(BindingSource bindingSource)
        {
            GvAppointmentCharts.DataSource = bindingSource;
        }

        private (int count, AppointmentChart[] charts) GetAppointmentCharts()
        {
            AppointmentChart[] appointmentCharts = _dbContext.AppointmentCharts
                .Where(x => x.ExpertId == userId)
                .ToArray();

            int count = appointmentCharts.Length;

            return (count, appointmentCharts);
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            DateTime lastCharts = DateTimeHelper.UnixTimeToDate(GetAppointmentCharts().charts
                .OrderByDescending(x => x.AppointmentDate)
                .Select(x => x.AppointmentDate)
                .FirstOrDefault());

            DateTime timePicker = AppointmentDateTimePicker.Value;

            if (lastCharts.AddMinutes(15) < timePicker)
                MessageBox.Show("The time interval should be at least more than a quarter");

            if (lastCharts.AddDays(7) > timePicker)
                MessageBox.Show("The maximum time interval is one week");

            AppointmentChart chart = new(userId, DateTimeHelper.ToUnixTime(timePicker));
            _dbContext.AppointmentCharts.Add(chart);

            _dbContext.SaveChanges();
        }
    }
}