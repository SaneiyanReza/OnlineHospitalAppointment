using Microsoft.EntityFrameworkCore;
using OnlineHospitalAppointment.WinForm.Panel.Models;
using OnlineHospitalAppointment.WinForm.Panel.OnlineHospitalAppointment.Identity.Enums;

namespace OnlineHospitalAppointment.WinForm.Panel.OnlineHospitalAppointment.Admin
{
    public partial class FrmModifyExpert : Form
    {
        private OnlineHospitalAppointmentDbContext _dbContext;
        private static int expertId = FrmAdminDashboard.expertId;
        private static RoleId roleId = (RoleId)(FrmAdminDashboard.roleId ?? FrmExpertDashboard.roleId);

        public FrmModifyExpert(OnlineHospitalAppointmentDbContext dbContext)
        {
            InitializeComponent();
            _dbContext = dbContext;
        }

        private void FrmModifyExpertByAdmin_Load(object sender, EventArgs e)
        {
            SpecialistType[] specialists = _dbContext.SpecialistTypes
                .ToArray();
            City[] cities = _dbContext.Cities
                .ToArray();

            Expert expert = _dbContext.Experts
                .Include(x => x.User)
                .FirstOrDefault(x => x.Id == expertId);

            if (expert is null)
            {
                MessageBox.Show("user not found");
                this.Close();
                return;
            }

            TxtUserName.Text = expert.User.UserName;
            TxtName.Text = expert.User.Name;
            TxtLastName.Text = expert.User.LastName;
            TxtNationalCode.Text = expert.User.NationalCode;
            TxtPhoneNumber.Text = expert.User.PhoneNumber;
            DateOfBirthTimePicker.Text = expert.User.BirthDay;
            RbIsMale.Checked = expert.User.IsMale;
            RbIsFemale.Checked = !RbIsMale.Checked;

            ComboSpecialistType.DataSource = specialists
                .Select(x => x.Specialist)
                .ToArray();

            ComboSpecialistType.DisplayMember = specialists
                .Where(x => x.Id == expert.SpecialistTypeId)
                .Select(x => x.Specialist)
                .FirstOrDefault();

            ComboCity.DataSource = cities
                .Select(x => x.Name)
                .ToArray();

            ComboCity.DisplayMember = cities
                .Where(x => x.Id == expert.CityId)
                .Select(x => x.Name)
                .FirstOrDefault();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            Expert expert = _dbContext.Experts
                .Include(x => x.User)
                .FirstOrDefault(x => x.Id == expertId);

            if (expert is null)
            {
                MessageBox.Show("user not found");
                return;
            }

            string fullName = $"{expert.User.Name} {expert.User.LastName}";

            int specialistTypeId = _dbContext.SpecialistTypes
                   .Where(x => x.Specialist.Equals(ComboSpecialistType.SelectedValue))
                   .Select(x => x.Id)
                   .FirstOrDefault();

            int cityId = _dbContext.Cities
                .Where(x => x.Name.Equals(ComboCity.SelectedValue))
                .Select(x => x.Id)
                .FirstOrDefault();

            expert.ModifyExpertByAdmin(fullName, specialistTypeId, cityId);

            bool isMale = RbIsMale.Checked;
            string birthDay = DateOfBirthTimePicker.Value.Date.ToString("yyyy/MM/dd");

            expert.User.ModifyUserByAdmin(TxtNationalCode.Text, TxtName.Text, TxtLastName.Text,
                isMale, TxtPhoneNumber.Text, birthDay);

            string description = roleId == RoleId.GodAdmin ? "تغییر پروفایل متخصص توسط ادمین"
                : "تغییر پروفایل متخصص";

            AdminActivityLog adminActivityLog = new(expertId, description);

            _dbContext.AdminActivityLogs.Add(adminActivityLog);
            _dbContext.SaveChanges();

            BackColor = Color.Green;

            MessageBox.Show($"Successfully!", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);

            BackColor = Color.Empty;
        }
    }
}