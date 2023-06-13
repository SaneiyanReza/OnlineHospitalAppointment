﻿namespace OnlineHospitalAppointment.WinForm.Panel.OnlineHospitalAppointment.Admin.Models.Dtos
{
    public class UserDto
    {
        public int Id { get; init; }
        public string UserName { get; init; }
        public string Name { get; init; }
        public string LastName { get; init; }
        public string NationalCode { get; init; }
        public string PhoneNumber { get; init; }
        public int BirthDay { get; init; }
        public bool IsDeleted { get; init; }
        public bool IsSuspend { get; init; }
    }
}