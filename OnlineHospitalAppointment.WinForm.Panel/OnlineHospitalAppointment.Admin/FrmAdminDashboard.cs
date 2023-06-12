using AutoMapper;
using Microsoft.EntityFrameworkCore;
using OnlineHospitalAppointment.Dll.Tools.Helpers;
using OnlineHospitalAppointment.WinForm.Panel.Models;
using OnlineHospitalAppointment.WinForm.Panel.OnlineHospitalAppointment.Panel;
using OnlineHospitalAppointment.WinForm.Panel.OnlineHospitalAppointment.Panel.Models.Dtos;
using OnlineHospitalAppointment.WinForm.Panel.OnlineHospitalAppointment.Panel.Models.Views;

namespace OnlineHospitalAppointment.WinForm.Panel.OnlineHospitalAppointment.Admin
{
    public partial class FrmAdminDashboard : Form
    {
        private readonly OnlineHospitalAppointmentDbContext _dbContext;
        private static ExpertView[] view = default;
        private readonly BindingSource bindingSource = new();
        public static int expertId;

        public FrmAdminDashboard(OnlineHospitalAppointmentDbContext dbContext)
        {
            InitializeComponent();
            _dbContext = dbContext;
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

        private void BtnAddExpert_Click(object sender, EventArgs e)
        {
            FrmAddExpertByAdmin frmAddExpertByAdmin = new(_dbContext);
            frmAddExpertByAdmin.ShowDialog();
        }

        private void BtnModifyExpert_Click(object sender, EventArgs e)
        {
            FrmModifyExpertByAdmin frmModifyExpertByAdmin = new(_dbContext);
            frmModifyExpertByAdmin.ShowDialog();
        }

        private void BtnDeleteExpert_Click(object sender, EventArgs e)
        {
            expertId = (int)GvReceiveExpertsPanel.CurrentRow.Cells[0].Value;

            Expert expert = _dbContext.Experts
                .Include(x => x.User)
                .FirstOrDefault(x => x.Id == expertId);

            if (expert is null)
                MessageBox.Show("user not found");

            expert.Delete();
            expert.User.Delete();

            _dbContext.SaveChanges();

            BackColor = Color.Green;
            BindGridViewSource(bindingSource);
            BackColor = Color.Empty;
        }

        private void BtnSuspend_Click(object sender, EventArgs e)
        {
            expertId = (int)GvReceiveExpertsPanel.CurrentRow.Cells[0].Value;

            Expert expert = _dbContext.Experts
                .Include(x => x.User)
                .FirstOrDefault(x => x.Id == expertId);

            if (expert is null)
                MessageBox.Show("user not found");

            expert.Suspend();
            expert.User.Suspend();

            _dbContext.SaveChanges();

            BackColor = Color.Green;
            BindGridViewSource(bindingSource);
            BackColor = Color.Empty;
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
                    _ => GetExperts(),
                };

                BindGridViewSource(bindingSource, true);
            }
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