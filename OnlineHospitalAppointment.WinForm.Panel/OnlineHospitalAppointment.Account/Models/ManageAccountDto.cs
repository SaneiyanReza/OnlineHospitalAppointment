namespace OnlineHospitalAppointment.WinForm.Panel.OnlineHospitalAppointment.Account.Models
{
    public record ManageAccountDto
    {
        public string NationalCode { get; init; }
        public string Name { get; init; }
        public string LastName { get; init; }
        public bool IsMale { get; init; }
        public string PhoneNumber { get; init; }
        public string BirthDay { get; init; }
    }
}