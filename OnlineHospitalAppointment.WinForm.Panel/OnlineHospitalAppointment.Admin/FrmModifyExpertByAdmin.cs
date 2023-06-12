using Microsoft.EntityFrameworkCore;
using OnlineHospitalAppointment.WinForm.Panel.Models;

namespace OnlineHospitalAppointment.WinForm.Panel.OnlineHospitalAppointment.Admin
{
    public partial class FrmModifyExpertByAdmin : Form
    {
        private OnlineHospitalAppointmentDbContext _dbContext;
        private readonly int expertId = FrmAdminDashboard.expertId;

        public FrmModifyExpertByAdmin(OnlineHospitalAppointmentDbContext dbContext)
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
                MessageBox.Show("user not found");

            TxtUserName.Text = expert.User.UserName;
            TxtName.Text = expert.User.Name;
            TxtLastName.Text = expert.User.LastName;
            TxtNationalCode.Text = expert.User.NationalCode;
            TxtPhoneNumber.Text = expert.User.PhoneNumber;
            DateOfBirthTimePicker.Text = expert.User.BirthDay;
            RbIsFemale.Checked = !expert.User.IsMale;

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
                MessageBox.Show("user not found");

            string fullName = $"{expert.User.Name} {expert.User.LastName}";

            int specialistTypeId = _dbContext.SpecialistTypes
                   .Where(x => x.Specialist.Equals(ComboSpecialistType.SelectedText))
                   .Select(x => x.Id)
                   .FirstOrDefault();

            int cityId = _dbContext.Cities
                .Where(x => x.Name.Equals(ComboCity.SelectedText))
                .Select(x => x.Id)
                .FirstOrDefault();

            expert.ModifyExpertByAdmin(fullName, specialistTypeId, cityId);

            bool isMale = RbIsMale.Checked;
            string birthDay = DateOfBirthTimePicker.Value.Date.ToString("yyyy/MM/dd");

            expert.User.ModifyUserByAdmin(TxtNationalCode.Text, TxtName.Text, TxtLastName.Text,
                isMale, TxtPhoneNumber.Text, birthDay);

            _dbContext.SaveChanges();
        }
    }
}