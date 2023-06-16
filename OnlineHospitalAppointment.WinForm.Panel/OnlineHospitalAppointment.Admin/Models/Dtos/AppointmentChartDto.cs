namespace OnlineHospitalAppointment.WinForm.Panel.OnlineHospitalAppointment.Admin.Models.Views
{
    public record AppointmentChartDto
    {
        public int Id { get; init; }
        public int UserId { get; init; }
        public string FullName { get; init; }
        public int AppointmentDate { get; init; }
        public string UserName { get; init; }
        public string PhoneNumber { get; init; }
        public string NationalCode { get; init; }
    }
}