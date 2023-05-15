namespace OnlineHospitalAppointment.WinForm.Panel.OnlineHospitalAppointment.Panel.Models.Dtos
{
    public record ReservationLogDto
    {
        public int[] ExpertTimeReserved { get; set; }
        public int ExpertFreeTime { get; set; }
        public string[] TrackingCodes { get; set; }
    }
}