namespace OnlineHospitalAppointment.WinForm.Panel.OnlineHospitalAppointment.Panel.Models.Dtos
{
    public record ExpertDto
    {
        public int Id { get; init; }
        public string FullName { get; init; }
        public string Specialist { get; init; }
        public string ProvienceName { get; init; }
        public string CityName { get; init; }
    }
}