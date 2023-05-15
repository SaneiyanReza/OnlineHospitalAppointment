using AutoMapper;
using OnlineHospitalAppointment.Dll.Tools;
using OnlineHospitalAppointment.WinForm.Panel.OnlineHospitalAppointment.Account;
using OnlineHospitalAppointment.WinForm.Panel.OnlineHospitalAppointment.Identity;
using OnlineHospitalAppointment.WinForm.Panel.OnlineHospitalAppointment.Panel.Models.Dtos;
using OnlineHospitalAppointment.WinForm.Panel.OnlineHospitalAppointment.Panel.Models.Views;

namespace OnlineHospitalAppointment.WinForm.Panel.OnlineHospitalAppointment.Panel
{
    public partial class FrmUserAppointments : Form
    {
        private static UserAppointmentView[] view = default;
        private readonly BindingSource bindingSource = new();

        public FrmUserAppointments()
        {
            InitializeComponent();
        }

        private void FrmUserAppointments_Load(object sender, EventArgs e)
        {
            LblShowUserName.Text = FrmIdentity.userName;
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
                    3 => view.Where(x => x.ReservedDateTime.Contains(TxtSearchFor.Text)),
                    _ => GetUserAppointments(),
                };

                BindGridViewSource(bindingSource, true);
            }
        }

        private void BindGridViewSource(BindingSource bindingSource, bool isFiltered = default)
        {
            if (!isFiltered)
            {
                bindingSource.DataSource = GetUserAppointments();
            }

            GvReceiveAppointmentReport.DataSource = bindingSource;
        }

        private static UserAppointmentView[] GetUserAppointments()
        {
            Mapper mapper = MapperConfig.InitializeAutomapper();

            UserAppointmentDto[] userAppointments = DapperHelper.Query<UserAppointmentDto>(PanelScripts.GetUserAppointment, new
            {
                UtcNow = DateTime.UtcNow.ToUnixTime(),
                FrmIdentity.userId
            });

            view = mapper.Map<UserAppointmentView[]>(userAppointments);

            return view;
        }

        private void BtnCancelReserve_Click(object sender, EventArgs e)
        {
            int reservationLogId = (int)GvReceiveAppointmentReport.CurrentRow.Cells[0].Value;


        }
    }
}