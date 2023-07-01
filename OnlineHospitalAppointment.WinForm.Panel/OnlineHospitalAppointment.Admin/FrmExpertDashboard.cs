using AutoMapper;
using OnlineHospitalAppointment.Dll.Tools.Helpers;
using OnlineHospitalAppointment.WinForm.Panel.OnlineHospitalAppointment.Admin.Models.Views;
using OnlineHospitalAppointment.WinForm.Panel.OnlineHospitalAppointment.Identity;
using OnlineHospitalAppointment.WinForm.Panel.OnlineHospitalAppointment.Identity.Enums;
using OnlineHospitalAppointment.WinForm.Panel.OnlineHospitalAppointment.Panel;

namespace OnlineHospitalAppointment.WinForm.Panel.OnlineHospitalAppointment.Admin
{
    public partial class FrmExpertDashboard : Form
    {
        private readonly OnlineHospitalAppointmentDbContext _dbContext;
        private static AdminAppointmentChartView[] view = default;
        private readonly BindingSource bindingSource = new();
        private static readonly int userId = FrmIdentity.userId;
        public static RoleId? roleId = default;

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
                bindingSource.DataSource = GetAppointmentChart();
            }

            GvAppointmentCharts.DataSource = bindingSource;
        }

        private static AdminAppointmentChartView[] GetAppointmentChart()
        {
            Mapper mapper = MapperConfig.InitializeAutomapper();

            AdminAppointmentChartDto[] experts = DapperHelper.Query<AdminAppointmentChartDto>(AdminScripts.GetAppointmentChart, new
            {
                ExpertID = userId
            });

            view = mapper.Map<AdminAppointmentChartView[]>(experts);

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
                    _ => GetAppointmentChart(),
                };

                BindGridViewSource(bindingSource, true);
            }
        }

        private void BtnAddAppointment_Click(object sender, EventArgs e)
        {
            FrmAddAppointmentByExpert frmAddAppointment = new(_dbContext);
            frmAddAppointment.ShowDialog();
        }

        private void BtnCancelAppointment_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to cancel appointment?", "Warning"
               , MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.OK)
            {
                int appointmentChartId = (int)GvAppointmentCharts.CurrentRow.Cells[0].Value; ;
                string description = "وقت ملاقات توسط متخصص لغو شد";

                DapperHelper.ExecuteNonQuery(PanelScripts.SetCancelAppointment, new
                {
                    appointmentChartId,
                    description,
                    typeCanceled = 2
                });

                BindGridViewSource(bindingSource);
            }
        }

        private void BtnModifyProfile_Click(object sender, EventArgs e)
        {
            FrmModifyExpert frmModifyExpert = new(_dbContext);
            roleId = RoleId.Expert;
            frmModifyExpert.ShowDialog();
        }
    }
}