namespace OnlineHospitalAppointment.WinForm.Panel.OnlineHospitalAppointment.Panel.Models.Views
{
    public record UserAppointmentView
    {
        public int AppointmentChartId { get; init; }
        public string FullName { get; init; }
        public string Specialist { get; init; }
        public string Address { get; init; }
        public string TrackingCode { get; init; }
        public string AppointmentDateTime { get; init; }
        public string ReservedDateTime { get; init; }
        public bool IsCanceled { get; init; }
    }
}