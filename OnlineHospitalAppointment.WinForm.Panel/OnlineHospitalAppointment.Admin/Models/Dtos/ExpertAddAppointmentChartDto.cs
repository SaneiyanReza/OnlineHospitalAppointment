namespace OnlineHospitalAppointment.WinForm.Panel.OnlineHospitalAppointment.Admin.Models.Dtos
{
    public record ExpertAddAppointmentChartDto
    {
        public int AppointmentDate { get; init; }
        public bool IsReserved { get; init; }
    }
}