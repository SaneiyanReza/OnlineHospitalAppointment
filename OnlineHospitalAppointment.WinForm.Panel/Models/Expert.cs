﻿namespace OnlineHospitalAppointment.WinForm.Panel.Models;

public partial class Expert
{
    public int Id { get; set; }

    public string FullName { get; set; }

    public int SpecialistTypeId { get; set; }

    public int CityId { get; set; }

    public int CreateDateTime { get; set; }

    public int UserId { get; set; }

    public virtual ICollection<ReservationLog> ReservationLogs { get; } = new List<ReservationLog>();

    public virtual User User { get; set; }
}