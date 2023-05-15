namespace OnlineHospitalAppointment.WinForm.Panel.OnlineHospitalAppointment.Panel.Models.Dtos
{
    public record ReservationLogDto
    {
        public int UserId { get; set; }
        public string[] TrackingCodes { get; set; }
    }
}