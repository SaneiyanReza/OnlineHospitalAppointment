using AutoMapper;
using OnlineHospitalAppointment.Dll.Tools;
using OnlineHospitalAppointment.WinForm.Panel.OnlineHospitalAppointment.Account;
using OnlineHospitalAppointment.WinForm.Panel.OnlineHospitalAppointment.Panel.Models.Dtos;
using OnlineHospitalAppointment.WinForm.Panel.OnlineHospitalAppointment.Panel.Models.Views;
using System.Data;

namespace OnlineHospitalAppointment.WinForm.Panel.OnlineHospitalAppointment.Panel
{
    public partial class FrmReservationDashboard : Form
    {
        private static ExpertView[] view = default;
        private readonly BindingSource bindingSource = new();

        public FrmReservationDashboard()
        {
            InitializeComponent();
        }

        private void FrmReservationDashboard_Load(object sender, EventArgs e)
        {
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

                BindGridViewSource(bindingSource , true);
            }
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

        private void BindGridViewSource(BindingSource bindingSource, bool isFiltered = default)
        {
            if (!isFiltered)
            {
                bindingSource.DataSource = GetExperts();
            }

            GvReceiveExpertsPanel.DataSource = bindingSource;
        }
    }
}