using AutoMapper;
using OnlineHospitalAppointment.Dll.Tools.Helpers;
using OnlineHospitalAppointment.WinForm.Panel.OnlineHospitalAppointment.Admin.Models.Views;
using OnlineHospitalAppointment.WinForm.Panel.OnlineHospitalAppointment.Identity;

namespace OnlineHospitalAppointment.WinForm.Panel.OnlineHospitalAppointment.Admin
{
    public partial class FrmExpertDashboard : Form
    {
        private readonly OnlineHospitalAppointmentDbContext _dbContext;
        private static AppointmentChartView[] view = default;
        private readonly BindingSource bindingSource = new();
        private static int userId = FrmIdentity.userId;

        public FrmExpertDashboard(OnlineHospitalAppointmentDbContext dbContext)
        {
            InitializeComponent();
            _dbContext = dbContext;
        }

        private void FrmExpertDashboard_Load(object sender, EventArgs e)
        {
            DapperHelper.QueryMultiple(AdminScripts.GetExpertDashboard, grid =>
            {
                LblFullName.Text = grid.ReadFirst<int>().ToString();
                LblShowReservation.Text = grid.ReadFirst<int>().ToString();
                LblCancelReservation.Text = grid.ReadFirst<int>().ToString();
            });

            BindGridViewSource(bindingSource);
        }

        private void BindGridViewSource(BindingSource bindingSource, bool isFiltered = default)
        {
            if (!isFiltered)
            {
                bindingSource.DataSource = GetExperts();
            }

            GvAppointmentCharts.DataSource = bindingSource;
        }

        private static AppointmentChartView[] GetExperts()
        {
            Mapper mapper = MapperConfig.InitializeAutomapper();

            AppointmentChartDto[] experts = DapperHelper.Query<AppointmentChartDto>(AdminScripts.GetAppointmentChart, new
            {
                ExpertID = userId
            });

            view = mapper.Map<AppointmentChartView[]>(experts);

            return view;
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
                    1 => view.Where(x => x.UserName.Contains(TxtSearchFor.Text)),
                    2 => view.Where(x => x.AppointmentDate.Contains(TxtSearchFor.Text)),
                    _ => GetExperts(),
                };

                BindGridViewSource(bindingSource, true);
            }
        }

        private void BtnAddAppointment_Click(object sender, EventArgs e)
        {
        }
    }
}