namespace OnlineHospitalAppointment.WinForm.Panel.OnlineHospitalAppointment.Panel.Models.Views
{
    public record ExpertView
    {
        public int Id { get; init; }
        public string FullName { get; init; }
        public string Specialist { get; init; }
        public string Address { get; init; }
    }
}