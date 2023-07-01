namespace OnlineHospitalAppointment.WinForm.Panel.OnlineHospitalAppointment.Panel.Models.Dtos
{
    public record UserAppointmentChartDto
    {
        public int Id { get; init; }
        public int UserId { get; init; }
        public int ExpertId { get; init; }
        public int AppointmentDate { get; init; }
        public bool IsReserved { get; init; }
        public string FullName { get; init; }
    }
}