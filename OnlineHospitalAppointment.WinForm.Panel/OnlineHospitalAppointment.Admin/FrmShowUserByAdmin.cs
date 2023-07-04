using AutoMapper;
using OnlineHospitalAppointment.Dll.Tools.Helpers;
using OnlineHospitalAppointment.WinForm.Panel.Models;
using OnlineHospitalAppointment.WinForm.Panel.OnlineHospitalAppointment.Admin.Models.Dtos;
using OnlineHospitalAppointment.WinForm.Panel.OnlineHospitalAppointment.Admin.Models.Views;

namespace OnlineHospitalAppointment.WinForm.Panel.OnlineHospitalAppointment.Admin
{
    public partial class FrmShowUserByAdmin : Form
    {
        private readonly OnlineHospitalAppointmentDbContext _dbContext;
        private readonly BindingSource bindingSource = new();
        private static UserView[] view = default;

        public FrmShowUserByAdmin(OnlineHospitalAppointmentDbContext dbContext)
        {
            InitializeComponent();
            _dbContext = dbContext;
        }

        private void FrmShowUserByAdmin_Load(object sender, EventArgs e)
        {
            BindGridViewSource(bindingSource);
        }

        private void BindGridViewSource(BindingSource bindingSource, bool isFiltered = default)
        {
            if (!isFiltered)
            {
                bindingSource.DataSource = GetUsers();
            }

            GvReceiveUsersPanel.DataSource = bindingSource;
        }

        private static UserView[] GetUsers()
        {
            Mapper mapper = MapperConfig.InitializeAutomapper();

            UserDto[] users = DapperHelper.Query<UserDto>(AdminScripts.GetUsers);

            view = mapper.Map<UserView[]>(users);

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
                    0 => view.Where(x => x.UserName.Contains(TxtSearchFor.Text)),
                    1 => view.Where(x => x.FullName.Contains(TxtSearchFor.Text)),
                    2 => view.Where(x => x.PhoneNumber.Contains(TxtSearchFor.Text)),
                    _ => GetUsers(),
                };

                BindGridViewSource(bindingSource, true);
            }
        }

        private void BtnDeleteUser_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to delete user?", "Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                int userId = (int)GvReceiveUsersPanel.CurrentRow.Cells[0].Value;

                User user = _dbContext.Users
                    .FirstOrDefault(x => x.Id == userId);

                if (user is null)
                {
                    MessageBox.Show("user not found");
                    return;
                }

                user.IsDelete(true);

                string description = $"delete user by admin userId: {userId}";

                AdminActivityLog adminActivityLog = new(userId, description);

                _dbContext.SaveChanges();

                BackColor = Color.Green;
                BindGridViewSource(bindingSource);
                BackColor = Color.Empty;
            }
        }

        private void BtnSuspend_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to suspend expert?", "Suspend",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                int userId = (int)GvReceiveUsersPanel.CurrentRow.Cells[0].Value;

                User user = _dbContext.Users
                    .FirstOrDefault(x => x.Id == userId);

                if (user is null)
                {
                    MessageBox.Show("user not found");
                    return;
                }

                user.IsSuspend(true);

                string description = $"suspend user by admin userId: {userId}";

                AdminActivityLog adminActivityLog = new(userId, description);

                _dbContext.SaveChanges();

                BackColor = Color.Green;
                BindGridViewSource(bindingSource);
                BackColor = Color.Empty;
            }
        }

        private void BtnTurnOver_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to Turn Over User?", "Turn Over",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                int userId = (int)GvReceiveUsersPanel.CurrentRow.Cells[0].Value;

                User user = _dbContext.Users
                    .FirstOrDefault(x => x.Id == userId);

                if (user is null)
                {
                    MessageBox.Show("user not found");
                    return;
                }

                user.IsDelete(false);
                user.IsSuspend(false);

                string description = $"Turn Over user by admin ,userId: {userId}";

                AdminActivityLog adminActivityLog = new(userId, description);

                _dbContext.SaveChanges();

                BackColor = Color.Green;
                BindGridViewSource(bindingSource);
                BackColor = Color.Empty;
            }
        }
    }
}