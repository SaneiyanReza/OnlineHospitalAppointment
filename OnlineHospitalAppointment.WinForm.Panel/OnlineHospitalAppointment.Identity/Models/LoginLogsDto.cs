﻿namespace OnlineHospitalAppointment.WinForm.Panel.OnlineHospitalAppointment.Identity.Models
{
    public record LoginLogsDto
    {
        public int UserId { get; init; }
        public string UserName { get; init; }
        public string Password { get; init; }
        public int RoleId { get; init; }
    }
}