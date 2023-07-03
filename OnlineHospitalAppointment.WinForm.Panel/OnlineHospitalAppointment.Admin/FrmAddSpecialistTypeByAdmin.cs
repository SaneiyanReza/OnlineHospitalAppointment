using OnlineHospitalAppointment.WinForm.Panel.Models;

namespace OnlineHospitalAppointment.WinForm.Panel.OnlineHospitalAppointment.Admin
{
    public partial class FrmAddSpecialistTypeByAdmin : Form
    {
        private readonly OnlineHospitalAppointmentDbContext _dbContext;

        public FrmAddSpecialistTypeByAdmin(OnlineHospitalAppointmentDbContext dbContext)
        {
            InitializeComponent();
            _dbContext = dbContext;
        }

        private void AddSpecialistTypeByAdmin_Load(object sender, EventArgs e)
        {
            ComboSpecialistType.DataSource = _dbContext.SpecialistTypes
                .Select(x => x.Specialist)
                .ToArray();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtSpecialistType.Text))
            {
                MessageBox.Show("specialist type must have value");
                return;
            }

            SpecialistType specialistType = new(TxtSpecialistType.Text);

            _dbContext.SpecialistTypes.Add(specialistType);
            _dbContext.SaveChanges();

            BackColor = Color.Green;
            TxtSpecialistType.Text = string.Empty;

            ComboSpecialistType.DataSource = _dbContext.SpecialistTypes
                .Select(x => x.Specialist)
                .ToArray();

            MessageBox.Show($"Successfully!", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);

            BackColor = Color.Empty;
        }
    }
}