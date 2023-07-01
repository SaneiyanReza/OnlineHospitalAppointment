namespace OnlineHospitalAppointment.WinForm.Panel.OnlineHospitalAppointment.Panel.Models.Dtos
{
    public record UserAppointmentDto
    {
        public int Id { get; init; }
        public string FullName { get; init; }
        public string Specialist { get; init; }
        public string Address { get; init; }
        public string TrackingCode { get; init; }
        public int AppointmentDate { get; init; }
        public int ReservedAt { get; init; }
        public bool IsCanceled { get; init; }
    }
}