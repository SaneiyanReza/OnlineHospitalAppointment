namespace OnlineHospitalAppointment.WinForm.Panel.OnlineHospitalAppointment.Admin.Models.Views
{
    public class UserView
    {
        public int Id { get; init; }
        public string UserName { get; init; }
        public string FullName { get; init; }
        public string NationalCode { get; init; }
        public string PhoneNumber { get; init; }
        public string BirthDay { get; init; }
        public bool IsDeleted { get; init; }
        public bool IsSuspend { get; init; }
    }
}