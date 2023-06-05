using AutoMapper;
using OnlineHospitalAppointment.Dll.Tools.Helpers;
using OnlineHospitalAppointment.WinForm.Panel.OnlineHospitalAppointment.Panel;
using OnlineHospitalAppointment.WinForm.Panel.OnlineHospitalAppointment.Panel.Models.Dtos;
using OnlineHospitalAppointment.WinForm.Panel.OnlineHospitalAppointment.Panel.Models.Views;

namespace OnlineHospitalAppointment.WinForm.Panel.OnlineHospitalAppointment.Admin
{
    public partial class FrmAdminDashboard : Form
    {
        private static ExpertView[] view = default;
        private readonly BindingSource bindingSource = new();

        public FrmAdminDashboard()
        {
            InitializeComponent();
        }

        private void FrmAdminDashboard_Load(object sender, EventArgs e)
        {
            DapperHelper.QueryMultiple(AdminScripts.GetAdminDashboard, grid =>
            {
                LblShowTotalUsers.Text = grid.ReadFirst<int>().ToString();
                LblShowTotalExperts.Text = grid.ReadFirst<int>().ToString();
                LblShowTotalReservations.Text = grid.ReadFirst<int>().ToString();
            });

            BindGridViewSource(bindingSource);
        }

        private void BindGridViewSource(BindingSource bindingSource, bool isFiltered = default)
        {
            if (!isFiltered)
            {
                bindingSource.DataSource = GetExperts();
            }

            GvReceiveExperts.DataSource = bindingSource;
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

        private void BtnAddExpert_Click(object sender, EventArgs e)
        {

        }
    }
}