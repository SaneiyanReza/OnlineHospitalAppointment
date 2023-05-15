namespace OnlineHospitalAppointment.WinForm.Panel.OnlineHospitalAppointment.Panel.Models.Views
{
    public class UserAppointmentView
    {
        public int Id { get; init; }
        public string FullName { get; init; }
        public string Specialist { get; init; }
        public string Address { get; init; }
        public string TrackingCode { get; init; }
        public string ReservedDateTime { get; init; }
        public bool IsCanceled { get; init; }
    }
}