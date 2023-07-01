namespace OnlineHospitalAppointment.WinForm.Panel.OnlineHospitalAppointment.Panel.Models.Views
{
    public record UserAppointmentChartView
    {
        public int Id { get; init; }
        public string AppointmentDate { get; init; }
        public bool IsReserved { get; init; }
        public string FullName { get; init; }
    }
}