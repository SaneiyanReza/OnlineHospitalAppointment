namespace OnlineHospitalAppointment.WinForm.Panel.OnlineHospitalAppointment.Panel.Models.Dtos
{
    public record ReservationLogDto
    {
        public int[] UserAppointmentDates { get; set; }
        public int SelectAppointmentDate { get; set; }
        public string[] TrackingCodes { get; set; }
    }
}