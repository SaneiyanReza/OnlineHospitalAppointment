namespace OnlineHospitalAppointment.WinForm.Panel.OnlineHospitalAppointment.Admin.Models.Views
{
    public record ExpertAddAppointmentChartView
    {
        public string AppointmentDate { get; init; }
        public bool IsReserved { get; init; }
    }
}